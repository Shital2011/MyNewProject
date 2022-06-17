using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class SumThreedigitcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            
            
            

            if( n >= 100 && n<=999)
            {
                int l = n % 10;
                
              
                
                int Q = n / 100;
                int f = Q % 10;
               


                int sum = l +f;
                Console.WriteLine(sum +"is sum");
                Console.ReadLine();
                    
            }
             else
            {
                Console.WriteLine($"{n} is not 3 digit");
            }
        }
    }
}
