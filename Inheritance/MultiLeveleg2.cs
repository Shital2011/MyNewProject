using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Integer
    {
        public int n;
        
        
        

    }
    class Even:Integer

    {
        
        public void show()
        {
            n = 2;

            Console.WriteLine(n + "is Even Number");
            
        }
    }
    class Prime:Even
    {
        public void showP()
        {
            show();
            
            Console.WriteLine(n + "it is also prime number");
        }
        static void Main(string[] args)
        {
            Prime n = new Prime();
            n.showP();
            Console.ReadLine();
        }
        

    }
}
