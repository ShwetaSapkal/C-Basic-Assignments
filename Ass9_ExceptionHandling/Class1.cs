using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass9_ExceptionHandling
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            String str = null;

            try
            {
                Console.WriteLine(str.Substring(3));
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
