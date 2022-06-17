using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Students
    {
        public int marks = 78;

        public void get(string name)
        {
            Console.WriteLine(name);
        }
    }

    class Teachers:Students
    {
        public int marks = 90;
        public void show()
        {
            Console.WriteLine(marks + " " + base.marks);
        }
        public void get()
        {
            base.get("Sneha");
            Console.WriteLine("Teacher");
        }
    }

    class Mobile
    {
        string memory = "64 GB";
        public Mobile(int x, int y)
        {
            Console.WriteLine("Mobile Memory= " + memory + " " + x);
        }
        
    }
    class Apple:Mobile
    {
        public Apple(int y):base(23,y)
        {
            Console.WriteLine("Apple");
            
        }

    }


    class BaseAll
    {
        static void Main(string[] args)
        {
            Teachers t = new Teachers();
            t.show();
            t.get();
           

            Console.WriteLine("///////////////////////////////////////////");
            Apple a = new Apple(890);
            Console.ReadLine();
        }
    }
}
