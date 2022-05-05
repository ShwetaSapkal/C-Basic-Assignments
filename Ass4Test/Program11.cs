using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass4Test
{
    class Program11
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input IMEI number");
            long num = Convert.ToInt64(Console.ReadLine());

            long a = num;

            
            int sum = 0;


            
                for (int i = 15; i >=1; i--)
                {
                    int digit = (int)num % 10;

                     while (num > 0)
                     {

                         if (i % 2 == 0)
                         {
                          digit = 2 * digit;
                          sum = sum + digit;
                          //num = num / 10;
                         }
                      }

               
            }

           

             if (sum % 10 == 0)
             {
                 Console.WriteLine("IMEI number is valid");
             }
             else
             {
                 Console.WriteLine("IMEI is not valid");
             }
           


        }
    }
}
