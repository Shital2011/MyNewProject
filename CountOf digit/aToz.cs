using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class aToz
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
    class OnetoN
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;

            Console.WriteLine("enter no.");
            int n = Convert.ToInt32(Console.ReadLine());
            

            for ( i = 2; i <= n; i+=2) ;
            {
                
                
                    sum =sum+i;
                
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            

                    
                    
                  
                    


                
               
               
                



                   
                   
            
        }
    }

                
            


            


        
    
}
