using DemoLib;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DemoLibTests {

    [Binding]
    public sealed class TestLoggerBinding {

        private TestLogger Logger { get; }

        public TestLoggerBinding(IContainer container) {
            this.Logger = (TestLogger)container.GetInstance<ILogger>();
        }

        [Then(@"the line '(.*)' should have been logged as info")]
        public void ThenTheLineShouldHaveBeenLoggedAsInfo(string expectedMessage) {
            this.Logger.AssertMessage(expectedMessage);
        }

    }
}
