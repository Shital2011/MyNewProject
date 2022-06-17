using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class GrossSalary
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter Basic Salary");
            int BS = int.Parse(Console.ReadLine());
            double HRA, DA, GS;
            
           
           if(BS<=10000)
            {
                HRA = BS * 0.20;
                DA = BS * 0.80;
                GS = HRA + DA + BS;
            }
        }


    }
}
