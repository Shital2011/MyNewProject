using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class Electricity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Units");
            int u = Convert.ToInt32(Console.ReadLine());
            double surcharge, Total, A;
            


            if (u<=50)
            {
                A = (u * 0.50);
                surcharge = (0.20 * A);
                Total = (surcharge + A);

                Console.WriteLine("Total Electricity bill" + "=" + Total);
                Console.ReadLine();
            }
            if (u<=150)
            {
                A = 25 + (u - 50) * 0.75;
                surcharge = (0.20 * A);
                Total = (surcharge + A);

                Console.WriteLine("Total Electricity bill" + "=" + Total);
                Console.ReadLine();

            }
            if (u<=250)
            {
                A = 100 + (u - 150) * 1.20;
                surcharge = (0.20 * A);
                Total = (surcharge + A);

                Console.WriteLine("Total Electricity bill" + "=" + Total);
                Console.ReadLine();

            }
            else
            {
                A = 220 + (u - 250) * 1.50;
                surcharge = (0.20 * A);
                Total = (surcharge + A);

                Console.WriteLine("Total Electricity bill" + "=" + Total);
                Console.ReadLine();
            }
        
        
        
        
        }   
            

            
    }   

}
