using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass6_Containtment_Inheritance
{
    class Order
    {
        int oid;
        string odate;
        public Customer c = new Customer();
        public Item i = new Item();

        public Order()
        {

        }

        public Order(int oid, string odate,Customer c, Item i)
        {
            this.oid=oid;
            this.odate=odate;
            this.c=c;
            this.i=i;
        }

         public void setOrderid(int oid)
         {
            this.oid = oid;
         }

        public int getOrderid()
        {
            return this.oid;
        }

        public void setOrderdate(string odate)
        {
            this.odate = odate;
        }
        public string getOrderdate()
        {
            return this.odate;
        }

        public void setCustomer(Customer c)
        {
            this.c= c;
        }
        public Customer getCustomer()
        {
            return this.c;
        }

        public void setItem(Item i)
        {
            this.i = i;
        }
        public Item getItem()
        {
            return this.i;
        }

    }

    class Customer
    {
        int custid;
        string custname;
        public Address add = new Address();

        public Customer()
        {
            
        }

        public Customer(int custid, string custname, Address add)
        {
            this.custid = custid;
            this.custname = custname;
            this.add = add;
        }


        public void setCustid(int custid)
        {
            this.custid = custid;
        }
        public int getCustid()
        {
            return this.custid;
        }

        public void setCustname(string custname)
        {
            this.custname = custname;
        }
        public string getCustname()
        {
            return this.custname;
        }

        public void setAddress(Address add)
        {
            this.add = add;
        }
        public Address getAddress()
        {
            return this.add;
        }


    }


    class Address
    {
        string city;
        int pincode;

        public Address()
        {
            
        }

        public Address(string city, int pincode)
        {
            this.city = city;
            this.pincode = pincode;
        }


        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return this.city;
        }

        public void setPincode(int pincode)
        {
            this.pincode = pincode;
        }
        public int getPincode()
        {
            return this.pincode;
        }



    }

    class Item
    {

        int itemid;
        string iname;
        int price;

        public Item()
        {
            
        }

        public Item(int itemid,string iname,int price)
        {
            this.itemid = itemid;
            this.iname = iname;
            this.price = price;
        }


        public void setItemid(int itemid)
        {
            this.itemid = itemid;
        }
        public int getItemid()
        {
           return this.itemid;
        }

        public void setItemname(string iname)
        {
            this.iname = iname;
        }
        public string getItemname()
        {
            return this.iname;
        }

        public void setItemprice(int price)
        {
            this.price = price;
        }
        public int getItemprice()
        {
            return this.price;
        }

    }




    class OrderTest
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            o1.setOrderid(1);
            o1.setOrderdate("10-04-2022");

         
            o1.c.setCustid(101);
            o1.c.setCustname("Shweta");

           
            o1.c.add.setCity("Pune");
            o1.c.add.setPincode(412211);

            
            o1.i.setItemid(201);
            o1.i.setItemname("Kurti");
            o1.i.setItemprice(1000);


            Console.WriteLine("details of Order");

            Console.WriteLine(o1.getOrderid());
            Console.WriteLine(o1.getOrderdate());

            Console.WriteLine(o1.c.getCustid());
            Console.WriteLine(o1.c.getCustname());

            Console.WriteLine(o1.c.add.getCity());
            Console.WriteLine(o1.c.add.getPincode());

            Console.WriteLine(o1.i.getItemid());
            Console.WriteLine(o1.i.getItemname());
            Console.WriteLine(o1.i.getItemprice());
        }
    }







}
