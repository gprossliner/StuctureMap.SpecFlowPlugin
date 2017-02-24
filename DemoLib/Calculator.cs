using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib {

    public class Calculator {

        private ILogger Logger { get; }

        private Stack<int> Stack { get; } = new Stack<int>();

        public int CurrentValue { get; private set; }

        public Calculator(ILogger logger) {
            if (logger == null) throw new ArgumentNullException(nameof(logger));

            this.Logger = logger;
        }

        public void EnterNumber(int nr) {
            this.Logger.LogInfo($"Calculator: Push {nr}");
            this.Stack.Push(nr);
        }

        public int Add() {
            var b = this.Stack.Pop();
            var a = this.Stack.Pop();

            var res = a + b;

            this.CurrentValue = res;

            this.Logger.LogInfo($"Calculator: {a}+{b}={res}");
            return res;
        }

    }
}
