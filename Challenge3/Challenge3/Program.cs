using System;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            var loopin = 1;
            while (loopin <= 5) {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("There's loop {0}", loopin);
                loopin++;

            }
        }
    }
}
