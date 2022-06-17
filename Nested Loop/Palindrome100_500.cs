using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Nested_Loop
{
    class Palindrome100_500
    {
        static void Main(string[] args)
        {
            
            for(int i=100;i<=500;i++)
            {
                int j = i;
                int rev = 0;
                while (j>0)
                {
                    int rem = j % 10;
                    rev = (rev * 10) + rem;
                    j = j / 10;

                    
                }
                if(rev==i)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;


                }
                Console.ReadLine();
            }   

        }
    }
}
