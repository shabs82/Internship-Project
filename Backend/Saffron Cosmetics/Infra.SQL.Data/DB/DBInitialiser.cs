using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;


namespace Infra.SQL.Data.DB
{
    public class DBInitialiser : IDBInitialiser
    {
        public void SeedDB(SafCosmeticsContext ctx)
        {


     // Create Primary classifier
            
           PrimaryClassifier primClass1 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "Eyes"
            }).Entity;

            PrimaryClassifier primClass2 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "Lips"
            }).Entity;

            PrimaryClassifier primClass3 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "Nails"
            }).Entity;

            PrimaryClassifier primClass4 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "Face"
            }).Entity;

           
            PrimaryClassifier primClass5 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "Makeup/Accessories"
            }).Entity;

            PrimaryClassifier primClass6 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "GiftSets"
            }).Entity;

            PrimaryClassifier primClass7 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "Fragrance"
            }).Entity;


            //Create secondary classifier

            SecondaryClassifier secClass1 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "EyePencil",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass2 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Mascara",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass3 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Eyebrows",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass4 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "EyeLenses",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass5 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "EyeLiner",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass6 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "EyeShadow",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass7 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Kajal & EyeShade",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass8 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "EyeLashes",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass9 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "EyePencil",
                PrimaryClassifierId = "1"

            }).Entity;

            SecondaryClassifier secClass10 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "LipStick",
                PrimaryClassifierId = "2"

            }).Entity;//loads of variant , needs filter

            SecondaryClassifier secClass11 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "LipGloss",
                PrimaryClassifierId = "2"

            }).Entity;

            SecondaryClassifier secClass12 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "LipLiner",
                PrimaryClassifierId = "2"

            }).Entity;

            SecondaryClassifier secClass13 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "LipPencil",
                PrimaryClassifierId = "2"

            }).Entity;

            SecondaryClassifier secClass14 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "NailPolish",
                PrimaryClassifierId = "3"

            }).Entity; // loads of polishes , will need filter

            SecondaryClassifier secClass15 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "NailAccessories",
                PrimaryClassifierId = "3"

            }).Entity;

            SecondaryClassifier secClass16 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "CompactPowder",
                PrimaryClassifierId = "4"

            }).Entity;

            SecondaryClassifier secClass17 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Foundation",
                PrimaryClassifierId = "4"

            }).Entity;

            SecondaryClassifier secClass18 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Blushes",
                PrimaryClassifierId = "4"

            }).Entity;

            SecondaryClassifier secClass19 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Concealer",
                PrimaryClassifierId = "4"

            }).Entity; // contour and pencil needs filtering.

            SecondaryClassifier secClass20 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Primer",
                PrimaryClassifierId = "4"

            }).Entity;

            SecondaryClassifier secClass21 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Highlighters / Bronzing",
                PrimaryClassifierId = "4"

            }).Entity;

            SecondaryClassifier secClass22 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Applicators",
                PrimaryClassifierId = "5"

            }).Entity;

            SecondaryClassifier secClass23 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Brushes",
                PrimaryClassifierId = "5"

            }).Entity;

            SecondaryClassifier secClass24 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "VanityCase",
                PrimaryClassifierId = "5"

            }).Entity;

            SecondaryClassifier secClass25 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "",
                PrimaryClassifierId = "6"

            }).Entity;




            //create Brand

            Brand brand1 = ctx.Brands.Add(new Brand()
            {


            }).Entity;

            //Create Gender

            //Create Product


        }
    }
}
