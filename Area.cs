using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());

           
           


            float area = 0f;
            float pi = 3.14f;
            
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Radius");
                    int rad = Convert.ToInt32(Console.ReadLine());

                    area = (float)pi * rad * rad;
                    Console.WriteLine("area of circle="+area);
                    break;

                case 2:
                    Console.WriteLine("Enter Radius");
                    int rad1 = Convert.ToInt32(Console.ReadLine());

                    area = (float) rad1 * rad1;
                    Console.WriteLine("area of square=" + area);
                    break;

                case 3:
                    Console.WriteLine("Enter height");
                    int height = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter base");
                    int ibase = Convert.ToInt32(Console.ReadLine());

                    area = (float)1/2 * ibase * height;
                    Console.WriteLine("area of circle=" + area);
                    break;

                case 4:
                    Console.WriteLine("Enter radius");
                    int rad2 = Convert.ToInt32(Console.ReadLine());

                    area = (float)2*pi*rad2;
                    Console.WriteLine("area of circumference of circle=" + area);
                    break;

                case 5:
                    Console.WriteLine("Enter length");
                    int length = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter base");
                    int ibase1 = Convert.ToInt32(Console.ReadLine());

                    area = (float) length * ibase1;
                    Console.WriteLine("area of rectangle=" + area);
                    break;

            }
        }
    }
}
