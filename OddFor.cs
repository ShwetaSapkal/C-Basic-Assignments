using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class OddFor
    {
        static void Main(string[] args)
        {

            for (int i = 521; i >= 229; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
