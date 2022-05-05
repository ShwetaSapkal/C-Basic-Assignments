using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass7_String
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s1 = Console.ReadLine();

            int idx = s1.IndexOf('s');
            Console.WriteLine("index of s=" + idx);

        }
    }
}
