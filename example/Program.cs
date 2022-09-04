using System;
using System.Collections.Generic;

namespace example
{
    class Program
    {
        public class PlayerInput 
        {
            public string Verb { get; set; }

            public string Noun { get; set; }
            //public PlayerInput(string input)
            //{
            //    // add validation logic
            //    var splitInput = input.Split(" ");
            //    Verb = splitInput[0];
            //    Noun = splitInput[^1];
            //}
            public PlayerInput(string verb, string noun)
            {
                Verb = verb;
                Noun = noun;
            }
        }

        static void Main(string[] args)
        {
            List<PlayerInput> playerInputs = new();

            while (true)
            {
                // [something1] [something2]
                var stringInputs = Console.ReadLine().Split(" ");
                if (stringInputs.Length < 2)
                {
                    Console.Write("no beuno");
                }
                else
                {
                    playerInputs.Add(new PlayerInput(stringInputs[0], stringInputs[^1]));
                }

                // Play around with any of these solutions!
                // There are a lot of ways to skin this kitty and these are just 3 options of many.

                // PatternMatchingAnswer();
                // TraditionalSwitchAnswer();
                // IfStatementAnswer();
                // StaticClass.GetName(); // 'aaron'
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
