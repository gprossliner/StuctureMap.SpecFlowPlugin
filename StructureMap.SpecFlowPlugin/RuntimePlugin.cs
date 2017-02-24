using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Plugins;

[assembly: RuntimePlugin(typeof(StructureMap.SpecFlowPlugin.RuntimePlugin))]


namespace StructureMap.SpecFlowPlugin
{
    public class RuntimePlugin : IRuntimePlugin {

        void IRuntimePlugin.Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters) {
            runtimePluginEvents.CustomizeScenarioDependencies += CustomizeScenarioDependencies;
        }

        void CustomizeScenarioDependencies(object sender, CustomizeScenarioDependenciesEventArgs e) {

            var container = new Container();
            e.ObjectContainer.RegisterInstanceAs<IContainer>(container);
        }
    }
}
