using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.BranchingSt
{
    class Calculator
    {
        static void Main (string[] args)
        {
            Console.WriteLine(" *\n +\n -\n / \n");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());



            switch (ch)
            {
                case '*':
                    Console.WriteLine("Result"+" "+num1 * num2);
                    Console.ReadLine();
                    break;
                case '-':
                    Console.WriteLine("Result" + " " + (num1 - num2));
                    Console.ReadLine();
                    break;

                case '+':
                    Console.WriteLine("Result" + " " + num1 + num2);
                    Console.ReadLine();
                    break;
                case '/':
                    Console.WriteLine("Result" + " " + num1 / num2);
                    Console.ReadLine();
                    break;
            }

        }
    }
}
