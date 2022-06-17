using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Nested_Loop
{
    class Kaprakarno//eg.,9,45,7777  if  addition of digit which is squre of thst number is give number itself then it is kaprakar number

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int sq = n * n;
            int count = 0;

            Console.WriteLine("square of number" + sq);

           
            while(n > 0)
            {
                
                count++;
                
                n = n / 10;
                
            }
            
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }
            int division = sq / power;
            int remainder = sq % power;
            int sum = division + remainder;
            if(sum==temp)
            {
                Console.WriteLine("this is Kaprakar number");

            }
            else
            {
                Console.WriteLine("this is not kaprakar");
            }
            Console.ReadLine();
        }
    }
}
