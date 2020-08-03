using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class SchoolUtil
    {
        static public string Ask(string question)
        {
            Console.Write(question);
            return System.Console.ReadLine();
        }
    }
}
