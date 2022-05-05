using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class PrintTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int table = 1;
            for (int i = 1; i <= 10; i++)
            {
                table = num * i;
                Console.WriteLine(table);
            }
            

        }
        
    }
}
