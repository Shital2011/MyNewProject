using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Containment
{
    class Subengine
    {
        string cleanupdate;
        public Subengine(string cleanupdate)
        {
            this.cleanupdate = cleanupdate;
        }
        public void show()
        {
            Console.WriteLine(cleanupdate);
        }
    }

    class Engine
    {
        string type;
        Subengine sub;
        public Engine(string type,Subengine sub)
        {
            this.type = type;
            this.sub = sub;
        }
        public void showengine()
        {
            Console.WriteLine(type);
            sub.show();

        }
    }
    class Car_nested
    {
        int model;
        string name;
        int price;
        Engine e;
        public Car_nested(int model,string name,int price,Engine e)
        {
            this.model = model;
            this.name = name;
            this.price = price;
            this.e = e;
        }
        public void showCar()
        {
            Console.WriteLine(model + " " + name + " " + price);
            e.showengine();
        }

        static void Main(string[] args)
        {
            Car_nested c = new Car_nested(123, "audi", 760000, new Engine("petrol", new Subengine("01/26/2019")));
            c.showCar();
            Console.ReadLine();
            Console.WriteLine("///////////////////");
        }
    }

   
    class Subengine1
    {
        
        string cleanupdate;
        public string Cleanupdate
        {
            get { return cleanupdate; }
            set { cleanupdate=value; }
        }


    }
    class Engine1
    {
        string type;
        Subengine1 sub;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Subengine1 Sub
        {
            get { return sub; }
            set { sub = value; }
        }

    }
    class Car_nested1
    {
        int model;
        string name;
        int price;
        Engine1 e;
        public int Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Name
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public Engine1 E
        {
            get { return e; }
            set { e = value; }
        }
        static void Main(string[] args)
        {
            Car_nested1 c =new Car_nested1();
            c.Model = 123;
            c.Name = "audi";
            c.Price = 750000;
            c.E = new Engine1();
            c.E.Type = "petrol";
            c.E.Sub = new Subengine1();
            c.E.Sub.Cleanupdate = "26/02/2022";
            Console.WriteLine(c.Model + " " + c.Name + " " + c.Price + " " + c.E.Type + " " + c.E.Sub.Cleanupdate);
            Console.ReadLine();
        }
    }
}
