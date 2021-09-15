using System;

namespace cSharpCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator(10, 30, "addition");
            BasicCalculator(10, 30, "subtraction");
            BasicCalculator(10, 30, "multiplication");
            BasicCalculator(10, 30, "division");
            MadLibs("red", "violets", "Tom Hanks");
        }

        static void BasicCalculator(double num1, double num2, string operation)
        {
            Console.WriteLine("\n========Starting execution of method BasicCalculator() for operation " + operation +" =========");
            switch (operation)
            {
                case "addition":
                    Console.WriteLine("Addition of entered numbers is: " + (num1 + num2));
                    break;

                case "subtraction":
                    if (num1 > num2)
                    {
                        Console.WriteLine("Subtraction of entered numbers is: " + (num1 - num2));
                    } else
                    {
                        Console.WriteLine("Subtraction of entered numbers is " + (num2 - num1));
                    }
                    break;

                case "multiplication":
                    Console.WriteLine("Multiplication of entered numbers: " + (num1 * num2));
                    break;

                case "division":
                    if (num2 != 0)
                    {
                        Console.WriteLine("Division of num1 by num2 is: " + (num1 / num2));
                    }
                    if (num1 != 0)
                    {
                        Console.WriteLine("Division of num2 by num1 is: " + (num2 / num1));
                    }
                    break;
            }
        }

        static void MadLibs(string color, string pluralNoun, string celebrity)
        {
            Console.WriteLine("\n========Starting execution of method MadLibs()=========");
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
        }
    }
}
