using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class Prime
    {
        static void Main(string[] args)
        {
            int num = 0, count = 0;
            for (int i = 400; i <= 300; i--)
            {

                if (num % i == 0)
                {
                    count--;
                   
                }
            }
            Console.WriteLine(num);
        }
        
    }
}
