using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.BranchingSt
{
    class Switch_OddEven
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 2;
            
            

            switch(b)
            {
                case 0:
                    Console.WriteLine( "It is Even");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine("Odd");
                    Console.ReadLine();
                    break;


            }
        }
    }
}
