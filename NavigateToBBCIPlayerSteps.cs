using System;
using TechTalk.SpecFlow;

namespace BBCProject
{
    [Binding]
    public class NavigateToBBCIPlayerSteps
    {
        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on BBC iPlayer")]
        public void WhenIClickOnBBCIPlayer()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the page loads")]
        public void ThenISeeThePageLoads()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
