using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib {

    /// <summary>
    /// This is a demo interface, which is injected by StructureMap to a specific implementation for Test.
    /// </summary>
    public interface ILogger {
        void LogInfo(string msg);
    }
}