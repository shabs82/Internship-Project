using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.Entities;
using TechTalk.SpecFlow;

namespace SpecFlowProjects.Steps
{
    [Binding]
    public class OpenNotAvailableProductSteps
    {
        Product product;
        Action act;

        private readonly ScenarioContext _scenarioContext;
        private readonly IProductService _productService;

        public OpenNotAvailableProductSteps(ScenarioContext scenarioContext, IProductService productService)
        {
            _scenarioContext = scenarioContext;
            _productService = productService;
        }

        [Given(@"I have opened product what is (.*) in store")]
        public void GivenIHaveOpenedProductWhatIsInStore(string prod)
        {
            product = new Product
            {
                Id = 1,
                ProductCode = "test",
                Name = "test",
                Variant = null,
                Price = 10.00,
                Availability = 0,
                Description = "test",
                SkuCode = "test",
                SecondaryCategoryId = 1
            };
        }
        
        [When(@"I press confirm")]
        public void WhenIPressConfirm()
        {
            act = () => _productService.GetProductById(1);
            //var prod = _productService.GetProductById(1);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string nothin)
        {
            Assert.That(() => act, Throws.TypeOf<IndexOutOfRangeException>());
        }

    }
}
