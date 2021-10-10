using FluentValidation;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SafCos.Core.AppService.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.Id).NotNull();
            RuleFor(p => p.ProductCode).NotNull().WithMessage("Product code cannot be empty");
            RuleFor(p => p.SecondaryCategoryId).NotEmpty().WithMessage("check relationship with primary category");
            RuleFor(p => p.BrandId).NotNull().WithMessage("Invalid Brand");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Describe a product");
            RuleFor(p => p.Price).NotNull();
            RuleFor(p => p.SkuCode).NotNull().WithMessage("sku code is the barcode");
            RuleFor(p => p.Availability).NotEmpty().WithErrorCode("not found");
        }


    }
}
