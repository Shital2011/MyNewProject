using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class EquilateralTriangle
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter length");
            double L = Convert.ToInt32(Console.ReadLine());
            double A;

            A = (1.73 / 4) * L * L;
            Console.WriteLine("Area" + "=" + A);
            Console.ReadLine();
        }
    }
}
