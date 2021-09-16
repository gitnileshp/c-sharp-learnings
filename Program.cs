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
            Console.WriteLine(guessingGame());
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

        static string guessingGame()
        {
            Console.WriteLine("\n========Starting execution of method guessingGame()=========");
            string result = "";
            int guessCount = 1;
            int secretNum = new Random().Next(1, 20);
            Console.Write("Welcome to Guessing Game, Please enter your name to continue: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! I am guessing a number between 1 to 20 and You have 5 attempts to guess the same. Let's start! Please enter your first guess: ");
            int guessedNum = Convert.ToInt32(Console.ReadLine());
            while (guessCount < 5 && guessedNum != secretNum)
            {
                if (guessedNum < secretNum)
                {
                    Console.Write("Oh No !! That was an incorrect guess!! Hint: Your guess was lower than secret number, Let's try next guess: ");
                } else if (guessedNum > secretNum)
                {
                    Console.Write("Oh No !! That was an incorrect guess!! Hint: Your guess was higher than secret number, Let's try next guess: ");
                } else if (guessedNum == secretNum)
                {
                    break;
                }
                guessedNum = Convert.ToInt32(Console.ReadLine());
                guessCount++;
            }
            if (guessCount > 5)
            {
                result = "Sorry, you lost!! you have exhausted you number of tries!!";
            } else if (guessedNum == secretNum)
            {
                result = "Congratulations, you have guessed the secret number in " + guessCount + " tries.";
            }
            return result;
        }
    }
}
