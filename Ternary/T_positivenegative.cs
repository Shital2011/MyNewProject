using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Ternary
{
    class T_positivenegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            double n = double.Parse(Console.ReadLine());

            string v = n > 0 ? "Positive" : ((n == 0)?"zero":"negative");
            Console.WriteLine(v);
            Console.ReadLine();
        }


    }
}
