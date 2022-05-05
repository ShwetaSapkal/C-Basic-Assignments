using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass6_Containtment_Inheritance
{
    class Teacher
    {
        int tid;
        string tname;
        long mobileno;

        public Teacher()
        {
            
        }

        public Teacher(int tid, string tname, long mobileno)
        {
            this.Tid = tid;
            this.Tname = tname;
            this.Mobileno = mobileno;
        }

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public long Mobileno { get => mobileno; set => mobileno = value; }
    }

    class HourlyBasedTeacher : Teacher
    {
        int rate_pr_hr;
        int hrs;

        public HourlyBasedTeacher()
        {
            
        }
       //public HourlyBasedTeacher(int rate_pr_hr, int hrs ,int tid,string tname,long mobileno):base(tid,tname,mobileno)
       public HourlyBasedTeacher(int rate_pr_hr,int hrs)
        {

            this.rate_pr_hr = rate_pr_hr;
            this.hrs = hrs;
        }

        public int Rate_pr_hr { get => rate_pr_hr; set => rate_pr_hr = value; }
        public int Hrs { get => hrs; set => hrs = value; }

        internal void hsalary()
        {
            int sal = rate_pr_hr * hrs;
            Console.WriteLine("Hourly Based Teacher Salary"+sal);
        }
    }


    class SalaryBasedTeacher : Teacher
    {
        long salary;


        //public SalaryBasedTeacher(int tid, string tname, long mobileno,long salary) : base(tid, tname, mobileno)

        public SalaryBasedTeacher()
        {

        }

        public SalaryBasedTeacher(long salary)
        {

            this.salary = salary;
        }

        public long Salary { get => salary; set => salary = value; }

        internal void ssalary()
        {
            Console.WriteLine("Salary based Teacher salary"+salary);
        }

    }
 

    class TeacherTest
    {
        static void Main(string[] args)
        {
           Teacher t1 = new Teacher(1, "Deepa", 998776655L);
            
            HourlyBasedTeacher h1 = new HourlyBasedTeacher(2000,2);
            h1.hsalary();

            SalaryBasedTeacher s1 = new SalaryBasedTeacher(10000);
            s1.ssalary();
        }



    }



}
