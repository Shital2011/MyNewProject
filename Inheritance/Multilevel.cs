using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Person
    {
        public string name = "Rajesh";
    }
    class Employee:Person
    {
        public int id = 101;
        public string dept = "sales";
    }
    class Manager:Employee
    {
        public int salary=90000;
        public void show()
        {
            Console.WriteLine(name + " " + id + " " + dept+" "+salary);
        }
    }
    class Multilevel

    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.show();
            Console.ReadLine();
        }
    }
}
