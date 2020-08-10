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

        static public int AskInt(string question)
        {
            try
            {
                Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {

                throw new FormatException("Input wasn't a number!");
            }

            
        }
    }
}
