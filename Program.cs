using System;

namespace cSharpCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator(10, 30);
            MadLibs("red", "violets", "Tom Hanks");
        }

        static void BasicCalculator(double num1, double num2)
        {
            Console.WriteLine("Addition of entered numbers is: " + (num1 + num2));
        }

        static void MadLibs(string color, string pluralNoun, string celebrity)
        {
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
        }
    }
}
