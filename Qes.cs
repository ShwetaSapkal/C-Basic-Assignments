using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class Qes
    {
        static void Main(string[] args)
        {
            /*int i, s = 0;
            for (i = 1; i <= 10; s = s + i, i++) ;
            {
                Console.WriteLine(s); 
            }
            Console.ReadLine();
            */

            /* int i = 0;
             for (i = 0; ;)
             {
                 Console.WriteLine("hello");
             }
             Console.ReadLine();
            */


            /* int i = 5;
             for (; Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i--)) ;

                 Console.ReadLine();
            */

            float f;
            for (f = 0.1f; f <= 0.5; f += 1)
            {
                Console.WriteLine(++f);
                Console.ReadLine();
            }

        }
     
    }
}
