using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[] { 80,77,99,55,66,72,85,95,44,65};


            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
            
        }
    }
}
