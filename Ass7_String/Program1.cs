using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass7_String
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string s1 = Console.ReadLine();
            int idx = s1.IndexOf('a');
            int lastidx = s1.LastIndexOf('t');

            Console.WriteLine("index of a=" + idx);
            Console.WriteLine("last index=" + lastidx);

            //string ss = "ThinkQuotient";
            Console.WriteLine(s1.Substring(5));
            Console.WriteLine(s1.Substring(1, 3));

            Console.WriteLine("enter name");
            string s2 = Console.ReadLine();
            Console.WriteLine("length" + s2.Length);
            string ss = s2.Trim();

            ss = "riya";
            string dd = ss.Replace('s', 'r');
            Console.WriteLine(ss);
            Console.WriteLine(dd);
        }
    }
}
