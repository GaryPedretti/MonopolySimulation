using System;
using TechTalk.SpecFlow;

namespace MonopolySimulation.Specs.StepDefinitions
{
    [Binding]
    public class AnotherFeatureStepDefinitions
    {
        [Given(@"i am Gary")]
        public void GivenIAmGary()
        {
            throw new PendingStepException();
        }

        [When(@"i present my fingerprint")]
        public void WhenIPresentMyFingerprint()
        {
            throw new PendingStepException();
        }

        [Then(@"i am authenticated and allowed into the system")]
        public void ThenIAmAuthenticatedAndAllowedIntoTheSystem()
        {
            throw new PendingStepException();
        }
    }
}
