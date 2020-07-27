using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to SimpleInfoGrabber.");
            Console.WriteLine("What's your name?");

            var name = TryAnswer();

            Console.WriteLine("How old are you?");

            var age = TryAnswer();
          
            Console.WriteLine("What month were you born in?");

            var month = TryAnswer();
           
            Console.WriteLine("Hello, {0}! You stated you are {1} years old and were born in the month of {2}.", name, age, month);

            if (month == "march")
            {
                Console.WriteLine("You are an aries...");
            }
            else if (month == "april")
            {
                Console.WriteLine("You are a taurus...");
            }
            else if (month == "may")
            {
                Console.WriteLine("You are a gemini...");
            }
        }

        static string TryAnswer()
        {
            var Answer = Console.ReadLine();
            while (Answer == "")

            {
                Console.WriteLine("You didn't type anything, please try again:");
                Answer = Console.ReadLine();
            }

            return Answer;
        }
    }
}
