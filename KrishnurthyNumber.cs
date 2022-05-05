using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class KrishnurthyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());


            int digit = 0, fact=1 ,sum = 0;
            


            while (num > 0)
            {
                digit = num % 10;
              
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                 }
        
                sum = sum + fact;
                
                num = num / 10;
               
            }

            int temp = num;

                if (sum == temp)
                {
                    Console.WriteLine("Krishnmurthy number");

                }
                else
                {
                    Console.WriteLine("Not Krishnmurthy number");
                }


            

           
        }
    }
}
