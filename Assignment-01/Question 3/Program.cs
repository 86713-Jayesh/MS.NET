using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDrivenCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalc = true;
            do
            {
                Console.WriteLine("Enter The First Number");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter The Operations (+ _ / * )");
                string operation = Console.ReadLine();

                Console.WriteLine("Enter The Secound Number");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid Operations");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                    Console.WriteLine($"Result:{result}");
            }
            while (continueCalc);
        }
    }
}
