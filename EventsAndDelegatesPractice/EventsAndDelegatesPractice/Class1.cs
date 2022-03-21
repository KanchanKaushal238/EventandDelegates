using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesPractice
{
    internal class Class1
    {
       // static int Square(int input) => input * input;

        static void Main(string[] args)
        {
            var calculator = new Calculator();

            var response = calculator.Execute((x) => x * x, Console.WriteLine, 5);
            calculator.Calculate += Calculator_Calculate;
            calculator.RaiseEvent("Kanchan");
            //Console.WriteLine("Result: "+response);
        }
        public static void Calculator_Calculate(object arg1, CalculatorEventArgs arg2)
        {
            Console.WriteLine(arg2.Name);
        }
    }
}
