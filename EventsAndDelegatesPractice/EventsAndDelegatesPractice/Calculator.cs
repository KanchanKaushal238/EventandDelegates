using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesPractice
{
    internal class Calculator
    {

        public event Action<object, CalculatorEventArgs> Calculate;

        public void RaiseEvent(string name)
        {
            Calculate?.Invoke(this, new CalculatorEventArgs { Name = name });
        }
        //public delegate int Calculate(int input);
        public int Execute(Func<int, int> calculate, Action<int> print, int input)
        {
            var result = calculate(input);
            print(result);
            return result;
        }
    }
}
// event is associated with a delegate
// when event is raised the delegate is called back
// best practice:
// the first one is object representing the instance that raised the event
// the second one is a type representing event arguments