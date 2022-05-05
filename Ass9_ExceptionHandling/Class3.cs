using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass9_ExceptionHandling
{
    class Class3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter numbers in 1-10");
                int n = Convert.ToInt32(Console.ReadLine());
                
                for (int i = 1; i <11;i++)
                {
                    Console.WriteLine(i);
                    
                }
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }
        }
    }
}
