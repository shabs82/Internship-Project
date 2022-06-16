using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using Moq;
using SafCos.Core.AppService.Service;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.AppService.ValidatorInterface;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using TechTalk.SpecFlow;

namespace SpecFlowProj.Hooks
{
    [Binding]
    public class ProductHooks
    {
        private readonly IObjectContainer container;
        private readonly ScenarioContext _scenarioContext;
        private readonly Mock<IProductRepo> _mockProductRepo;
        private readonly Mock<IProductValidator> _mockProductValidator;

        public ProductHooks(ScenarioContext scenarioContext, IObjectContainer container)
        {
            this.container = container;
            _scenarioContext = scenarioContext;
            _mockProductRepo = new Mock<IProductRepo>();
            _mockProductValidator = new Mock<IProductValidator>();
        }

        [BeforeScenario]
        public void InitializeBookingManager()
        {
            var productService = new ProductService(_mockProductRepo.Object, _mockProductValidator.Object);
            container.RegisterInstanceAs<IProductService>(productService);
        }

        [BeforeScenario]
        public void AddProductWithZeroAvailability()
        {
            var listOfProducts = new List<Product>{
                new Product
                {
                    Id = 1,
                    ProductCode = "test",
                    Name = "test",
                    Variant = null,
                    Price = 10.00,
                    Availability = 0,
                    Description = "test",
                    SkuCode = "test",
                    SecondaryCategoryId = 1
                },
                new Product {Id =  2, ProductCode="Check", Name = "Check Check", Variant = null, Price = 10.00, Availability = 2,
                    Description = "Check Check", SkuCode = "Check", SecondaryCategoryId = 1},
                new Product {Id =  3, ProductCode="123code", Name = "Lipstick", Variant = null, Price = 10.00, Availability = 26,
                    Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                };


            _mockProductRepo.Setup(repo => repo.GetProductById(2)).Returns(() => listOfProducts[1]);
            _mockProductRepo.Setup(repo => repo.GetProductById(1)).Returns(() => listOfProducts[0]);
        }

        [BeforeScenario]
        public void AddProductWithLowAvailability()
        {
            var listOfProducts = new List<Product>{
                new Product
                {
                    Id = 1,
                    ProductCode = "test",
                    Name = "test",
                    Variant = null,
                    Price = 10.00,
                    Availability = 0,
                    Description = "test",
                    SkuCode = "test",
                    SecondaryCategoryId = 1
                },
                new Product {Id =  2, ProductCode="Check", Name = "Check Check", Variant = null, Price = 10.00, Availability = 2,
                    Description = "Check Check", SkuCode = "Check", SecondaryCategoryId = 1},
                new Product {Id =  3, ProductCode="123code", Name = "Lipstick", Variant = null, Price = 10.00, Availability = 26,
                    Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                };


            _mockProductRepo.Setup(repo => repo.GetProductById(2)).Returns(() => listOfProducts[1]);
        }
    }
}
