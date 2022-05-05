using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass6_Containtment_Inheritance
{
    class Person
    {
        int pid;
        string pname;
        public Vehicle v = new Vehicle();

        public int Pid { get => pid; set => pid = value; }
        public string Pname { get => pname; set => pname = value; }
        internal Vehicle V { get => v; set => v = value; }

        public Person()
        {
            
        }

        public Person(int pid, string pname,Vehicle v )
        {
            this.Pid = pid;
            this.Pname = pname;
            this.V = v;
            
        }

    }


    class Vehicle
    {
        int vid;
        string vname;

        public Vehicle()
        {

        }

        public Vehicle(int vid,string vname)
        {
            this.Vid = vid;
            this.Vname = vname;
        }

        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }
    }


    class PersonTest
    {
        static void Main(string[] args)
        {


            Person p1 = new Person();
            Console.WriteLine("Person details");
            Console.WriteLine("person id=");
            int i = Convert.ToInt32(Console.ReadLine());
            p1.Pid = i;

            Console.WriteLine("person name=");
            string name = Console.ReadLine();
            p1.Pname = name;


            Person p2 = new Person();
            Console.WriteLine("Person details:");
            Console.WriteLine("person id=");
            int i1 = Convert.ToInt32(Console.ReadLine());
            p2.Pid = i1;

            Console.WriteLine("person name=");
            string name1 = Console.ReadLine();
            p2.Pname = name1;

            Vehicle v1 = new Vehicle();
            Console.WriteLine("Vechicle details:");

            Console.WriteLine("vehicle id");
            int vi = Convert.ToInt32(Console.ReadLine());
            v1.Vid = vi;

            Console.WriteLine("vehicle name");
            string vname1 = Console.ReadLine();
            v1.Vname=vname1;

            Console.WriteLine("Person id =" + p1.Pid);
            Console.WriteLine("Person name ="+p1.Pname);

            Console.WriteLine("Person id =" + p2.Pid);
            Console.WriteLine("Person name =" + p2.Pname);


            Console.WriteLine("Vehicle id =" + v1.Vid);
            Console.WriteLine("Vehicle name =" + v1.Vname);


        }
    }
}
