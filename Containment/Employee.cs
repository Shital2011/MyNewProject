using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Containment
{
    class Department
    {
        int did;
        string dname;
        public int Did
        {
            get { return did; }
            set { did = value; }

        }
        public string Dname
        {
            get { return dname; }
            set { dname = value; }
        }
    }
    class Employee
    {
        int eid;
        string name;
        Department dept;
        
        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Department Dept
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Department d = new Department();
            d.Did = 1;
            d.Dname = "sales";

            Employee e = new Employee();
            e.Eid = 101;
            e.Name = "Amit";
            //e.Dept = d;
            Console.WriteLine(e.Eid + " " + e.Name + " " + d.Did + " " + d.Dname);

            Console.WriteLine("////////////////");
            

            Employee E = new Employee();
            E.Eid = 102;
            E.Name = "Neha";
            E.Dept = new Department();

            E.Dept.Did = 1;
            E.Dept.Dname = "HR";

            Console.WriteLine(E.Eid + " " + E.Name + " " + E.Dept.Did + " " + E.Dept.Dname);
            Console.ReadLine();
        }
    }


}
