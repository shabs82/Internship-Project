using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using SafCos.Core.AppService.Service;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.AppService.ValidatorInterface;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using Xunit;

namespace SaffronCosmetics.UnitTests.ProductServiceTest
{
    public class ProductServiceTest
    {
        private Mock<IProductRepo> _productRepoMock;
        private Mock<IProductValidator> _productValidatorMock;

        public ProductServiceTest()
        {
            _productRepoMock = new Mock<IProductRepo>();
            _productValidatorMock = new Mock<IProductValidator>();
        }

        [Fact]
        public void NewProductService_WithNullRepository_ShouldThrowException()
        {
            Action action = () => new ProductService(null,_productValidatorMock.Object);
            action.Should().Throw<NullReferenceException>().WithMessage(("Repo cannot be null"));
        }

        [Fact]
        public void GetAllProducts__ShouldCallRepo_Once()
        {
            IProductService productService = new ProductService(_productRepoMock.Object,_productValidatorMock.Object);
            _productRepoMock.Setup(m => m.ReadAllProducts()).Returns(() => new List<Product>());
            productService.ReadAllProducts();
            _productRepoMock.Verify(repo => repo.ReadAllProducts(), Times.Once);
        }

        [Fact]
        public void GetProductById_WithZeroId_ShouldThrowException()
        {

            IProductService service = new ProductService(_productRepoMock.Object, _productValidatorMock.Object);

            Action action = () => service.GetProductById(0);
            action.Should().Throw<NullReferenceException>().WithMessage(("Invalid ID"));
        }

        [Fact]

        public void GetProductById_WithStockLessThan5_ShouldThrowException_Once()
        {
            IProductService service = new ProductService(_productRepoMock.Object, _productValidatorMock.Object);
            Product product = new Product()
            {
                Availability = 7
                
            };
            _productRepoMock.Setup(r => r.GetProductById(2)).Returns(product);
            service.GetProductById(2);
            _productRepoMock.Verify(r => r.GetProductById(2), Times.Once);
        }

        [Fact]

        public void GetProductById_WithStockLessThan2_ShouldThrowException_Once()
        {
            IProductService service = new ProductService(_productRepoMock.Object, _productValidatorMock.Object);
            Product prod = new Product()
            { 
                Availability = 1
            };
            _productRepoMock.Setup(r => r.GetProductById(3)).Returns(prod);
            service.GetProductById(3);
            _productRepoMock.Verify(r => r.GetProductById(3), Times.Once());
        }

        [Fact]
        public void DeleteProduct_WithZeroId_ShouldThrowException()
        {
            var service = new ProductService(_productRepoMock.Object, _productValidatorMock.Object);

            Action action = () => service.DeleteProduct(0);
            action.Should().Throw<NullReferenceException>().WithMessage(("Invalid ID"));
        }

        [Fact]
        public void GetProductById_WhereAvailabilityIsBetweenOneAndFive_SetAvailabilityToMinusOne()
        {
            var listOfProducts = new List<Product>{
                    new Product {Id =  1, ProductCode="123cod1e", Name = "Eye Lashes", Variant = null, Price = 10.00, Availability = 2,
                        Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                    new Product {Id =  2, ProductCode="123code", Name = "Eye Pencil", Variant = null, Price = 10.00, Availability = 26,
                        Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                    new Product {Id =  3, ProductCode="123code", Name = "Lipstick", Variant = null, Price = 10.00, Availability = 26,
                        Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 2},
                    };

            _productRepoMock.Setup(repo => repo.GetProductById(1)).Returns(() => listOfProducts[0]);

            var service = new ProductService(_productRepoMock.Object, _productValidatorMock.Object);

            int actualAvailability = service.GetProductById(1).Availability;

            int expectedAvailability = -1;

            Assert.Equal(expectedAvailability, actualAvailability);
        }
    }
}
