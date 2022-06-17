using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class Odd500
    {
        static void Main(string[] args)
        {
            for (int i = 500; i <= 600; i++)
            {
                if (i % 2 == 1)

                    Console.WriteLine(i);

            }



        }
    }
    class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine(n + "*" + i + " =" + n * i);
            }
        }

    }
    class factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
    class colour
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;i<=50;i++)
            {
                if(i%3==0&& i%5==0)
                {
                    Console.WriteLine("Red");
                }
                else if (i %5 == 0 )
                {
                    Console.WriteLine("Blue");
                }
                else if( i % 3 == 0)
                {
                    Console.WriteLine("REDBlue");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadLine();
        }
    }


}