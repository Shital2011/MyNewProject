using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Nested_Loop
{
    class PrimeNum_1_10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            for (int i = 1; i < 11; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;

                    }
                }  
                if(count==0&&i!=1)
                {
                    sum = sum + i;
                }
                    
                        
                        
                        
                    
                    
                    
                        
                    
                
                

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
