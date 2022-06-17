using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class Prime
    {
        static void Main(string[] args)
        {


            
            for(int i=400 ;i>=300;i--)
            {
                bool Isprime = true;
                for (int n = 2; n < i; n++)
                {
                    if (i % n == 0)
                    {
                        Isprime = false;
                        break;
                    }
                    else
                    {
                        Isprime = true;
                    }
                    

                }
                if(Isprime==true)
                {
                    Console.WriteLine(i);
                }
                  
                   
                
                
                

                 
                  
                
                
            }
            Console.ReadLine();

                
            

        }
    }
    class noOfodd1_20
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=1;i<=20;i++)
            {
                if(i%2==1)
                {
                    count++;

                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
        
    }
    class sumEven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

    }
    class fibo
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;

            int n = 10;
            int i = 0;
            for (i = 1; i <= n; i++)
            {

                int sum = n1 + n2;
               
                n1 = n2;
                n2 = sum;
                Console.WriteLine(sum);

                Console.ReadLine();

            }

        }
    }
    class odd15_30
    {
        static void Main(string[] args)
        {
            for (int i = 15; i <= 30; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }   
    class n25_15
    {
        static void Main(string[] args)
        {
            for(int i=25;i>=15;i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    class n350_400
    {
        static void Main(string[] args)
        {
            int i;
            for ( i = 350; i <= 400; i++) ;
            Console.WriteLine(i);
                
        }

    }

    
}
