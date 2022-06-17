using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class StaticDemo
    {
       static int count = 0;
        int x = 10;
        public StaticDemo()
        {
            count++;
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        { // Console.WriteLine(x);//non static not acces
            Console.WriteLine(count);
            StaticDemo d = new StaticDemo();
            StaticDemo d1 = new StaticDemo();
            StaticDemo d2 = new StaticDemo();
            Console.ReadLine();

        }
    }
}
