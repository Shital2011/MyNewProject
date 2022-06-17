using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n%2==1)
            {
                Console.WriteLine("odd");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Even");
                Console.ReadLine();
            }
        }
    }

    class Divisble_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 5==0)
            {
                Console.WriteLine(n + "is divisible 5");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine(n + "Not divible b 5");
                Console.ReadLine();
            }

        }
    }
}
