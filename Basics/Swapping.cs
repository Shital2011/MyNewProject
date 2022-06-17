using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Basics
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            num1 = 32;
            num2 = 56;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("after swapping num2" + num1);
            Console.WriteLine("after swapping num1" + num2);
            Console.ReadLine();
        }
    }

}
