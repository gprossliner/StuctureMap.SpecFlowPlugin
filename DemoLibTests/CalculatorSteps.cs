using DemoLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DemoLibTests {
    [Binding]
    public sealed class CalculatorSteps {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        Calculator Calculator { get; }

        public CalculatorSteps(IContainer container) {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            this.Calculator = container.GetInstance<Calculator>();
        }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number) {
            this.Calculator.EnterNumber(number);
        }

        [When("I press add")]
        public void WhenIPressAdd() {
            this.Calculator.Add();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int expectedResult) {
            var calculatedResult = this.Calculator.CurrentValue;
            Assert.AreEqual(expectedResult, calculatedResult);
        }
    }
}
