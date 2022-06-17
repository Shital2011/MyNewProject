using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Containment
{
    class Adress
    {
        public int pincode;
        public string city;
        public Adress(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void show()
        {
            Console.WriteLine(pincode + " " + city);
        }

    }
    class Person
    {
        int id;
        string name;
        Adress adr;

        Person(int id,string name,Adress adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " ");
            adr.show();
        }
        static void Main(string[] args)
        {
            Adress a = new Adress(2343, "pune");
            Person p = new Person(1, "amit", a);
            Console.WriteLine(p);
            p.display();
            Console.WriteLine("...................");
            Person p1 = new Person(1, "Amit", new Adress(234, "Pune"));
            p1.display();
            Console.ReadLine();
            
            
        }
    }
   
}
