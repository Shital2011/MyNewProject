using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Nested_Loop
{
    class Harshad_Niven
    {//if number is divisible by sum of digit then it is harshad or niven
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int sum = 0;
            while(temp>0)
            {
                int rem = temp % 10;
                sum = sum + rem;
                temp = temp / 10;
            }
            if(n%sum==0)
            {
                Console.WriteLine("Harshad number");

            }
            else
            {
                Console.WriteLine("Not Harshad number");

            }
            Console.ReadLine();
        }
                
    }
}
