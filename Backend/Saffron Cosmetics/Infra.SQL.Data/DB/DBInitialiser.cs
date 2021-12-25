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
                Id = 1,
                Name = "EyePencil",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass2 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 2,
                Name = "Mascara",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass3 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 3,
                Name = "Eyebrows",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass4 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 4,
                Name = "EyeLenses",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass5 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 5,
                Name = "EyeLiner",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass6 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 6,
                Name = "EyeShadow",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass7 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 7,
                Name = "Kajal & EyeShade",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass8 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 8,
                Name = "EyeLashes",
                PrimaryCategoryId = 1

            }).Entity;

            SecondaryCategory secClass10 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 10,
                Name = "LipStick",
                PrimaryCategoryId = 2

            }).Entity;//loads of variant , needs filter

            SecondaryCategory secClass11 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 11,
                Name = "LipGloss",
                PrimaryCategoryId = 2

            }).Entity;

            SecondaryCategory secClass12 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 12,
                Name = "LipLiner",
                PrimaryCategoryId = 2

            }).Entity;

            SecondaryCategory secClass13 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 13,
                Name = "LipPencil",
                PrimaryCategoryId = 2

            }).Entity;

            SecondaryCategory secClass14 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 14,
                Name = "NailPolish",
                PrimaryCategoryId = 3

            }).Entity; // loads of polishes , will need filter

            SecondaryCategory secClass15 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 15,
                Name = "NailAccessories",
                PrimaryCategoryId = 3

            }).Entity;

            SecondaryCategory secClass16 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 16,
                Name = "CompactPowder",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass17 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 17,
                Name = "Foundation",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass18 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 18,
                Name = "Blushes",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass19 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 19,
                Name = "Concealer",
                PrimaryCategoryId = 4

            }).Entity; // contour and pencil needs filtering.

            SecondaryCategory secClass20 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 20,
                Name = "Primer",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass21 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 21,
                Name = "Highlighters / Bronzing",
                PrimaryCategoryId = 4

            }).Entity;

            SecondaryCategory secClass22 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 22,
                Name = "Applicators",
                PrimaryCategoryId = 5

            }).Entity;

            SecondaryCategory secClass23 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 23,
                Name = "Brushes",
                PrimaryCategoryId = 5

            }).Entity;

            SecondaryCategory secClass24 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 24,
                Name = "VanityCase",
                PrimaryCategoryId = 5

            }).Entity;

            SecondaryCategory secClass25 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 25,
                Name = "MensPerfume",
                PrimaryCategoryId = 7

            }).Entity;

            SecondaryCategory secClass26 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 26,
                Name = "WomensFragrance",
                PrimaryCategoryId = 7

            }).Entity;

            SecondaryCategory secClass27 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 27,
                Name = "UnisexFragrance",
                PrimaryCategoryId = 7

            }).Entity;

            SecondaryCategory secClass28 = ctx.SecondaryCategories.Add(new SecondaryCategory()
            {
                Id = 28,
                Name = "GiftSets",
                PrimaryCategoryId = 6

            }).Entity;

            #endregion


            #region Brands
            Brand brand1 = ctx.Brands.Add(new Brand()
            {
                Id = 1,
                BrandName = "L'oreal"

            }).Entity;

            Brand brand2 = ctx.Brands.Add(new Brand()
            {
                Id = 2,
                BrandName = "Revlon"

            }).Entity;

            Brand brand3 = ctx.Brands.Add(new Brand()
            {
                Id = 3,
                BrandName = "Wet n Wild"

            }).Entity;

            Brand brand4 = ctx.Brands.Add(new Brand()
            {
                Id = 4,
                BrandName = "Collection2000"

            }).Entity;

            Brand brand5 = ctx.Brands.Add(new Brand()
            {
                Id = 5,
                BrandName = "ConstanceCarroll"

            }).Entity;

            Brand brand6 = ctx.Brands.Add(new Brand()
            {
                Id = 6,
                BrandName = "Bourjois"

            }).Entity;

            Brand brand7 = ctx.Brands.Add(new Brand()
            {
                Id = 7,
                BrandName = "SaffronLondon"

            }).Entity;

            Brand brand8 = ctx.Brands.Add(new Brand()
            {
                Id = 8,
                BrandName = "Fragrance World"

            }).Entity;
            #endregion


            #region Genders

            Gender gender1 = ctx.Genders.Add(new Gender()
            {
                Id = 1,
                Sex = "Female"

            }).Entity;

            Gender gender2 = ctx.Genders.Add(new Gender()
            {
                Id = 2,
                Sex = "Male"

            }).Entity;

            Gender gender3 = ctx.Genders.Add(new Gender()
            {
                Id = 3,
                Sex = "Unisex"

            }).Entity;

            Gender gender4 = ctx.Genders.Add(new Gender()
            {
                Id = 4,
                Sex = "No Gender"

            }).Entity;
            #endregion 

            ctx.SaveChanges();

            #region Products 

            Product product1ep = ctx.Products.Add(new Product()
            {
                Id = 1,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "120",
                Name = "Saffron 2in1 Black & White Pencil",
                Price = 2.25,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339901110",
                Description = "Saffron Black & White Eyeliner is a stunning duo eyeliner pencil that can be used to line, " +
                              "define and create stunning effects with this great value eye liner pencil duo. " +
                              "A must have addition to every girls makeup bag!!!",
            }).Entity;


            Product product2ep = ctx.Products.Add(new Product()
            {
                Id = 2,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = " 101",
                Name = " Saffron Eye Brow Pencil-Black",
                Price = 1.99,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900649",
                Description = "Bring out the shape of your face with the Saffron Eyebrow Pencil. " +
                              "This eyebrow pencil gives a well defined and groomed shape to your eyebrows which help enhance your look. " +
                              "Get perfectly accentuated eyebrows with Saffron eyebrow pencil. " +
                              "It's easy to use, easy to sharpen.",
            }).Entity;

            Product product3ep = ctx.Products.Add(new Product()
            {
                Id = 3 ,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "104",
                Name = "Saffron Eye Brow Pencil–Blonde",
                Price = 2.25,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900892",
                Description = "Bring out the shape of your face with the Saffron Eyebrow Pencil. " +
                              "This eyebrow pencil gives a well defined and groomed shape to your eyebrows which help enhance your look. " +
                              "Get perfectly accentuated eyebrows with Saffron eyebrow pencil. It's easy to use, easy to sharpen.",

            }).Entity;

            Product product4ep = ctx.Products.Add(new Product()
            {
                Id = 4,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "102",
                Name = "Saffron Eye Brow Pencil – Brown",
                Price = 1.99,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900656",
                Description = "Bring out the shape of your face with the Saffron Eyebrow Pencil. " +
                              "This eyebrow pencil gives a well defined and groomed shape to your eyebrows which help enhance your look. " +
                              "Get perfectly accentuated eyebrows with Saffron eyebrow pencil. It's easy to use, easy to sharpen.",

            }).Entity;

            Product product5ep = ctx.Products.Add(new Product()
            {
                Id = 5,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "113",
                Name = "Saffron Eye Liner Pencil – Golden Chrome",
                Price = 1.99,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 63,
                SkuCode = "#5055339901042",
                Description = "Saffron Kohl pencil with smooth texture glides on easily for precise lines or Smokey looks. " +
                              "Rich in pigments for amazing eye intensity.",

            }).Entity;

            Product product6ep = ctx.Products.Add(new Product()
            {
                Id = 6,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "207",
                Name = "Saffron Glitter Makeup Pencil Black",
                Price = 2.25,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339903794",
                Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply." +
                             " They are very easy to blend and can be used as eyeshadows. " +
                             " Glitter Liner Pencil for dazzling looks with an intense colour finish.  " +
                             "Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, Purple, Red. With Free Sharpener",

            }).Entity;

            Product product7ep = ctx.Products.Add(new Product()
            {
                Id = 7,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "208",
                Name = "Saffron Glitter Makeup Pencil Blue",
                Price = 2.25,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339903800",
                Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply. " +
                "They are very easy to blend and can be used as eyeshadows.  " +
                "Glitter Liner Pencil for dazzling looks with an intense colour finish.  " +
                "Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, " +
                "Purple, Red.With Free Sharpener",

            }).Entity;

            Product product8ep = ctx.Products.Add(new Product()
            {
                Id = 8,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "209",
                Name = "Saffron Glitter Makeup Pencil Silver",
                Price = 2.25,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339903817",
                Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply." +
                              " They are very easy to blend and can be used as eyeshadows. " +
                              "Glitter Liner Pencil for dazzling looks with an intense colour finish." +
                              " Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, Purple, Red. " +
                              "With Free Sharpener",

            }).Entity;


            Product product9ep = ctx.Products.Add(new Product()
            {
                Id = 9,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "210",
                Name = "Saffron Glitter Makeup Pencil Gold",
                Price = 2.25,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339903824",
                Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply." +
                              " They are very easy to blend and can be used as eyeshadows. " +
                              "Glitter Liner Pencil for dazzling looks with an intense colour finish." +
                              " Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, Purple, Red. " +
                              "With Free Sharpener",


            }).Entity;

            Product product10ep = ctx.Products.Add(new Product()
            {
                Id = 10,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "211",
                Name = "Saffron Glitter Makeup Pencil Green",
                Price = 2.25,
                GenderId = gender4.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339903831",
                Description = "Saffron Glitter Liner Pencil is soft and glides on as you apply." +
                             " They are very easy to blend and can be used as eyeshadows. " +
                             "Glitter Liner Pencil for dazzling looks with an intense colour finish." +
                             " Available in 7 Glitter Colours: Black, Blue, Silver Gold, Green, Purple, Red. " +
                             "With Free Sharpener",


            }).Entity;

            //eye shadow

            Product productEsh1 = ctx.Products.Add(new Product()
            {
                Id = 51,
                SecondaryCategoryId = secClass6.Id,
                ProductCode = "9285",
                Name = "Black/White Eyeshadow A",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 23,
                SkuCode = "5055339907624",
                Description = "SAFFRON - Matte Black & White Duo EyeShadow provides natural hint of colours. " +
                              " The eyeshadows in this palette have a beautiful texture and are extremely soft - they blend like a dream. " +
                              "The pigmentation is amazing. The colours look extremely vibrant even without using any eyeshadow base. " +
                              " The colours can be used individually or the white colour can be used for doing the inner corner or highlighting" +
                              " the brow bone in combination with other colours, and the black colour can be used in combination with browns for doing" +
                              " a brown-black Smokey eyes.  " +
                              "Dual ended applicator included to blend, smudge and define your looks with mirror included for anywhere use. " +
                              " 7.3 x 4.7 x 1.0 cms;  Net.:4g.",


            }).Entity;

            Product productEsh2 = ctx.Products.Add(new Product()
            {
                Id = 52,
                SecondaryCategoryId = secClass6.Id,
                ProductCode = "9285",
                Name = "Black/White Eyeshadow B",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339907631",
                Description = "SAFFRON - Matte Black & White Duo EyeShadow provides natural hint of colours. " +
                             " The eyeshadows in this palette have a beautiful texture and are extremely soft - they blend like a dream. " +
                             "The pigmentation is amazing. The colours look extremely vibrant even without using any eyeshadow base. " +
                             " The colours can be used individually or the white colour can be used for doing the inner corner or highlighting" +
                             " the brow bone in combination with other colours, and the black colour can be used in combination with browns for doing" +
                             " a brown-black Smokey eyes.  " +
                             "Dual ended applicator included to blend, smudge and define your looks with mirror included for anywhere use. " +
                             " 7.3 x 4.7 x 1.0 cms;  Net.:4g.",


            }).Entity;


            Product productEsh3 = ctx.Products.Add(new Product()
            {
                Id = 53,
                SecondaryCategoryId = secClass6.Id,
                ProductCode = "8978",
                Name = "Matte & Metallic Eyeshadow 01",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339907563",
                Description = "MAKE EVERY DAY SPECIAL: with Saffron Matte & Metallic dazzling collection of highly " +
                              "pigmented shadows that offer the perfect mix of today’s most coveted colours. " +
                              "12 Beautiful, Blend able shades in both mega Matte and super shimmer Metallic finishes are everything you " +
                              "need to Highlight, Blend and Define Eyes. " +
                              "Fiery oranges, bright jewel tones, warm browns and Smokey blacks deliver a smooth flawless finish.  " +
                              "CREATE INFINITE LOOKS: Get the perfect blend that suits your style using the 12 hues that you can mix and match" +
                              " to create a variety of looks that fits different occasions. " +
                              " Net.:15g",


            }).Entity;

            Product productEsh4 = ctx.Products.Add(new Product()
            {
                Id = 54,
                SecondaryCategoryId = secClass6.Id,
                ProductCode = "8978",
                Name = "Matte & Metallic Eyeshadow 02",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339907570",
                Description = "MAKE EVERY DAY SPECIAL: with Saffron Matte & Metallic dazzling collection of highly " +
                             "pigmented shadows that offer the perfect mix of today’s most coveted colours. " +
                             "12 Beautiful, Blend able shades in both mega Matte and super shimmer Metallic finishes are everything you " +
                             "need to Highlight, Blend and Define Eyes. " +
                             "Fiery oranges, bright jewel tones, warm browns and Smokey blacks deliver a smooth flawless finish.  " +
                             "CREATE INFINITE LOOKS: Get the perfect blend that suits your style using the 12 hues that you can mix and match" +
                             " to create a variety of looks that fits different occasions. " +
                             " Net.:15g",


            }).Entity;

            Product productEsh5 = ctx.Products.Add(new Product()
            {
                Id = 55,
                SecondaryCategoryId = secClass6.Id,
                ProductCode = "8978",
                Name = "Matte & Metallic Eyeshadow 03",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339907587",
                Description = "MAKE EVERY DAY SPECIAL: with Saffron Matte & Metallic dazzling collection of highly " +
                            "pigmented shadows that offer the perfect mix of today’s most coveted colours. " +
                            "12 Beautiful, Blend able shades in both mega Matte and super shimmer Metallic finishes are everything you " +
                            "need to Highlight, Blend and Define Eyes. " +
                            "Fiery oranges, bright jewel tones, warm browns and Smokey blacks deliver a smooth flawless finish.  " +
                            "CREATE INFINITE LOOKS: Get the perfect blend that suits your style using the 12 hues that you can mix and match" +
                            " to create a variety of looks that fits different occasions. " +
                            " Net.:15g",


            }).Entity;

            //Kajal

            Product productKj1 = ctx.Products.Add(new Product()
            {
                Id = 56,
                SecondaryCategoryId = secClass7.Id,
                ProductCode = "1500",
                Name = "Saffron Kajal EyeShader 01 Pearl",
                Price = 3.49,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339907587",
                Description = "MAKE EVERY DAY SPECIAL: with Saffron Matte & Metallic dazzling collection of highly " +
                            "pigmented shadows that offer the perfect mix of today’s most coveted colours. " +
                            "12 Beautiful, Blend able shades in both mega Matte and super shimmer Metallic finishes are everything you " +
                            "need to Highlight, Blend and Define Eyes. " +
                            "Fiery oranges, bright jewel tones, warm browns and Smokey blacks deliver a smooth flawless finish.  " +
                            "CREATE INFINITE LOOKS: Get the perfect blend that suits your style using the 12 hues that you can mix and match" +
                            " to create a variety of looks that fits different occasions. " +
                            " Net.:15g",


            }).Entity;



            //Mascara

            Product productMs1 = ctx.Products.Add(new Product()
            {
                Id = 11,
                SecondaryCategoryId = secClass2.Id,
                ProductCode = "5620",
                Name = "Saffron Brow Mascara Black",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 23,
                SkuCode = "5055339903435",
                Description = "Saffron Brow Mascara, say goodbye to thin, sparse brows with this uniquely formulated brow enhancer"+
                               " that is designed to instantly groom and shape eyebrows."+
                               "Saffron Brow mascara wand applicator features precision bristles that deliver natural colour "+
                               "while neatly locking hairs in place all day."+
                               "Available in 3 colours: Blonde, Dark Brown, Black. Net.:8ml.",


            }).Entity;

            Product productMs2 = ctx.Products.Add(new Product()
            {
                Id = 12,
                SecondaryCategoryId = secClass2.Id,
                ProductCode = "5620",
                Name = "Saffron Brow Mascara Brown",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339903435",
                Description = "Saffron Brow Mascara, say goodbye to thin, sparse brows with this uniquely formulated brow enhancer" +
                              " that is designed to instantly groom and shape eyebrows." +
                              "Saffron Brow mascara wand applicator features precision bristles that deliver natural colour " +
                              "while neatly locking hairs in place all day." +
                              "Available in 3 colours: Blonde, Dark Brown, Black. Net.:8ml.",


            }).Entity;

            Product productMs3 = ctx.Products.Add(new Product()
            {
                Id = 13,
                SecondaryCategoryId = secClass2.Id,
                ProductCode = "5620",
                Name = "Saffron Brow Mascara Blonde",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339903435",
                Description = "Saffron Brow Mascara, say goodbye to thin, sparse brows with this uniquely formulated brow enhancer" +
                              " that is designed to instantly groom and shape eyebrows." +
                              "Saffron Brow mascara wand applicator features precision bristles that deliver natural colour " +
                              "while neatly locking hairs in place all day." +
                              "Available in 3 colours: Blonde, Dark Brown, Black. Net.:8ml.",


            }).Entity;

            Product productMs4 = ctx.Products.Add(new Product()
            {
                Id = 14,
                SecondaryCategoryId = secClass2.Id,
                ProductCode = "5554",
                Name = "Saffron Long Lash Mascara Black",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 23,
                SkuCode = "505533902155",
                Description = "Saffron Long Lashes Mascara the unique brush,"+
                              "allows a perfect distribution of the product without increasing the look but giving length"+
                              "volume and definition to the lashes from the first application.Net: 6ml.",


            }).Entity;


            Product productMs5 = ctx.Products.Add(new Product()
            {
                Id = 15,
                SecondaryCategoryId = secClass2.Id,
                ProductCode = "590",
                Name = "Saffron Mascara Black",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 23,
                SkuCode = "505533902155",
                Description = "Saffron Waterproof Mascara makes your eye seductive,smouldering and breathtaking." +
                              "It thickens your lashes, for a dark yet natural look by adding volume and fullness to the eyelashes." +
                              "The waterproof mascara provides you with a long lasting effect." +
                              "Colour: Black Net.:10g.",


            }).Entity;

            Product productMs6 = ctx.Products.Add(new Product()
            {
                Id = 16,
                SecondaryCategoryId = secClass2.Id,
                ProductCode = "399",
                Name = " Saffron Zombie Nights Double Intensity Mascara Black",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339903992",
                Description = "Saffron Zombie Nights Double Intensity Max Volume Mascara Black"+
                                "creates bold lashes with our volume plumping mascara."+
                                "Specially formulated to coat and help strengthen every lash to give them an instantly plumper look."+
                                "The dense,oversized brush head fully coats lashes for intense and dramatic effect." +
                                "Halloween, Gothic, Skull Series, 13 x 2 cm; Net.:7ml.",


            }).Entity;

            // Eyebrows

            Product prodEb1 = ctx.Products.Add(new Product()
            {
                Id = 27,
                SecondaryCategoryId = secClass3.Id,
                ProductCode = "1",
                Name = "Saffron Eye Brow Definer Black",
                Variant = "",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339902551",
                Description = "Saffron Eye Brow Definer a mechanical pencil with a unique triangular shaped tip that combines powder and wax in to create naturally defined brows." +
                              "Formula which helps you to create the look of naturally fuller, defined brows in one easy step. " +
                              "Natural looking shades to create beautiful brows. " +
                              "The double ended component has a brush to groom brows into place for that professional finish." +
                              " Net.:0.28g; 15 x 2.5 x 1.5 cm",


            }).Entity;

            Product prodEb2 = ctx.Products.Add(new Product()
            {
                Id = 28,
                SecondaryCategoryId = secClass3.Id,
                ProductCode = "2",
                Name = "Saffron Eye Brow Definer Espresso",
                Variant = "",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 23,
                SkuCode = "5055339902551",
                Description = "Saffron Eye Brow Definer a mechanical pencil with a unique triangular shaped tip that combines powder and wax in to create naturally defined brows." +
                             "Formula which helps you to create the look of naturally fuller, defined brows in one easy step. " +
                             "Natural looking shades to create beautiful brows. " +
                             "The double ended component has a brush to groom brows into place for that professional finish." +
                             " Net.:0.28g; 15 x 2.5 x 1.5 cm",


            }).Entity;

            Product prodEb3 = ctx.Products.Add(new Product()
            {
                Id = 29,
                SecondaryCategoryId = secClass3.Id,
                ProductCode = "3",
                Name = "Saffron Eye Brow Definer Chocolate Brown",
                Variant = "",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339902551",
                Description = "Saffron Eye Brow Definer a mechanical pencil with a unique triangular shaped tip that combines powder and wax in to create naturally defined brows." +
                            "Formula which helps you to create the look of naturally fuller, defined brows in one easy step. " +
                            "Natural looking shades to create beautiful brows. " +
                            "The double ended component has a brush to groom brows into place for that professional finish." +
                            " Net.:0.28g; 15 x 2.5 x 1.5 cm",


            }).Entity;

            Product prodEb4 = ctx.Products.Add(new Product()
            {
                Id = 30,
                SecondaryCategoryId = secClass3.Id,
                ProductCode = "4",
                Name = "Saffron Eye Brow Definer Brown",
                Variant = "",
                Price = 3.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339902551",
                Description = "Saffron Eye Brow Definer a mechanical pencil with a unique triangular shaped tip that combines powder and wax in to create naturally defined brows." +
                         "Formula which helps you to create the look of naturally fuller, defined brows in one easy step. " +
                         "Natural looking shades to create beautiful brows. " +
                         "The double ended component has a brush to groom brows into place for that professional finish." +
                         " Net.:0.28g; 15 x 2.5 x 1.5 cm",


            }).Entity;

            Product prodEb5 = ctx.Products.Add(new Product()
            {
                Id = 31,
                SecondaryCategoryId = secClass3.Id,
                ProductCode = "1012",
                Name = "Saffron Eye Brow Powder with Stencils Grey/Brown & Black Brown",
                Variant = "1",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339901660",
                Description = "Saffron Eyebrow Palette is out of this world essential compact of the perfect brows. " +
                              "It includes 2 shades of hue creating and ensuring the most natural colour that matches with " +
                              "your own, and wax to seal the colour and hold brows in place. " +
                              "The clean and perfectly defined brows are no longer a dream with the stencils provided. " +
                              "Colour: 01 Grey Brown/Black Brown, " +
                              "18 x 12.5 x 1.5 cm; Net.:8g.",

            }).Entity;

            Product prodEb6 = ctx.Products.Add(new Product()
            {
                Id = 32,
                SecondaryCategoryId = secClass3.Id,
                ProductCode = "1012",
                Name = "Saffron Eye Brow Powder with Stencils Espresso/Sepia Brown",
                Variant = "2",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 24,
                SkuCode = "5055339901660",
                Description = "Saffron Eyebrow Palette is out of this world essential compact of the perfect brows. " +
                             "It includes 2 shades of hue creating and ensuring the most natural colour that matches with " +
                             "your own, and wax to seal the colour and hold brows in place. " +
                             "The clean and perfectly defined brows are no longer a dream with the stencils provided. " +
                             "Colour: 02 Espresso/Sepia Brown, " +
                             "18 x 12.5 x 1.5 cm; Net.:8g.",

            }).Entity;



            //Lipstick

            Product productLs1 = ctx.Products.Add(new Product()
            {
                Id = 17,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "134",
                Name = "Saffron Lipstick Berry",
                Variant = "10",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                              "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                              "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                              "Colour Nos. 43 to 48 Catwalk Colours. " +
                              "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs2 = ctx.Products.Add(new Product()
            {
                Id = 18,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "134",
                Name = "Saffron Lipstick Black Coffee",
                Variant = "19",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                             "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                             "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                             "Colour Nos. 43 to 48 Catwalk Colours. " +
                             "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs3 = ctx.Products.Add(new Product()
            {
                Id = 19,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "0134",
                Name = "Saffron Lipstick Brick",
                Variant = "3",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                           "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                           "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                           "Colour Nos. 43 to 48 Catwalk Colours. " +
                           "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs4 = ctx.Products.Add(new Product()
            {
                Id = 20,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "0134",
                Name = "Saffron Lipstick Burgundy Beauty",
                Variant = "48",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                          "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                          "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                          "Colour Nos. 43 to 48 Catwalk Colours. " +
                          "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs5 = ctx.Products.Add(new Product()
            {
                Id = 21,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "0134",
                Name = "Saffron Lipstick Cabaret",
                Variant = "31",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                         "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                         "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                         "Colour Nos. 43 to 48 Catwalk Colours. " +
                         "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs6 = ctx.Products.Add(new Product()
            {
                Id = 22,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "0134",
                Name = "Saffron Lipstick Canberry",
                Variant = "9",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                        "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                        "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                        "Colour Nos. 43 to 48 Catwalk Colours. " +
                        "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs7 = ctx.Products.Add(new Product()
            {
                Id = 23,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "0134",
                Name = "Saffron Lipstick Conker",
                Variant = "43",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                        "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                        "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                        "Colour Nos. 43 to 48 Catwalk Colours. " +
                        "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs8 = ctx.Products.Add(new Product()
            {
                Id = 24,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "0134",
                Name = "Saffron Lipstick Current",
                Variant = "7",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                       "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                       "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                       "Colour Nos. 43 to 48 Catwalk Colours. " +
                       "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs9 = ctx.Products.Add(new Product()
            {
                Id = 25,
                SecondaryCategoryId = secClass1.Id,
                ProductCode = "0134",
                Name = "Saffron Lipstick Diamond Red",
                Variant = "5",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 69,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                      "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                      "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                      "Colour Nos. 43 to 48 Catwalk Colours. " +
                      "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;

            Product productLs10 = ctx.Products.Add(new Product()
            {
                Id = 26,
                SecondaryCategoryId = secClass10.Id,
                ProductCode = "0134",
                Name = "Saffron Lipstick Euphoric",
                Variant = "46",
                Price = 1.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 71,
                SkuCode = "5055339900151",
                Description = "Saffron Lipstick innovative formula that delivers bold, luscious colours." +
                    "Saffron lipstick has 30 Shades: Colour Nos. 1 to 6 Vivid Reds, Colour Nos. 7 to 12 Intense Colours." +
                    "Colour Nos. 13 to 18 Fantasy Pinks. Colour Nos. 19 to 24 Cream Chocolate and Browns." +
                    "Colour Nos. 43 to 48 Catwalk Colours. " +
                    "Sleek silver packaging with a transparent see through cap to identify the shade without having to open the case.",

            }).Entity;
            //Nails

            Product product1Np = ctx.Products.Add(new Product()
            {
                Id = 33,
                SecondaryCategoryId = secClass14.Id,
                ProductCode = "1013",
                Name = "Saffron Nail Polish Base Coat",
                Variant = "56",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339903237",
                Description = "Saffron Base Coat formula strengthens nails with a smooth, hard finish that grips nail colours.",

            }).Entity;

            Product product2Np = ctx.Products.Add(new Product()
            {
                Id = 34,
                SecondaryCategoryId = secClass14.Id,
                ProductCode = "1013",
                Name = "Saffron Nail Polish Beige French Manicure",
                Variant = "59",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339903237",
                Description = "Saffron French Manicure Polish helps you to create the classic French manicure." +
                              " Available in Pink, Beige and White simply seal with a top coat for a long lasting finish.",

            }).Entity;

            Product product3Np = ctx.Products.Add(new Product()
            {
                Id = 35,
                SecondaryCategoryId = secClass14.Id,
                ProductCode = "1013",
                Name = "Saffron Nail Polish Bikini Blue",
                Variant = "43",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339903237",
                Description = "Saffron Nail Varnish: Trend setting shades with a top quality formula long lasting, chip resistant nail lacquer.",

            }).Entity;

            Product product4Np = ctx.Products.Add(new Product()
            {
                Id = 36,
                SecondaryCategoryId = secClass14.Id,
                ProductCode = "1013",
                Name = "Saffron Nail Polish Blossom",
                Variant = "15",
                Price = 2.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 72,
                SkuCode = "5055339903237",
                Description = "Saffron Nail Varnish: Trend setting shades with a top quality formula long lasting, chip resistant nail lacquer.",

            }).Entity;

            //Face

            Product productCp1 = ctx.Products.Add(new Product()
            {
                Id = 37,
                SecondaryCategoryId = secClass16.Id,
                ProductCode = "1501",
                Name = "Saffron Compact Powder Ivory",
                Variant = "A1",
                Price = 3.49,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 46,
                SkuCode = "5055339902681",
                Description = "Saffron Pressed Powder provides stunning coverage without compromising all day comfort wear. " +
                              "Lightweight formula applies sheer and can be used as a setting powder, " +
                              "or can be layered to double up as a full coverage foundation. " +
                              "7.5 x 1.4cms; Net.: 12g",

            }).Entity;

            Product productCp2 = ctx.Products.Add(new Product()
            {
                Id = 38,
                SecondaryCategoryId = secClass16.Id,
                ProductCode = "1501",
                Name = "Saffron Compact Powder Soft Honey",
                Variant = "A2",
                Price = 3.49,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 48,
                SkuCode = "5055339902698",
                Description = "Saffron Pressed Powder provides stunning coverage without compromising all day comfort wear. " +
                            "Lightweight formula applies sheer and can be used as a setting powder, " +
                            "or can be layered to double up as a full coverage foundation. " +
                            "7.5 x 1.4cms; Net.: 12g",

            }).Entity;

            Product productCp3 = ctx.Products.Add(new Product()
            {
                Id = 39,
                SecondaryCategoryId = secClass16.Id,
                ProductCode = "1501",
                Name = "Saffron Compact Powder Fair",
                Variant = "A3",
                Price = 3.49,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 48,
                SkuCode = "5055339902704",
                Description = "Saffron Pressed Powder provides stunning coverage without compromising all day comfort wear. " +
                            "Lightweight formula applies sheer and can be used as a setting powder, " +
                            "or can be layered to double up as a full coverage foundation. " +
                            "7.5 x 1.4cms; Net.: 12g",

            }).Entity;

            Product productCp4 = ctx.Products.Add(new Product()
            {
                Id = 40,
                SecondaryCategoryId = secClass16.Id,
                ProductCode = "1501",
                Name = "Saffron Compact Powder Beige",
                Variant = "A4",
                Price = 3.49,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 48,
                SkuCode = "5055339902711",
                Description = "Saffron Pressed Powder provides stunning coverage without compromising all day comfort wear. " +
                           "Lightweight formula applies sheer and can be used as a setting powder, " +
                           "or can be layered to double up as a full coverage foundation. " +
                           "7.5 x 1.4cms; Net.: 12g",

            }).Entity;

            //Fragrance

            Product productFrg1 = ctx.Products.Add(new Product()
            {
                Id = 41,
                SecondaryCategoryId = secClass27.Id,
                ProductCode = "",
                Name = "Ameer Al Oud VIP Special Edition Unisex Eau de Parfum with Free Deo",
                Variant = "0",
                Price = 14.99,
                GenderId = gender3.Id,
                BrandId = brand8.Id,
                Availability = 20,
                SkuCode = "",
                Description = "Ameer Al Oud VIP Special Edition 100ml spray is a unique aromatic fragrance for both women and men,[unisex]. " +
                              "Brown Orchid Gold Edition fragrance is naturally clean, pure and contemporary with a refreshingly " +
                              "new point of view. The light, relaxed scent is designed to be used lavishly."+
                              "100 ml",

            }).Entity;

            Product productFrg2 = ctx.Products.Add(new Product()
            {
                Id = 42,
                SecondaryCategoryId = secClass26.Id,
                ProductCode = "",
                Name = "Azure Blue",
                Variant = "0",
                Price = 5.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 11,
                SkuCode = "35055339904432",
                Description = "Azure Blue Women's Eau de Parfum 50ml Spray. " +
                              "Each fragrance is made of layers of rich notes, unfolding to reveal a sublime and delicate experience, with the perfect blend of strength and softness." +
                              " The Perfume is blended with magical French fragrances that capture hearts. " +
                              "The fragrance will enchant and captivate you. Ideal for daily use." +
                              " The perfect gift for any occassion",

            }).Entity;

            Product productFrg3 = ctx.Products.Add(new Product()
            {
                Id = 43,
                SecondaryCategoryId = secClass27.Id,
                ProductCode = "",
                Name = "Black Kabul Eau de Parfum",
                Variant = "0",
                Price = 19.99,
                GenderId = gender3.Id,
                BrandId = brand8.Id,
                Availability = 12,
                SkuCode = "",
                Description = "Black Kabul Eau de Parfum 60ml spray is a unique aromatic fragrance for both women and men [unisex]." +
                              " Black Kabul fragrance is naturally clean, pure and contemporary with a refreshingly new point of view. " +
                              "The light, relaxed scent is designed to be used lavishly.",

            }).Entity;

            Product productFrg4 = ctx.Products.Add(new Product()
            {
                Id = 44,
                SecondaryCategoryId = secClass27.Id,
                ProductCode = "",
                Name = "Brown Orchid Gold Edition Unisex Eau de Parfum with Free Deo",
                Variant = "0",
                Price = 14.99,
                GenderId = gender3.Id,
                BrandId = brand8.Id,
                Availability = 12,
                SkuCode = "",
                Description =  "Brown Orchid Gold Edition 80ml spray is a unique aromatic fragrance for both women and men [unisex]. " +
                               "Brown Orchid Gold Edition fragrance is naturally clean, pure and contemporary with a refreshingly new point of view. " +
                               "The light, relaxed scent is designed to be used lavishly.",

            }).Entity;

            Product productFrg5 = ctx.Products.Add(new Product()
            {
                Id = 45,
                SecondaryCategoryId = secClass27.Id,
                ProductCode = "",
                Name = "Brown Orchid Oud Edition Unisex Eau de Parfum with Free Deo",
                Variant = "0",
                Price = 14.99,
                GenderId = gender3.Id,
                BrandId = brand8.Id,
                Availability = 12,
                SkuCode = "",
                Description = "Brown Orchid Oud Edition 80ml spray is a unique aromatic fragrance for both women and men [unisex]. " +
                              "Brown Orchid Oud Edition fragrance is naturally clean, pure and contemporary with a refreshingly new point of view. " +
                              "The light, relaxed scent is designed to be used lavishly.",

            }).Entity;

            Product productFrg6 = ctx.Products.Add(new Product()
            {
                Id = 46,
                SecondaryCategoryId = secClass26.Id,
                ProductCode = " A7165A",
                Name = "Bella Model Women's Eau de Parfum ",
                Variant = "0",
                Price = 9.99,
                GenderId = gender1.Id,
                BrandId = brand7.Id,
                Availability = 12,
                SkuCode = "",
                Description = "Bella Model Women's Eau de Parfum fragrance is made of layers of rich notes, " +
                              "unfolding to reveal a sublime and delicate experience, with the perfect blend of strength and softness. " +
                              "The Perfume is blended with magical French fragrances that capture hearts. The fragrance will enchant and captivate you. Ideal for daily use. " +
                              "THE PERFECT GIFT FOR ANY OCCASION",

            }).Entity;

            Product productFrg7 = ctx.Products.Add(new Product()
            {
                Id = 47,
                SecondaryCategoryId = secClass25.Id,
                ProductCode = " 4674",
                Name = "AGUA BLANCA Men's Eau de Toilette Spray",
                Variant = "0",
                Price = 7.99,
                GenderId = gender2.Id,
                BrandId = brand7.Id,
                Availability = 12,
                SkuCode = "",
                Description = "AGUA BLANCA - Men's Eau de Toilette 100ml Spray. " +
                              "The fragrance is crafted to provoke the senses with an air of depth and enigma: powerful, rich, full bodied." +
                              " It helps you stay fresh and in the limelight all day long. " +
                              "THE PERFECT GIFT.",

            }).Entity;

            Product productFrg8 = ctx.Products.Add(new Product()
            {
                Id = 48,
                SecondaryCategoryId = secClass25.Id,
                ProductCode = "A7103C",
                Name = "ART MAN Men's Eau de Toilette Spray",
                Variant = "0",
                Price = 7.99,
                GenderId = gender2.Id,
                BrandId = brand7.Id,
                Availability = 12,
                SkuCode = "",
                Description = "AGUA BLANCA - Men's Eau de Toilette 100ml Spray. " +
                             "The fragrance is crafted to provoke the senses with an air of depth and enigma: powerful, rich, full bodied." +
                             " It helps you stay fresh and in the limelight all day long. " +
                             "THE PERFECT GIFT.",

            }).Entity;

            Product productFrg9 = ctx.Products.Add(new Product()
            {
                Id = 49,
                SecondaryCategoryId = secClass25.Id,
                ProductCode = "A7157H",
                Name = "Base Camp Men's Eau de Toilette",
                Variant = "0",
                Price = 7.99,
                GenderId = gender2.Id,
                BrandId = brand7.Id,
                Availability = 11,
                SkuCode = "",
                Description = "Base Camp Men's Eau de Toilette 100ml Spray. " +
                           "The fragrance is crafted to provoke the senses with an air of depth and enigma: powerful, rich, full bodied." +
                           " It helps you stay fresh and in the limelight all day long. " +
                           "THE PERFECT GIFT.",

            }).Entity;

            Product productFrg10 = ctx.Products.Add(new Product()
            {
                Id = 50,
                SecondaryCategoryId = secClass25.Id,
                ProductCode = "A1007",
                Name = "BASE CODE Men's Eau de Toilette Spray",
                Variant = "0",
                Price = 6.99,
                GenderId = gender2.Id,
                BrandId = brand7.Id,
                Availability = 12,
                SkuCode = "",
                Description = "BASE CODE Men's Eau de Toilette 100ml Spray.  " +
                          "The fragrance is crafted to provoke the senses with an air of depth and enigma: powerful, rich, full bodied." +
                          " It helps you stay fresh and in the limelight all day long. " +
                          "THE PERFECT GIFT.",

            }).Entity;





            #endregion

            ctx.SaveChanges();

            #region Users
            string password = "1234";
            byte[] passwordHashJohn, passwordSaltJohn, passwordHashAnna, passwordSaltAnna;
            _authenticationHelper.CreatePasswordHash(password, out passwordHashJohn, out passwordSaltJohn);
            _authenticationHelper.CreatePasswordHash(password, out passwordHashAnna, out passwordSaltAnna);

            var Admin = new User()
            {
                Email = "Admin",
                PasswordHash = passwordHashJohn,
                PasswordSalt = passwordSaltJohn,
                IsAdmin = true,
                FirstName = "Adam",
                LastName = "Admin",
                Address = "4469 Reeves Street",
                PostCode = "54913",
                PhoneNumber = "12345678"
            };
            _userRepo.CreateUser(Admin);

            var User = new User()
            {
                Email = "User",
                PasswordHash = passwordHashAnna,
                PasswordSalt = passwordSaltAnna,
                IsAdmin = false,
                FirstName = "Urusla",
                LastName = "User",
                Address = "1823 Patton Lane",
                PostCode = "92697",
                PhoneNumber = "87654321"
            };
            _userRepo.CreateUser(User);
            #endregion

            ctx.SaveChanges();

        }
    }
}
