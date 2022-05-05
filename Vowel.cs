using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabet");
            char ch = Convert.ToChar(Console.Read());
            
            
            switch(ch)
            {
                case 'a': 

                case 'e':

                case 'i':

                case 'o':

                case 'u': Console.WriteLine("vowel");
                    break;

                default : Console.WriteLine("consonent");
                    break;


            }
        } 
    }
}
