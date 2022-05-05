using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass8Test_Arr_Str
{
    class StrProgram3
    {
        static void Main(string[] args)
        {
            string s1 = "Help others";
            string s2 = s1.Replace(" ", " ");

            StringBuilder sb = new StringBuilder();


            for (int i = s2.Length - 1; i >= 0; i--)
            {
                sb.Append(s2[i]);
            }
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == ' ')
                    {
                        sb.Insert(i, " ");
                    }
                }

                Console.WriteLine(sb);
            }
        
    }
}
