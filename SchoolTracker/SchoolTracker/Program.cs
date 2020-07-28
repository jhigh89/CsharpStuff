using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many students will be in the class?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentNames = new string[studentCount];
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("What's the student's name?" + " ");
                studentNames[i] = Console.ReadLine();
                

                Console.Write("What grade did they get?" + " ");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    } 
}
