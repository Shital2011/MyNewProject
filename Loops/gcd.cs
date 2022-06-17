using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class gcd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enterr num 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enterr num 2");
            int num2 = int.Parse(Console.ReadLine());
            int numerator;
            int denominator;
            if(num1>num2)
            {
                numerator = num1;
                denominator = num2;
            }
            else
            {
                numerator = num2;
                denominator = num1;
            }
            int remainder = numerator % denominator;
            while(remainder!=0)
            {
                numerator = denominator;
                denominator = remainder;
                remainder = numerator % denominator;
            }
            int gcd = denominator;
            int lcm = num1 * num2 / gcd;
            Console.WriteLine("Gcd of num1 and num2: " + gcd);
            Console.WriteLine("lcm of num1 and num2: " + lcm);
            Console.ReadLine();
        }
    }
}
