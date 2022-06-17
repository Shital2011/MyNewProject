using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class ThisMethod
    {
        int x;
        public void get(int x)
        {
            this.x = x;
            //this.show();
        }
        public void show()
        {
            get(34);
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            ThisMethod t = new ThisMethod();
            t.show();
            Console.ReadLine();
        }
    }
}
