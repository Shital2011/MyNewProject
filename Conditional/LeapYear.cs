using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int y = 2020;

            if (y % 4 == 0)
            {
                Console.WriteLine($"{y} is Leap Year");
                
            }
            else
            {
                Console.WriteLine($"{y} is not Leap year");
                

            }
        }
       
    }





    
}
