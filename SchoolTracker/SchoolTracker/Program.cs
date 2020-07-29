using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while ( adding == true)
            {
                var newStudent = new Student();

                Console.Write("What's the student's name?" + " ");
                newStudent.Name = Console.ReadLine();

                Console.Write("What grade did they get?" + " ");
                newStudent.Grade = (int.Parse(Console.ReadLine()));

                Console.Write("What is their birthday?" + " ");
                newStudent.Birthday = Console.ReadLine();

                Console.Write("What is their address?" + " ");
                newStudent.Address = Console.ReadLine();

                Console.Write("What is their phone number?" + " ");
                newStudent.Phone = (int.Parse(Console.ReadLine()));

                students.Add(newStudent);


                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() == "n")
                    adding = false;

            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3}, Phone: {4}", student.Name, student.Grade, student.Birthday, student.Address, student.Phone);
            }
        }
    }
    
    class Student
    {

        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public int Phone;

    }
}