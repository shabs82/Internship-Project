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
                Name = "Eyes"
            }).Entity;

            PrimaryClassifier primClass6 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "Makeup/Accessories"
            }).Entity;

            PrimaryClassifier primClass7 = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "GiftSets"
            }).Entity;


            //Create secondary classifier

            SecondaryClassifier secClass1 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Eye Pencil",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            SecondaryClassifier secClass2 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Mascara",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            SecondaryClassifier secClass3 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Eyebrows",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            SecondaryClassifier secClass4 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Eyelenses",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            SecondaryClassifier secClass5 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Eyeliner",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            SecondaryClassifier secClass6 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Eyeshadow",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            SecondaryClassifier secClass7 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Kajal&Eyelash",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            SecondaryClassifier secClass8 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Eyelashes",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            SecondaryClassifier secClass9 = ctx.SecondaryClassifiers.Add(new SecondaryClassifier()
            {
                Name = "Eyepencil",
                PrimaryClassifierId = "primClass5"

            }).Entity;

            //create Brand

            //Create Gender

            //Create Product


        }
    }
}
