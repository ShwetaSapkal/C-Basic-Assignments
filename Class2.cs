using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string nm = Console.ReadLine();
            Console.WriteLine("Name is" + nm);

            
            Console.WriteLine("Enter age:");
            short age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("age is" + age);

            Console.WriteLine("Enter gender:");
            char gender = Convert.ToChar(Console.Read());
            Console.ReadLine();

            Console.WriteLine("mobile no:");
            long mno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("mobile no is" + mno);

            Console.WriteLine("Enter Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("salary is" + salary);

            Console.WriteLine("enter percentage:");
           float per = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("percentage is" + per);

            Console.WriteLine("enter value for double datatype:");
            double db = Convert.ToDouble(Console.ReadLine());
     






        }
    }
}
