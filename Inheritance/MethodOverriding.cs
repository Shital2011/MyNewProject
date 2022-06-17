using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Shape
    { public  int l;

        public virtual void area()
        {
            Console.WriteLine("area");
        }
    }
    class Traingle:Shape
    {
        int b = 1;
        
        public override void area()
        {
            l = 2;
            int area = l * b;
            Console.WriteLine("Area of Triangle=" + area);

        }
    }
    class Circle:Shape
    {
       public int r = 8;
       

        public override void area()
        {
            l = r;
            float f = 3.14f;
            float area =(l*l)*f ;
            Console.WriteLine("area of circle= " + area);
        }

    }
    class Rectangle:Shape
    {
        int b = 6;
        
        public override void area()
        {
              l = 8;
            int area = l * b;
            Console.WriteLine("Area of rectangle=" + area);

            

        }
    }
    class MethodOverriding
    {

        static void Main(string[] args)
        {
            Shape s = new Traingle();
            s.area();
            Shape s1 = new Circle();
            s1.area();
            Shape s2 = new Rectangle();
            s2.area();
            Console.ReadLine();
        }
    }
}
