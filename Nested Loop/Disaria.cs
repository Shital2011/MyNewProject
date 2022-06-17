using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Nested_Loop
{
    class Disarium//eg.135,175;if sum of its digit powered by with their respective postiton is equal to the number itself
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int final = n;
            int count = 0;
            int sum = 0;
            while (n > 0)
            {
                
                count++;
                n = n / 10;
               
                
            }
            Console.WriteLine("num of digit"+count);
            
            while (temp > 0) 
            {
                int digit = temp % 10;
                int power = 1;
                for (int j = 1; j <= count; j++)
                {
                    power = power * digit;
                }
                //int power = (int)(Math.Pow(digit, count));
                //Console.WriteLine(power);
                sum = sum + power;
                count--;
                
                temp = temp / 10;

            }
            Console.WriteLine("sum" + sum);
            if (sum == final)
            {
                Console.WriteLine("This disarium number");

            }
            else
            {
                Console.WriteLine("This is not");
            }
            Console.ReadLine();

        }
    }
}
