using NUnit.Framework;
using TechTalk.SpecFlow;
using Testing.Example;

namespace BDD.Specflow.Tests.StepDefinitions
{
    [Binding]
    [Scope(Feature = "Sum Numbers")]
    public sealed class CalculatorStepDefinitions
    {
        private int firstNum = 0;
        private int secondNum = 0;
        private int result = 0;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number) {
            firstNum = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number) {
            secondNum = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded() {
            var calculator = new Calculator();
            result = calculator.SumNumbers(firstNum, secondNum);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result) {
            Assert.AreEqual(result, result);
        }
    }
}