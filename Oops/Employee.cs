using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class Employee
    {
        int id;
        string name;
        int salary;

        public Employee(int eid,string ename,int esalary)
        {//intiallisation of instance variable
            id = eid;
            name = ename;
            salary = esalary;
            
        }
        void Display()
        {
            Console.WriteLine(id + ' ' +  name + ' ' + salary);

        }
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "shital", 67000);
            e.Display();
            Console.ReadLine();
        }

    }
}
