using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ExceptionHandling
{
    class NullException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("Enter number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division: " + a / b);
                try
                {
                    Console.WriteLine("Enter Age");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch(NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Try end");
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}
