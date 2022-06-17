using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class Marks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of sub1");
            double sub1 = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Enter marks of sub2");
            double sub2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter marks of subb3");
            double sub3 = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Enter marks of sub4");
            double sub4 = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Enter sub5");
            double sub5 = Convert.ToDouble(Console.ReadLine());

            double T, A, P;
            T = (sub1 + sub2 + sub3 + sub4 + sub5);
            Console.WriteLine("total marks" + "=" + T);

            A = (T / 5);
            Console.WriteLine("Average Marks" + "=" + A);

            P = ((T / 500) * 100);//Consider total marks is out of 500
            Console.WriteLine("If Every sub is out of 100 then Percentage is " + " " + P);
            Console.ReadLine();


        }
    }
}
