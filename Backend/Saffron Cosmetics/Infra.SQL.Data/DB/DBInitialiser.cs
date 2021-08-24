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

            PrimaryClassifier primClass = ctx.PrimaryClassifiers.Add(new PrimaryClassifier()
            {
                Name = "GiftSets"
            }).Entity;


            //Create secondary classifier



            //create Brand

            //Create Gender

            //Create Product

            
        }
    }
}
