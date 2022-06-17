using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Basics
{
    class Operator
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;


            int x = ++a + ++b;
            Console.WriteLine(x + " " + a + " " + b);
           //6,3,3

            Console.WriteLine(6 * 2 / 4 - 5 * 3 * 2);
            

            Console.WriteLine(51 % 9 - 2 - 1 + 3);
            Console.WriteLine(88 % 5);
            Console.WriteLine(88 % 5);

           
            Console.WriteLine(90 * 9);
            Console.WriteLine(88 % 5);
            Console.ReadLine();

        }
    }
}
