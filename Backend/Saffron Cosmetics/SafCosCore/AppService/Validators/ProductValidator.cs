using FluentValidation;
using SafCos.Core.AppService.ValidatorInterface;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SafCos.Core.AppService.Validators
{
    public class ProductValidator : IProductValidator //AbstractValidator<Product>
    {
        //public ProductValidator()
        //{
        //    RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
        //    RuleFor(p => p.Id).NotNull();
        //    RuleFor(p => p.ProductCode).NotNull().WithMessage("Product code cannot be empty");
        //    RuleFor(p => p.SecondaryCategoryId).NotEmpty().WithMessage("check relationship with primary category");
        //    RuleFor(p => p.BrandId).NotNull().WithMessage("Invalid Brand");
        //    RuleFor(p => p.Description).NotEmpty().WithMessage("Describe a product");
        //    RuleFor(p => p.Price).NotNull().WithMessage("enter a valid amount");
        //    RuleFor(p => p.SkuCode).NotNull().WithMessage("sku code is the barcode");
        //    RuleFor(p => p.Availability).NotEmpty().WithErrorCode("not in stock");
        //}
        
        public void DefaultValidation(Product product)
        {
            if (product.Id < 0 || product.Name == null)
                throw new ArgumentNullException("Invalid Id or Name");
            if(product.ProductCode == null)         
                throw new ArgumentNullException("product code cannot be null");
            if (product.Price <= 0)
                throw new ArgumentOutOfRangeException("price cannot be 0 or in negative");
            if (product.SkuCode == null)
                throw new Exception("skuCode cannot be empty");
            if (product.Description == string.Empty)
                throw new MissingFieldException("please describe the product");
            if (product.Availability <= 5)
                throw new NullReferenceException("product is unavailable");
            if (product.ProductCode == null)
                throw new NullReferenceException("invalid product code");
            if (product.BrandId <= 0)
                throw new NullReferenceException("check product brand , relationship key");
            if (product.SecondaryCategoryId <= 0)
                throw new NullReferenceException("check relationship key, SecCateg/PriCateg cannot be null");
          
        }

        public void DeleteProduct(int id)
        {
            if (id <= 0)
                throw new NullReferenceException("need a valid ID to delete product"); 
        }

        public void UpdateProduct(Product prodToUpdate)
        {
            if (prodToUpdate.Id < 0 || prodToUpdate.Name == null)
                throw new ArgumentNullException("Invalid Id or Name");
            if (prodToUpdate.ProductCode == null)
                throw new ArgumentNullException("product code cannot be null");
            if (prodToUpdate.Price <= 0)
                throw new ArgumentOutOfRangeException("price cannot be 0 or in negative");
            if (prodToUpdate.SkuCode == null)
                throw new Exception("skuCode cannot be empty");
            if (prodToUpdate.Description == string.Empty)
                throw new MissingFieldException("please describe the product");
            if (prodToUpdate.Availability <= 5)
                throw new NullReferenceException("product is unavailable");
            if (prodToUpdate.ProductCode == null)
                throw new NullReferenceException("invalid product code");
            if (prodToUpdate.BrandId <= 0)
                throw new NullReferenceException("check product brand , relationship key");
            if (prodToUpdate.SecondaryCategoryId <= 0)
                throw new NullReferenceException("check relationship key, SecCateg/PriCateg cannot be null");
        }
    }
}
