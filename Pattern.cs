using System;
using System.Collections.Generic;
using System.Text;


/*
 Enter no of rows 
7


 1
 1 1
 1 1 2
 1 1 2 3
 1 1 2 3 5
 1 1 2 3 5 8
 */

namespace CSPrograms
{
    class Pattern
    {
        static void Main(string[] args)
        {
           
            

            Console.WriteLine("Enter no of rows");
            int r = Convert.ToInt32(Console.ReadLine());




            for (int i = 1; i < r; i++)
            {
                int a = 1, b = 1;
                for (int j = 1; j <= i; j++)
                {
                   
                    int sum = a + b;
                    Console.Write(a + " ");

                    a = b;
                    b = sum;
                    
                }

            
                
                Console.WriteLine();
            }
            


            

            
            

        }


    }
}
