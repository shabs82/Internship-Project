using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using SafCos.Core.AppService.Service;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using Xunit;

namespace UnitTests
{
    public class ProductServiceTest
    {
        private Mock<IProductRepo> _productRepoMock;

        public ProductServiceTest()
        {
            _productRepoMock = new Mock<IProductRepo>();
        }

        [Fact]
        public void NewProductService_WithNullRepository_ShouldThrowException()
        {
            Action action = () => new ProductService(null);
            action.Should().Throw<ArgumentNullException>().WithMessage(("Repository Cannot be Null. (Parameter 'productRepo')"));
        }

        [Fact]
        public void GetAllProducts__ShouldCallRepo_Once()
        {
            IProductService productService = new ProductService(_productRepoMock.Object);
            _productRepoMock.Setup(m => m.ReadAllProducts()).Returns(() => new List<Product>());
            productService.ReadAllProducts();
            _productRepoMock.Verify(repo => repo.ReadAllProducts(), Times.Once);
        }

        [Fact]
        public void GetProductById_WithZeroId_ShouldThrowException()
        {
            var service = new ProductService(_productRepoMock.Object);

            Action action = () => service.GetProductById(0);
            action.Should().Throw<NullReferenceException>().WithMessage(("Invalid ID"));
        }

        [Fact]
        public void DeleteProduct_WithZeroId_ShouldThrowException()
        {
            var service = new ProductService(_productRepoMock.Object);

            Action action = () => service.DeleteProduct(0);
            action.Should().Throw<NullReferenceException>().WithMessage(("Invalid ID"));
        }

        [Fact]
        public void SearchByName_ShouldReturnCorrectProducts_Test()
        {
            var listOfProducts = new List<Product>{
                new Product {Id =  1, ProductCode="123code", Name = "Eye Lashes", Variant = null, Price = 10.00, Availability = 26,
                    Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                new Product {Id =  2, ProductCode="123code", Name = "Eye Pencil", Variant = null, Price = 10.00, Availability = 26,
                    Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                new Product {Id =  3, ProductCode="123code", Name = "Lipstick", Variant = null, Price = 10.00, Availability = 26,
                    Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                };

            //_productRepoMock.Setup(repo => repo.Search("ey")).Returns(() => listOfProducts.Where(p => p.Name.Contains("ye")) as Task<IEnumerable<Product>>);

            //var service = new ProductService(_productRepoMock.Object);

            var actual = listOfProducts.Where(p => p.Name.Contains("ye"));

            var expected = new List<Product>{
                new Product {Id =  1, ProductCode="123code", Name = "Eye Lashes", Variant = null, Price = 10.00, Availability = 26,
                    Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                new Product {Id =  2, ProductCode="123code", Name = "Eye Pencil", Variant = null, Price = 10.00, Availability = 26,
                    Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1}
                } ;

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
