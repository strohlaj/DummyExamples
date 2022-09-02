using System;
using System.Collections.Generic;
using System.Linq;

namespace example
{
    class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                // Play around with any of these solutions!
                // There are a lot of ways to skin this kitty and these are just 3 options of many.

                // PatternMatchingAnswer();
                // TraditionalSwitchAnswer();
                // IfStatementAnswer();
            }
        }
        static void PatternMatchingAnswer()
        {
            Console.WriteLine(Console.ReadLine().ToLower() switch
            {
                "y" or "yes" or "ya" => "You answered yes!",
                "n" or "no" or "nah" => "You answered no!",
                _ => "Invalid response!",
            });
        }

        static void TraditionalSwitchAnswer()
        {
            var userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "y":
                case "yes":
                case "ya":
                    Console.WriteLine("You answered yes!");
                    break;
                case "n":
                case "no":
                case "nah":
                    Console.WriteLine("You answered no!");
                    break;
                default:
                    Console.WriteLine("Invalid response!");
                    break;
            }
        }


        static List<string> YesAnswers = new() { "y", "yes", "ya" };
        static List<string> NoAnswers = new() { "n", "no", "nah" };
        static void IfStatementAnswer()
        {
            var userResponse = Console.ReadLine().ToLower();
            if (YesAnswers.Contains(userResponse))
            {
                Console.WriteLine("You answered yes!");
            }
            else if (NoAnswers.Contains(userResponse))
            {
                Console.WriteLine("You answered no!");
            }
            else
            {
                Console.WriteLine("Invalid response!");
            }
        }
    }
}
