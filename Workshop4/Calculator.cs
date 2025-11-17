using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    internal class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        public int Add(int num1, int num2)
        {
            int addition = num1 + num2;
            return addition;
        }
        public int Multiply(int num1, int num2 = 1)
        {
            int multiplication = num1 * num2;
            return multiplication;
        }
    }
}

