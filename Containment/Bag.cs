using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Containment
{//)create containment for the bag class bag has colour, brand name,price and object of pen,
    //pen has pen name, pen colour and object of nib, nib has type

    class Nib
    {
        string type;
        public Nib(string type)
        {
            this.type = type;
        }

        public void show()
        {
            Console.WriteLine(type);
        }
        
        

    }
    class Pen
    {
        string name;
        string colour;
        Nib n;

        public Pen(string name,string colour,Nib n)
        {
            this.name = name;
            this.colour = colour;
            this.n = n;
        }
        public void showPen()
        {
            Console.WriteLine(name + " " + colour);
            n.show();
        }
    }
    class Bag
    {
        string colour;
        string brand;
        int price;
        Pen p;

        public Bag(string colour,string brand,int price,Pen p)
        {
            this.colour = colour;
            this.brand = brand;
            this.price = price;
            this.p = p;
        }
        public void ShowBag()
        {
            Console.WriteLine(colour + " " + brand + " " + price);
            p.showPen();
        }
        static void Main(string[] args)
        {
            Bag b = new Bag("Blue", "Puma", 5000, new Pen("Reynolds", "black", new Nib("Metal")));
            b.ShowBag();
            Console.ReadLine();
        }

    }
}
