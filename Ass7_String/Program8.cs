using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass7_String
{
    class Program8
    {


        static void Main(string[] args)
        {
            string s1 = "silent";
            string s2 = "amitabh";

            Console.WriteLine(s1==s2);
            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();


            Array.Sort(a1);
            Array.Sort(a2);

            string ss1 = string.Join("",a1);
            string ss2 = string.Join("", a2);

            Console.WriteLine(ss1);
            Console.WriteLine(s2);

            if (ss1 == ss2)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }

        }





    }
}
