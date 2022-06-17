using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Abstraction
{
    abstract class Vehicle
    {
        public int x = 10;
        public static int y = 78;

        //Abstract Method
        public abstract void run();
        //constructor
        public Vehicle(string name)
        {
            Console.WriteLine("car name= " + name);

        }
        //method
        public void show()
        {
            Console.WriteLine("show method");
        }
    }
    class Car:Vehicle
    {
        //Constructor calling
        public Car():base("Audi")
        {
            Console.WriteLine("my car");
        }
        //method overriding
        public override void run()
        {
            Console.WriteLine("Car is running ....." + x + " " + base.x);
        }
    }
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.run();
            v.show();
            Console.ReadLine();
        }
    }
}
