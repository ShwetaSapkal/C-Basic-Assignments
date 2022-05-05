using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass9_ExceptionHandling
{
    class Class2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter two numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                int div = a / b;
                Console.WriteLine("div=" + div);
            }
           
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }
            catch (FormatException fm)
            {
                Console.WriteLine(fm.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("try ends");
        }


    }
}
