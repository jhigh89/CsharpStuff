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

                newStudent.Name = Util.SchoolUtil.Ask("What's the student's name?" + " ");

                newStudent.Grade = (int.Parse(Util.SchoolUtil.Ask("What grade did they get?" + " ")));

                newStudent.Birthday = Util.SchoolUtil.Ask("What is their birthday?" + " ");

                newStudent.Address = Util.SchoolUtil.Ask("What is their address?" + " ");

                newStudent.SetPhone(int.Parse(Util.SchoolUtil.Ask("What is their phone number?" + " ")));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() == "n")
                    adding = false;

            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3}", student.Name, student.Grade, student.Birthday, student.Address);
            }
        }
    }
    
    class Student
    {
        static public int Count = 0;

        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        public int Phone
        {
            set { phone = value; }
        }

        public void SetPhone(int number)
        {
            phone = number;
        }
    }
}