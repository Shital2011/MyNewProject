using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.BranchingSt
{
    class Switchword1_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:Console.WriteLine("one");
                    Console.ReadLine();
                        break;
                case 2:
                    Console.WriteLine("two");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("three");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("four");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Five");
                    Console.ReadLine();
                    break;
                 default:
                    Console.WriteLine("not exist");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
