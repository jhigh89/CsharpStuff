using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            var credential = "";
            while (credential != "secret") {
                Console.WriteLine(" ");
                Console.WriteLine("Please provide your case-sensitive password:");
                credential = Console.ReadLine();
                if (credential != "secret")
                {
                    Console.WriteLine("You have not been authenticated. Please provide the correct password.");
                } 

            }
            Console.WriteLine("You have been authenticated. Please proceed!");

        }
    }
}
