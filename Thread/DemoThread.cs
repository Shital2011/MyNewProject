using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace MyNewProject.Thread
{
    class DemoThread
    {
        public void m1()
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts");
           

        }
    }
}
