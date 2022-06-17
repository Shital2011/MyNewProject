using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class Swapping
    { 
        public void swap( ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            Swapping s = new Swapping();
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + "  " + num2);
            s.swap( ref num1, ref num2);

            Console.WriteLine(num1 + " " + num2);
            Console.ReadLine();
        }

    }
}
