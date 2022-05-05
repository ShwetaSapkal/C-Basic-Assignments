using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass7_String
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string s1 = Console.ReadLine();
            int wordcount = 1;
            for (int i = 0; i < s1.Length - 1; i++)
            {
                if (s1[i] == ' ' || s1[i] == '\n' || s1[i] == '\t')
                {
                    wordcount++;
                }

              //  Console.WriteLine("Number of words in given string =" + wordcount);
            }

            Console.WriteLine("Number of words in given string ="+wordcount);
        }
    }
}
