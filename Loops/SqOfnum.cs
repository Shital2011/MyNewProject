using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class SqOfnum
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                int sq = i * i;
                Console.WriteLine(sq);
                Console.ReadLine();

            }
        }
    }
}
