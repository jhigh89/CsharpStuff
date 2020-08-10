using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jake's Grade Book");
            book.AddGrade(90.2);
            book.AddGrade(95.5);
            book.AddGrade(100.0);
            book.ShowStatistics();
        }
    }
}

