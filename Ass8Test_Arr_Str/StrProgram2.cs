using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass8Test_Arr_Str
{
    class StrProgram2
    {
        static void Main(string[] args)
        {
            string s1 = "cake";
            string s2 = "bake";

            Console.WriteLine(s1 == s2);
            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();


            Array.Sort(a1);
            Array.Sort(a2);


            string ss1 = string.Join("", a1);
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
