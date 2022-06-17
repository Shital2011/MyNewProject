using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class O_1to_n
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());
            int i, sum = 0;

            for (i = 1; i <= n; i++)
                if (i % 2 == 1)
                {
                    sum = sum + i;


                }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
    
    
}
