using System;
using TechTalk.SpecFlow;

namespace Next.Step
{
    [Binding]
    public class NextClothingSteps
    {
        [Given(@"I Navigate to Next")]
        public void GivenINavigateToNext()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on women")]
        public void WhenIClickOnWomen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Dresses")]
        public void WhenIClickOnDresses()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see clothing")]
        public void ThenISeeClothing()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the Dreeses page")]
        public void ThenISeeTheDreesesPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
