using DemoLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibTests {
    class TestLogger : ILogger {

        private Queue<string> Messages { get; } = new Queue<string>();

        public void LogInfo(string msg) {
            this.Messages.Enqueue(msg);
        }

        public void AssertMessage(string expectedMessage) {
            Assert.IsTrue(this.Messages.Count > 0);

            var message = this.Messages.Dequeue();
            Assert.AreEqual(expectedMessage, message);
        }
    }
}
