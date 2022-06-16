using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public class OpenNotAvailableProductSteps
    {
        [Given(@"I have opened product what is (.*) in store")]
        public void GivenIHaveOpenedProductWhatIsInStore(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press confirm")]
        public void WhenIPressConfirm()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
