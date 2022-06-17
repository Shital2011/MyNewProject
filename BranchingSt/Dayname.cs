using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.BranchingSt
{
    class Dayname
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date");
            int date = Convert.ToInt32(Console.ReadLine());

            switch(date)
            {
                case 1:
                    Console.WriteLine("Monday");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    Console.ReadLine();
                    break;


            }
            
        }
    }
}
