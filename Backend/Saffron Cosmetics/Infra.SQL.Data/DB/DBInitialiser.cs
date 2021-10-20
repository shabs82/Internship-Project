using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using SafCos.Core.Helper;

namespace Infra.SQL.Data.DB
{
   

    public class DBInitialiser : IDBInitialiser
    {
        private readonly IAuthenticationHelper _authenticationHelper;
        private readonly IUserRepo _userRepo;

        public DBInitialiser(IAuthenticationHelper authentication, IUserRepo userRepo)
        {
            _authenticationHelper = authentication;
            _userRepo = userRepo;
        }

        public void SeedDB(SafCosmeticsContext ctx)
        {

            #region Primary Category
            PrimaryCategory primClass1 = ctx.PrimaryCategories.Add(new PrimaryCategory()
            {
                Name = "Eyes"
            }).Entity;

            PrimaryCategory primClass2 = ctx.PrimaryCategories.Add(new PrimaryCategory()
            {
                Name = "Lips"
            }).Entity;

            PrimaryCategory primClass3 = ctx.PrimaryCategories.Add(new PrimaryCategory()
            {
                Name = "Nails"
            }).Entity;

            PrimaryCategory primClass4 = ctx.PrimaryCategories.Add(new PrimaryCategory()
            {
                Name = "Face"
            }).Entity;

            PrimaryCategory primClass5 = ctx.PrimaryCategories.Add(new PrimaryCategory()
            {
                Name = "Makeup/Accessories"
            }).Entity;

            PrimaryCategory primClass6 = ctx.PrimaryCategories.Add(new PrimaryCategory()
            {
                Name = "GiftSets"
            }).Entity;

            PrimaryCategory primClass7 = ctx.PrimaryCategories.Add(new PrimaryCategory()
            {
                Name = "Fragrance"
            }).Entity;
            #endregion

            ctx.SaveChanges();


            #region Secondary Category
            SecondaryCategory secClass1 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "EyePencil",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass2 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Mascara",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass3 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Eyebrows",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass4 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "EyeLenses",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass5 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "EyeLiner",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass6 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "EyeShadow",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass7 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Kajal & EyeShade",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass8 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "EyeLashes",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass9 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "EyePencil",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass10 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "LipStick",
                PrimaryCategoryId = 2

            }).Entity;//loads of variant , needs filter

            SecondaryCategory secClass11 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "LipGloss",
                PrimaryCategoryId = 2

            }).Entity;

            SecondaryCategory secClass12 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "LipLiner",
                PrimaryCategoryId = 2

            }).Entity;

            SecondaryCategory secClass13 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "LipPencil",
                PrimaryCategoryId = 2

            }).Entity;

            SecondaryCategory secClass14 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "NailPolish",
                PrimaryCategoryId = 3

            }).Entity; // loads of polishes , will need filter

            SecondaryCategory secClass15 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "NailAccessories",
                PrimaryCategoryId = 3

            }).Entity;

            SecondaryCategory secClass16 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "CompactPowder",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass17 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Foundation",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass18 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Blushes",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass19 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Concealer",
                PrimaryCategoryId = 4

            }).Entity; // contour and pencil needs filtering.

            SecondaryCategory secClass20 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Primer",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass21 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Highlighters / Bronzing",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass22 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Applicators",
                PrimaryCategoryId = 5

            }).Entity;

            SecondaryCategory secClass23 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "Brushes",
                PrimaryCategoryId = 5

            }).Entity;

            SecondaryCategory secClass24 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Name = "VanityCase",
                PrimaryCategoryId = 5

            }).Entity;
            #endregion


            #region Brands
            Brand brand1 = ctx.Brands.Add(new Brand()
            {
                BrandName = "L'oreal"

            }).Entity;

            Brand brand2 = ctx.Brands.Add(new Brand()
            {
                BrandName = "Revlon"

            }).Entity;

            Brand brand3 = ctx.Brands.Add(new Brand()
            {
                BrandName = "Wet n Wild"

            }).Entity;

            Brand brand4 = ctx.Brands.Add(new Brand()
            {
                BrandName = "Collection2000"

            }).Entity;

            Brand brand5 = ctx.Brands.Add(new Brand()
            {
                BrandName = "ConstanceCarroll"

            }).Entity;

            Brand brand6 = ctx.Brands.Add(new Brand()
            {
                BrandName = "Bourjois"

            }).Entity;

            Brand brand7 = ctx.Brands.Add(new Brand()
            {
                BrandName = "SaffronLondon"

            }).Entity;

            Brand brand8 = ctx.Brands.Add(new Brand()
            {
                BrandName = "Fragrance World"

            }).Entity;
            #endregion


            #region Genders

            Gender gender1 = ctx.Genders.Add(new Gender()
            {
                Sex = "Female"

            }).Entity;

            Gender gender2 = ctx.Genders.Add(new Gender()
            {
                Sex = "Male"

            }).Entity;

            Gender gender3 = ctx.Genders.Add(new Gender()
            {
                Sex = "Unisex"

            }).Entity;

            Gender gender4 = ctx.Genders.Add(new Gender()
            {
                Sex = "No Genre"

            }).Entity;
            #endregion 

            ctx.SaveChanges();

            #region Products 

            Product product1ep = ctx.Products.Add(new Product()
            {
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "120",
                Name = "Saffron 2in1 Black & White Pencil",
                Price = 2.25,
                GenderId = gender2.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339901110",
                Description = "Saffron Black & White Eyeliner is a stunning duo eyeliner pencil that can be used to line, " +
                              "define and create stunning effects with this great value eye liner pencil duo. " +
                              "A must have addition to every girls makeup bag!!!",
            }).Entity;


            Product product2ep = ctx.Products.Add(new Product()
            {
                SecondaryCategoryId = secClass1.Id,
                ProductCode = " 101",
                Name = " Saffron Eye Brow Pencil-Black",
                Price = 1.99,
                BrandId = brand2.Id,
                Availability = 72,
                SkuCode = "5055339900649",
                Description = "Bring out the shape of your face with the Saffron Eyebrow Pencil. " +
                              "This eyebrow pencil gives a well defined and groomed shape to your eyebrows which help enhance your look. " +
                              "Get perfectly accentuated eyebrows with Saffron eyebrow pencil. " +
                              "It's easy to use, easy to sharpen.",
            }).Entity;

            Product product3ep = ctx.Products.Add(new Product()
            {
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "104",
                Name = "Saffron Eye Brow Pencil–Blonde",
                Price = 2.25,
                BrandId = brand2.Id,
                Availability = 72,
                SkuCode = "5055339900892",
                Description = "Bring out the shape of your face with the Saffron Eyebrow Pencil. " +
                              "This eyebrow pencil gives a well defined and groomed shape to your eyebrows which help enhance your look. " +
                              "Get perfectly accentuated eyebrows with Saffron eyebrow pencil. It's easy to use, easy to sharpen.",

            }).Entity;

            //Product product4ep = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 1,
            //    ProductCode = "102",
            //    Name = "Saffron Eye Brow Pencil – Brown",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900656",
            //    Description = "Bring out the shape of your face with the Saffron Eyebrow Pencil. " +
            //                  "This eyebrow pencil gives a well defined and groomed shape to your eyebrows which help enhance your look. " +
            //                  "Get perfectly accentuated eyebrows with Saffron eyebrow pencil. It's easy to use, easy to sharpen.",

            //}).Entity;

            //Product product5ep = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 1,
            //    ProductCode = "113",
            //    Name = "Saffron Eye Liner Pencil – Golden Chrome",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 63,
            //    SkuCode = "#5055339901042",
            //    Description = "Saffron Kohl pencil with smooth texture glides on easily for precise lines or Smokey looks. " +
            //                  "Rich in pigments for amazing eye intensity.",

            //}).Entity;

            //Product product6ep = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 1,
            //    ProductCode = "207",
            //    Name = "Saffron Glitter Makeup Pencil Black",
            //    Price = 2.25,
            //    BrandId = 7,
            //    Availability = 24,
            //    SkuCode = "5055339903794",
            //    Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply." +
            //                 " They are very easy to blend and can be used as eyeshadows. " +
            //                 " Glitter Liner Pencil for dazzling looks with an intense colour finish.  " +
            //                 "Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, Purple, Red. With Free Sharpener",

            //}).Entity;

            //Product product7ep = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 1,
            //    ProductCode = "208",
            //    Name = "Saffron Glitter Makeup Pencil Blue",
            //    Price = 2.25,
            //    BrandId = 7,
            //    Availability = 24,
            //    SkuCode = "5055339903800",
            //    Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply. " +
            //    "They are very easy to blend and can be used as eyeshadows.  " +
            //    "Glitter Liner Pencil for dazzling looks with an intense colour finish.  " +
            //    "Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, " +
            //    "Purple, Red.With Free Sharpener",

            //}).Entity;

            //Product product8ep = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 1,
            //    ProductCode = "209",
            //    Name = "Saffron Glitter Makeup Pencil Silver",
            //    Price = 2.25,
            //    BrandId = 7,
            //    Availability = 24,
            //    SkuCode = "5055339903817",
            //    Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply." +
            //                  " They are very easy to blend and can be used as eyeshadows. " +
            //                  "Glitter Liner Pencil for dazzling looks with an intense colour finish." +
            //                  " Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, Purple, Red. " +
            //                  "With Free Sharpener",

            //}).Entity;


            //Product product9ep = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 1,
            //    ProductCode = "210",
            //    Name = "Saffron Glitter Makeup Pencil Gold",
            //    Price = 2.25,
            //    BrandId = 7,
            //    Availability = 24,
            //    SkuCode = "5055339903824",
            //    Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply." +
            //                  " They are very easy to blend and can be used as eyeshadows. " +
            //                  "Glitter Liner Pencil for dazzling looks with an intense colour finish." +
            //                  " Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, Purple, Red. " +
            //                  "With Free Sharpener",


            //}).Entity;

            //Product product10ep = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 1,
            //    ProductCode = "211",
            //    Name = "Saffron Glitter Makeup Pencil Green",
            //    Price = 2.25,
            //    BrandId = 7,
            //    Availability = 24,
            //    SkuCode = "5055339903831",
            //    Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply." +
            //                 " They are very easy to blend and can be used as eyeshadows. " +
            //                 "Glitter Liner Pencil for dazzling looks with an intense colour finish." +
            //                 " Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, Purple, Red. " +
            //                 "With Free Sharpener",


            //}).Entity;

            ////Lipstick

            //Product productLs1 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Berry",
            //    Variant = "10",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //                  "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //                  "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //                  "Colour Nos. 43 to 48 Catwalk Colours. " +
            //                  "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs2 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Black Coffee",
            //    Variant = "19",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //                 "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //                 "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //                 "Colour Nos. 43 to 48 Catwalk Colours. " +
            //                 "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs3 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Brick",
            //    Variant = "3",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //               "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //               "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //               "Colour Nos. 43 to 48 Catwalk Colours. " +
            //               "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs4 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Burgundy Beauty",
            //    Variant = "48",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //              "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //              "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //              "Colour Nos. 43 to 48 Catwalk Colours. " +
            //              "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs5 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Cabaret",
            //    Variant = "31",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //             "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //             "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //             "Colour Nos. 43 to 48 Catwalk Colours. " +
            //             "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs6 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Canberry",
            //    Variant = "9",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //            "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //            "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //            "Colour Nos. 43 to 48 Catwalk Colours. " +
            //            "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs7 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Conker",
            //    Variant = "43",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //            "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //            "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //            "Colour Nos. 43 to 48 Catwalk Colours. " +
            //            "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs8 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Current",
            //    Variant = "7",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //           "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //           "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //           "Colour Nos. 43 to 48 Catwalk Colours. " +
            //           "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs9 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Diamond Red",
            //    Variant = "5",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 69,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //          "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //          "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //          "Colour Nos. 43 to 48 Catwalk Colours. " +
            //          "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;

            //Product productLs10 = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 10,
            //    ProductCode = "0134",
            //    Name = "Saffron Lipstick Euphoric",
            //    Variant = "46",
            //    Price = 1.99,
            //    BrandId = 7,
            //    Availability = 71,
            //    SkuCode = "5055339900151",
            //    Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
            //        "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
            //        "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
            //        "Colour Nos. 43 to 48 Catwalk Colours. " +
            //        "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            //}).Entity;
            ////Nails

            //Product product1Np = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 14,
            //    ProductCode = "1013",
            //    Name = "Saffron Nail Polish Base Coat",
            //    Variant = "56",
            //    Price = 2.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339903237",
            //    Description = "Saffron Base Coat formula strengthens nails with a smooth, hard finish that grips nail colours.",

            //}).Entity;

            //Product product2Np = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 14,
            //    ProductCode = "1013",
            //    Name = "Saffron Nail Polish Beige French Manicure",
            //    Variant = "59",
            //    Price = 2.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339903237",
            //    Description = "Saffron French Manicure Polish helps you to create the classic French manicure." +
            //                  " Available in Pink, Beige and White simply seal with a top coat for a long lasting finish.",

            //}).Entity;

            //Product product3Np = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 14,
            //    ProductCode = "1013",
            //    Name = "Saffron Nail Polish Bikini Blue",
            //    Variant = "43",
            //    Price = 2.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339903237",
            //    Description = "Saffron Nail Varnish: Trend setting shades with a top quality formula long lasting, chip resistant nail lacquer.",

            //}).Entity;

            //Product product4Np = ctx.Products.Add(new Product()
            //{
            //    SecondaryCategoryId = 14,
            //    ProductCode = "1013",
            //    Name = "Saffron Nail Polish Blossom",
            //    Variant = "15",
            //    Price = 2.99,
            //    BrandId = 7,
            //    Availability = 72,
            //    SkuCode = "5055339903237",
            //    Description = "Saffron Nail Varnish: Trend setting shades with a top quality formula long lasting, chip resistant nail lacquer.",

            //}).Entity;
            #endregion

            ctx.SaveChanges();

            #region Users
            string password = "1234";
            byte[] passwordHashJohn, passwordSaltJohn, passwordHashAnna, passwordSaltAnna;
            _authenticationHelper.CreatePasswordHash(password, out passwordHashJohn, out passwordSaltJohn);
            _authenticationHelper.CreatePasswordHash(password, out passwordHashAnna, out passwordSaltAnna);

            var Admin = new User()
            {
                Username = "Admin",
                PasswordHash = passwordHashJohn,
                PasswordSalt = passwordSaltJohn,
                IsAdmin = true
            };
            _userRepo.CreateUser(Admin);

            var User = new User()
            {
                Username = "User",
                PasswordHash = passwordHashAnna,
                PasswordSalt = passwordSaltAnna,
                IsAdmin = false
            };
            _userRepo.CreateUser(User);
            #endregion

        }
    }
}
