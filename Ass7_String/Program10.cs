using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass7_String
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentence");
            string s1 = Console.ReadLine();

            string[] words = s1.Split(" ");

            string count = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (count.Length <= words[i].Length)
                {
                    count = words[i];
                }
                Console.WriteLine("");
                Console.WriteLine("Longest word=" + count);
            }

        }
    }
}
