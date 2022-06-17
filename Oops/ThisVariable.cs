using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class ThisVariable
    {
        int x;
     public ThisVariable(int x)
     {
            this.x = x;
            
     }
        public void show()
        {
            
            Console.WriteLine(x);

        }
        static void Main(string[] args)
        {
            ThisVariable v = new ThisVariable(10);
            v.show();
            
            Console.ReadLine();

        }
        


    }
}
