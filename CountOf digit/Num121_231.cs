using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class Num121_231
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter initial num");
            int num = Convert.ToInt32(Console.ReadLine());
            int j;


            for (j = num; j<=229;j--)


            {


                if (j%2==0)
                {
                    Console.WriteLine(j);

                    Console.ReadLine();
            
                }

                
            }
        }   
    }
}
