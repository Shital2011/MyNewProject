using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class CountOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int p = 1;
            while(n>0)
            {
                int i = n % 10;
                count++;
                p = p * i;
                n = n / 10;
            }
            Console.WriteLine(count);
            Console.WriteLine(p);
            Console.ReadLine();
            
            
        }
    }
}
