using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using SafCos.Core.AppService.Service;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using Xunit;

namespace UnitTests
{
    public class SecondaryCategoryServiceTest
    {
        private Mock<ISecondaryCategoryRepo> _secCatRepoMock;

        public SecondaryCategoryServiceTest()
        {
            _secCatRepoMock = new Mock<ISecondaryCategoryRepo>();
        }

        [Fact]
        public void SecondayCategoryService_WithNullRepository_ShouldThrowException()
        {
            Action action = () => new SecondaryCategoryService(null);
            action.Should().Throw<NullReferenceException>().WithMessage(("Repository Cannot be Null"));
        }

        [Fact]
        public void GetProductsBySecondaryCategoryId_ShouldReturnCorrectProducts()
        {
            var listOfProducts = new List<Product>{
                    new Product {Id =  1, ProductCode="123cod1e", Name = "Eye Lashes", Variant = null, Price = 10.00, Availability = 26,
                        Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                    new Product {Id =  2, ProductCode="123code", Name = "Eye Pencil", Variant = null, Price = 10.00, Availability = 26,
                        Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                    new Product {Id =  3, ProductCode="123code", Name = "Lipstick", Variant = null, Price = 10.00, Availability = 26,
                        Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 2},
                    };

            _secCatRepoMock.Setup(repo => repo.GetProductsBySecondaryCategoryId(1)).Returns(() => listOfProducts.Where(p => p.SecondaryCategoryId == 1 ));

            var service = new SecondaryCategoryService(_secCatRepoMock.Object);

            var actual = service.GetProductsBySecondaryCategoryId(1);

            var expected = new List<Product>{
                    new Product {Id =  1, ProductCode="123cod1e", Name = "Eye Lashes", Variant = null, Price = 10.00, Availability = 26,
                        Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1},
                    new Product {Id =  2, ProductCode="123code", Name = "Eye Pencil", Variant = null, Price = 10.00, Availability = 26,
                        Description = "Good Product", SkuCode = "123sh12", SecondaryCategoryId = 1}
                    };

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
