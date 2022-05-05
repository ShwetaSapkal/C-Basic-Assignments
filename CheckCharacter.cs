using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class CheckCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character");
            char ch = Convert.ToChar(Console.Read());

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("It is alphabet");
            }

            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("It is digit");
            }
            else
            {
                Console.WriteLine("It is special character");
            }
        }
    }
}
