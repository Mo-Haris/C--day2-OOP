using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class and create a new object.
            Calculator calc = new Calculator();
            int x = 6;
            int y = 2;
            int sum = 0;
            int subtract = 0;
            int multiply = 0;
            int div = 0;

            sum = calc.Add(6, 2);
            Console.WriteLine("sum of {0} + {1} = {2}", x, y, sum);

            subtract = calc.Subtract(6, 2);
            Console.WriteLine("subtraction of {0} - {1} = {2}", x, y, subtract);

            multiply = calc.Multiply(6, 2);
            Console.WriteLine("multiplication of {0} X {1} = {2}", x, y, multiply);

            div = calc.Divide(6, 2); //gives the whole number, not the remainder
            Console.WriteLine("division of {0} / {1} = {2}", x, y, div);

            Console.ReadLine();
        }
    }
}
