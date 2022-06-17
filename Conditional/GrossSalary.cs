using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class GrossSalary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary");
            int BS = Convert.ToInt32(Console.ReadLine());
            double HRA, DA, GS;
            
            if (BS<=10000)
            {

                HRA = (BS * 0.20);
                Console.WriteLine("HRA"+"=" +HRA);
                DA = (BS * 0.80);
                Console.WriteLine("DA" + "=" + DA);
                GS = (BS + HRA + DA);
                Console.WriteLine("Gross salary is" + " " + GS);
                Console.ReadLine();
            }
            if(BS<=20000)
            {
                HRA = (BS * 0.25);
                Console.WriteLine("HRA" + "=" + HRA);
                DA = (BS * 0.90);
                Console.WriteLine("DA" + "=" + DA);
                GS = (BS + HRA + DA);
                Console.WriteLine("Gross Salary is" + " " + GS);
                Console.ReadLine();
            }
            else
            {
                HRA = (BS * 0.30);
                Console.WriteLine("HRA" + "=" + HRA);
                DA = (BS * 0.95);
                Console.WriteLine("DA" + "=" + DA);
                GS = (BS + HRA + DA);
                Console.WriteLine("Gross Salary is" + " " + GS);
                Console.ReadLine();
            }
            
                
            
        
        
        
        }   


    }
}
