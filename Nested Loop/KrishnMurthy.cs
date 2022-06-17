using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Nested_Loop
{
    class KrishnMurthy
    {//A number said to be kirishnamurthy if the factorial sum of all its digit is equal yo that number
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int c = n;
            int fact;
            int sum = 0;
            
            while(n>0)
            {
                
                int f = n % 10;
                fact = 1;
                for (int i = 1; i <= f; i++)
                {
                    fact = fact * i;
                    
                }
                sum = sum + fact;


                n = n / 10;
               
            }
            Console.WriteLine(sum);
            if (c == sum) 
            {
                Console.WriteLine("this is Krishmurthy number");
            }
            else
            {
                Console.WriteLine("this is not Krishmurthy number");
            }
            Console.ReadLine();
            
        }
    }
}
