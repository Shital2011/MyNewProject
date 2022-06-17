using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Animal
    {
        public int legs = 0;
        public void display()
        {
            Console.WriteLine("animal");
        }
    }
    class Dog:Animal
    {
        public void show()
        {
            legs = 4;
            Console.WriteLine(legs);
        }
    }
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            a.show();
            a.display();
            Console.ReadLine();
        }
       
    }
}
