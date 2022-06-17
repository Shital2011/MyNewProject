using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class This
    {
        int x;
        public This():this(33)
        {
            Console.WriteLine("default");

        }
        public This(int x)
        {
            this.x = x;
        }
        public void show()
        {
            Console.WriteLine(this.x);

        }
        public void sho()
        {
            Console.Write("x=");
            show(); 
           
        }
        static void Main(string[] args)
        {
            This s = new This();
            s.sho();

            Console.ReadLine();
        }
    }
        
}
