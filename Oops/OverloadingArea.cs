using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class OverloadingArea
    {
       // Q.Write code to overload area method to calculate area of circle,area of rectangle,area of triangle and area of square
        void Area(int r)
        {
            float pi = 3.14f;
            double area = (r * r) * pi;
            Console.WriteLine("area of circle= " + area);

        }
        void Area(float l,float b)
        {
            double area = l * b;
            Console.WriteLine("area of rectangle= " + area);
        }
        void Area(float l)
        {
            Console.WriteLine("Area of square= " + (l * l));
        }
        void Area(int h,int b)
        {
            float x = 0.5f;
            double area = x * h * b;
            Console.WriteLine("Area of Triangle= " + area);
        }
        static void Main(string[] args)
        {
            OverloadingArea a = new OverloadingArea();
            a.Area(4);
            a.Area(2.4f, 4.3f);
            a.Area(4f);
            a.Area(4, 6);
            Console.ReadLine();
        }
    }
}
