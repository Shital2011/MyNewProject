using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class ThisConstructor
    {
        public ThisConstructor():this(90)
        {
            Console.WriteLine("Default");
        }
        public ThisConstructor(int x)
        {
            Console.WriteLine("x=  " + x);
        }
        public ThisConstructor(string city):this()
        {
            Console.WriteLine(city);
        }
        static void Main(string[] args)
        {
            ThisConstructor t = new ThisConstructor("Kop");
            Console.ReadLine();
        }
    }
}
