using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass6_Containtment_Inheritance
{
    class Pen
    {
        
        int caplength;
        string brand;
        public Refill r = new Refill();

        public Pen()
        {

        }

        public Pen(int caplength,string brand,Refill r)
        {
            this.caplength = caplength;
            this.brand = brand;
            this.r = r;
        }

      

        public void setPenCaplength(int caplength)
        {
            this.caplength = caplength;
        }

        public int getPenCaplength()
        {
            return this.caplength;
        }

        public void setPenBrand(string brand)
        {
            this.brand = brand;
        }

        public string getPenBrand()
        {
            return this.brand;
        }

         public void setPenRefill(Refill r)
       {
           this.r = r;
       }
      
         public Refill getPenRefill()
         {
             return this.r;
         }
        
    }

    class Refill
    {
        string inkcolor;
        int length;
        public Nib nib = new Nib();

        public Refill()
        {

        }

        public Refill(string inkcolor,int length,Nib nib)
        {
            this.inkcolor = inkcolor;
            this.length = length;
            this.nib = nib;
        }
        public void setRefillColor(string inkcolor)
        {
            this.inkcolor=inkcolor;
        }

        public string getRefillColor()
        {
            return this.inkcolor;
        }


        public void setRefillLength(int length)
        {
             this.length=length;
        }
        public int getRefillLength()
        {
            return this.length;
        }

        public void setRefillNib(Nib nib)
        {
            this.nib=nib;
        }
        public Nib getRefillNib()
        {
            return this.nib;
        }


    }

    class Nib
    {
        string materialtype;
        int width;

        public Nib()
        {

        }

        public Nib(string materialtype, int width)
        {
            this.materialtype = materialtype;
            this.width = width;

        }
        public void setNibMtype(string materialtype)
        {
            this.materialtype = materialtype;
        }
        public string getNibMtype()
        {
            return this.materialtype;
        }

        public void setNibWidth(int width)
        {
            this.width = width;
        }
        public int getNibWidth()
        {
            return this.width;
        }



    }



    class PenTest
    {
        static void Main(string[] args)
        {
             Pen p1 = new Pen();
             p1.setPenCaplength(1);
             p1.setPenBrand("Trimax");
             p1.r.setRefillColor("Blue");

             
             
             p1.r.setRefillLength(11);
           
             p1.r.nib.setNibMtype("hard");
             p1.r.nib.setNibWidth(3);


            Console.WriteLine("Details of pen");

             Console.WriteLine(p1.getPenCaplength());
             Console.WriteLine(p1.getPenBrand());

             Console.WriteLine(p1.r.getRefillColor());
             Console.WriteLine(p1.r.getRefillLength());

             Console.WriteLine(p1.r.nib.getNibMtype());
             Console.WriteLine(p1.r.nib.getNibWidth());


             

        }

    }
}