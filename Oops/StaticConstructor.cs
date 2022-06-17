using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class StaticConstructor
    {
         StaticConstructor(int x)
        {
            Console.WriteLine("x=="+x);
        }
         static StaticConstructor()
        {
            Console.WriteLine("hii");
        }
        static void Main(string[] args)
        {
            StaticConstructor s = new StaticConstructor(200);
            StaticConstructor s1 = new StaticConstructor(400);


            Console.ReadLine();

        }


    }
}
