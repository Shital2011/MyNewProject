using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class ContsructorOverLoading
    {
        ContsructorOverLoading()
        {
            Console.WriteLine("......");
        }
        ContsructorOverLoading(int x)
        {
            
            Console.WriteLine(x);
        }
        ContsructorOverLoading(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            ContsructorOverLoading d = new ContsructorOverLoading();
            ContsructorOverLoading d1 = new ContsructorOverLoading(2);
            ContsructorOverLoading d2 = new ContsructorOverLoading("shital");
            Console.ReadLine();
        }




        

    }
}
