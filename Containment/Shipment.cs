using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Containment
{//2)create containment for shipment ,shipment has shipment id,object of order and object of orderdate
   // order has order id, cust name,city,order date has int mm d
   class Order
    {
        int oid;
        string name;
        string city;
        public int Oid
        {
            get { return oid; }
            set { oid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
    class OrderDate
    {
        int mm;
        int dd;
        int yy;
        public int MM
        {
            get { return mm; }
            set { mm = value; }
        }
        public int DD
        {  get;
            set;
        }
        public int YY
        {
            get;
            set;
        }
    }
    class Shipment
    {
        int id;
        Order o;
        OrderDate date;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Order O
        {
            get { return o; }
            set { o = value; }
        }
        public OrderDate Date
        {
            get { return date; }
            set { date = value; }
        }
        static void Main(string[] args)
        {
            Shipment s = new Shipment();
            s.Id = 123;
            s.O = new Order();
            s.Date = new OrderDate();
            s.O.Oid = 10;
            s.O.Name = "Shoes";
            s.O.City = "Kolhapur";
            s.Date.MM = 06;
            s.Date.DD = 26;
            s.Date.YY = 2022;
            Console.WriteLine(s.Id + " " + s.O.Oid + " " + s.O.Name + " " + s.O.City + " " + s.Date.DD + " " + s.Date.YY);
            Console.ReadLine();


        }


    }
}
