using System;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.Entities;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowProj.Steps
{
    [Binding]
    public class OpenProductWhatIsLessThanFiveAvailableSteps
    {
        Product product;
        int availability;

        private readonly ScenarioContext _scenarioContext;
        private readonly IProductService _productService;

        public OpenProductWhatIsLessThanFiveAvailableSteps(ScenarioContext scenarioContext, IProductService productService)
        {
            _scenarioContext = scenarioContext;
            _productService = productService;
        }

        [Given(@"I clicked on prodect whats is less tha five available")]
        public void GivenIClickedOnProdectWhatsIsLessThaFiveAvailable()
        {

        }
        
        [When(@"I click on product")]
        public void WhenIClickOnProduct()
        {
            product = _productService.GetProductById(2);
            availability = product.Availability;
        }
        
        [Then(@"the result should set to product availability (.*)")]
        public void ThenTheResultShouldSetToProductAvailability(int expectedAvailability)
        {
            Assert.Equal(expectedAvailability, availability);
        }
    }
}
