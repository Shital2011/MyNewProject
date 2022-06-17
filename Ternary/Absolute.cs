using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Ternary
{
    class Absolute
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = Convert.ToInt32(Console.ReadLine());
            n=n >= 0 ? n : (-(n));
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
