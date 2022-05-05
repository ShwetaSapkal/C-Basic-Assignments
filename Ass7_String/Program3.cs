using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass7_String
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s1 = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[1] == s1[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
          
        }

       

    }

}
