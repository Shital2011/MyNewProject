using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class _121_to_229
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 121; i <= 229; i++) 
            if(i %2 ==0)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

        }
    }
}
