using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class Break
    {
        static void Main(string[] args)
        {
            int i, n;
            n = 100;
            for (i = 1; i <= n; i++)
            {

                if (i == 10)
                
                    break;

                Console.WriteLine(i);
                Console.ReadLine();


            }


        }
    }
}
