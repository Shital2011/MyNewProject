using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a base");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a index");
            int index = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            for(int i=1;i<=index;i++)
            {
                power = power * b;
            }
            Console.WriteLine(power);
            Console.ReadLine();
        }
    }
}
