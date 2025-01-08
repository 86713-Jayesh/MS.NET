using System;

namespace calculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("useage Calculator <number1> <operation> <number2>");
                return;
            }

            double num1 = Convert.ToDouble(args[0]);
            string operation = args[1];
            double num2 = Convert.ToDouble(args[2]);
            double result = 0;

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
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error Division By Zero");
                    break;
                default:
                    Console.WriteLine("Invalid Operations");
                    return;

            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
