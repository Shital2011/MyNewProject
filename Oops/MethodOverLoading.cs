using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class MethodOverLoading
    {
        public void show()
        {
            Console.WriteLine("show");
        }
        void show(string str)
        {
            Console.WriteLine("str= " + str);
        }
        int show(int x)
        {
            Console.WriteLine("x  " + x);
            return 0;
        }
        void show (int x,int y)
        {
            Console.WriteLine("add= " + (x + y));
        }
        static void Main(string[] args)
        {
            MethodOverLoading m =new MethodOverLoading();
            m.show(10);
            m.show();
            m.show("pune");
            m.show(4, 5);
            Console.ReadLine();
        }
    }
}
