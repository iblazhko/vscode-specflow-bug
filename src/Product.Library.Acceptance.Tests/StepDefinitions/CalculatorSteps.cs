using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Product.Library.Acceptance.Tests.StepDefinitions
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator calculator = new Calculator();
        private readonly Stack<decimal> numbers = new Stack<decimal>();
        private decimal sum;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(decimal x)
        {
            numbers.Push(x);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            sum = 0;
            if (numbers.Count > 0)
            {
                sum = numbers.Pop();
            }

            while (numbers.Count > 0)
            {
                sum = calculator.Add(sum, numbers.Pop());
            }
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(decimal expectedSum)
        {
            sum.Should().Be(expectedSum);
        }

    }
}
