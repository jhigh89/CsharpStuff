using System;

namespace Challenge1
{
    class Data
    {

        public string Name;
        public int Age;
        public string Month;

        public void Display()
        {
            Console.WriteLine("Hello, {0}! You stated you are {1} years old and were born in the month of {2}.", Name, Age, Month);

            switch (Month)
            {
                case "March":
                    Console.WriteLine("You are an aries...");
                    break;
                case "April":
                    Console.WriteLine("You are a taurus...");
                    break;
                case "May":
                    Console.WriteLine("You are a gemini...");
                    break;
                case "October":
                    Console.WriteLine("You are a libra...");
                    break;
                default:
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var surveyData = new Data();

            Console.WriteLine("Hello, and welcome to SimpleInfoGrabber.");
            Console.WriteLine("What's your name?");

            surveyData.Name = TryAnswer();

            Console.WriteLine("How old are you?");

            surveyData.Age = int.Parse(TryAnswer());
          
            Console.WriteLine("What month were you born in?");

            surveyData.Month = TryAnswer();

            surveyData.Display();

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
