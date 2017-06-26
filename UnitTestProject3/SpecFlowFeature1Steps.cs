using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject3
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private Calculator myCalculator = new Calculator();
        int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
          myCalculator.addNumber(number);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = myCalculator.add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
                Assert.AreEqual(120, result);


        }
    }
}
