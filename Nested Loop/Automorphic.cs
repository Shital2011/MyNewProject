using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Nested_Loop
{
    class Automorphic//if last digits of sq of number is same of that number then it is automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");

            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            num = temp;
            int sq = num * num;
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }
            Console.WriteLine(sq+"  "+power);
            int end = sq % power;

            Console.WriteLine(sq + " " + "End" + end);
            if (end == num)
            {
                Console.WriteLine("automorphic");
            }
            else
            {
                Console.WriteLine("Not automorhpic");
            }
            Console.ReadLine();

        }
    }
}
