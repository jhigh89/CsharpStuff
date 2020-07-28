using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;

            while ( adding == true)
            {
                Console.Write("What's the student's name?" + " ");
                studentNames.Add(Console.ReadLine());

                Console.Write("What grade did they get?" + " ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() == "n")
                    adding = false;

            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    } 
}