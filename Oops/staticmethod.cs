using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class staticmethod
    {
       // QWrite a code to show overloading of static method
       static void St()
        {
            Console.WriteLine("...");
        }
        static void St(int x)
        {
            Console.WriteLine(x);

        }
        static void St(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
           
            St();
            St(2);
            St("ss");
            Console.ReadLine();
        }

    }
}
