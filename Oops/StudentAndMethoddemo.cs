using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class StudentAndMethoddemo
    {
        public int id;
        public string name;
        public int marks;

        static void Main(string[] args)
        {
            StudentAndMethoddemo nikhil;
            nikhil = new StudentAndMethoddemo();

            nikhil.id = 45;
            nikhil.name = "NIKHIL";
            nikhil.marks = 88;

            StudentAndMethoddemo stud = new StudentAndMethoddemo();
            stud.id = 100;
            stud.name = "yash";
            stud.marks = 99;
            Console.WriteLine(nikhil.id + " " + nikhil.name + " " + nikhil.marks);
            Console.WriteLine(stud.id + " " + stud.name + " " + stud.marks);
            Console.ReadLine();
        }
    }
    class MethodDemo

        //access modifier return type method name(parameterlist)
        //{

             //logic
        //1.no return type no parameter
    {
        public void show()

        {
            Console.WriteLine("show method");//method definition/body
        }
        //2.no return type with parameter
        public void Addition(int x,int y,double z)
        {
            Console.WriteLine("Addition= " + (x + y + z));
        }

        //3.no return type with parameter
        public double Area()
        {
            double area = 3.14 * 9 * 9;
            return area;
        }

        //4.with return type with parameter
        public float Calculate(int x,float y)
        {
            float ans = x * y;
            return ans;
        }
        static void Main(string[] args)
        {
            MethodDemo d = new MethodDemo();
            d.show();//method calling
            d.Addition(4, 9,9);


            double ans = d.Area();
            Console.WriteLine("Area of circle is=" + ans);
            Console.WriteLine("Area of circle is=" + d.Area());

            float result = d.Calculate(5, 4.3f);
            Console.WriteLine(result);

            Console.WriteLine(d.Calculate(5, 4.3f));
            Console.ReadLine();
        }

    }
}
