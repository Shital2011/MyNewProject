using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    class D_delegates
    {
        public delegate void mydel(int n);
        static void Main(string[] args)
        {
            mydel d = (n) =>
              {
                 
                  int s = 1;
                  for (int i = 1; i <= n; i++)
                  {
                      s = s * i;
                  }
                  Console.WriteLine(s);
                  
              };
            d(5);
            Console.ReadLine();

            

        }
    }
}
