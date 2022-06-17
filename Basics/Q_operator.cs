using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Basics
{
    class Q_operator
    {
        static void Main(string[] args)
        {
            int a = 5, b = 4, c = 3;
            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a="+ a+ "b=" +b+"c="+c); 
            Console.WriteLine( b *5/a+ b++ +b);
            Console.WriteLine("a=" + a + "b=" + b + "c=" + c);
            Console.ReadLine();
        }
    }
}
