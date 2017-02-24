using DemoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibTests {
    class TestLogger : ILogger {

        private List<string> Messages { get; } = new List<string>();

        public void LogInfo(string msg) {
            this.Messages.Add(msg);
        }
    }
}
