using DemoLib;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoLibTests {

    [Binding]
    class ContainerConfigurationBinding {

        private IContainer Container { get; }

        public ContainerConfigurationBinding(IContainer container) {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            this.Container = container;
        }

        [Given(@"I use the default container configuration")]
        public void GivenIUseTheDefaultContainerConfiguration() {
            this.Container.Configure(c => {
                c.For<ILogger>().Use<TestLogger>().Singleton();
            });
        }



    }
}
