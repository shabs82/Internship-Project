using FluentValidation;
using Infra.SQL.Data;
using Infra.SQL.Data.DB;
using Infra.SQL.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using SafCos.Core.AppService.Service;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SafCos.Core.Helper;
using SafCos.Core.AppService.ValidatorInterface;
using SafCos.Core.AppService.Validators;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment Environment { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            if (Environment.IsDevelopment())
            {
            #region DB Settings
                services.AddDbContext<SafCosmeticsContext>(
                    opt =>
                    {
                        opt.UseLoggerFactory(loggerFactory);
                        opt.UseSqlite("Data Source = safCosmetics.db");
                    });
            }
            else
            {
                services.AddDbContext<SafCosmeticsContext>(
                  opt =>
                  {
                      opt.UseLoggerFactory(loggerFactory);
                      opt.UseSqlServer(Configuration.GetConnectionString("defaultConnection"));
                  });
            }
            Byte[] secretBytes = new byte[40];
            Random rand = new Random();
            rand.NextBytes(secretBytes);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,//can be used for external providers like google, fb, twitter....
                    ValidateIssuer = false,//can be used for external providers like google, fb, twitter....
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secretBytes),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(5)
                };
            });
            #endregion
            #region AddScoped
            services.AddScoped<IPrimaryCategoryService, PrimaryCategoryService>();
            services.AddScoped<IPrimaryCategoryRepo, PrimaryCategoryRepo>();

            services.AddScoped<ISecondaryCategoryService, SecondaryCategoryService>();
            services.AddScoped<ISecondaryCategoryRepo, SecondaryCategoryRepo>();

            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepo, BrandRepo>();

            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IGenderRepo, GenderRepo>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<IProductValidator,ProductValidator>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<UserValidator>();
            


            services.AddTransient<IDBInitialiser, DBInitialiser>();

            services.AddSingleton<IAuthenticationHelper>(new
              AuthenticationHelper(secretBytes));
            #endregion
            #region Ignore Loops
            //JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            //{
            //    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //};

            #endregion
            #region CORS
           
            services.AddCors(options => options.AddPolicy("AllowEverything", builder => builder.AllowAnyOrigin()
                                                                                               .AllowAnyMethod()
                                                                                               .AllowAnyHeader()));
            
            #endregion
            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplication1", Version = "v1" });
            });
            #endregion

            //services.AddFluentValidation( fv=>
            //    {
            //        fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
            //        fv.RegisterValidatorsFromAssemblyContaining<Startup>();

            //     }
            //    );
            services.AddMvc().AddNewtonsoftJson();
            services.AddControllers().AddNewtonsoftJson(options =>
            {    // Use the default property (Pascal) casing
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.MaxDepth = 5;
            });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                using var scope = app.ApplicationServices.CreateScope();
                var ctx = scope.ServiceProvider.GetRequiredService<SafCosmeticsContext>();
                var dbInitialiser = scope.ServiceProvider.GetRequiredService<IDBInitialiser>();

                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
                dbInitialiser.SeedDB(ctx);



            }
            else if (env.IsProduction())
            {
                using var scope = app.ApplicationServices.CreateScope();
                var ctx = scope.ServiceProvider.GetRequiredService<SafCosmeticsContext>();
                var dbInitialiser = scope.ServiceProvider.GetRequiredService<IDBInitialiser>();

                ctx.Database.EnsureCreated();
            }


                app.UseCors("AllowEverything");

                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthentication();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplication1 v1"));
            
        }
    }
}
