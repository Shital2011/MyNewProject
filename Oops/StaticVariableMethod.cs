using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class StaticVariableMethod
    {
        int x = 10;
        static int y = 30;
        void add()
        {
            Console.WriteLine("Addition is =  " + (x + y));
            y = 1;
            Console.WriteLine("Add= " + (x + y));

        }
        static void sum()
        {
            StaticVariableMethod m = new StaticVariableMethod();
            Console.WriteLine("sum==" + (m.x + y));
        }
        static void Main(string[] args)
        {
            StaticVariableMethod m = new StaticVariableMethod();
            m.add();
            sum();
            Console.ReadLine();
        }
    }
    class Test
    {
        static int x = 10;

        public void get(int x)
        {
            //x=x
            Test.x = x;

        }
        public void show()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Test t = new Test();
            t.get(90);
            t.show();
            Console.ReadLine();
        }
    }
    
}
