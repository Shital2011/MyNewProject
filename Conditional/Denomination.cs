using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class Denomination
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter amount");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int n2000 = n / 2000;
            n = n % 2000;
            Console.WriteLine("num of notes of 2000 is" + n2000);
            int n500 = n / 500;
            n = n % 500;
            Console.WriteLine("num of notes of 500 is" + n500);

            int n200= n / 200;
            n = n % 200;
            Console.WriteLine("num of notes of 200 is" + n200);
            int n100 = n / 100;
            n = n % 100;
            Console.WriteLine("num of notes of 100" + n100);
            int n50 = n / 50;
            n = n % 50;
            Console.WriteLine("num of notes of50is" + n50);
            int n20 = n / 20;
            n = n % 20;
            Console.WriteLine("num of notes of 20 is" + n20);
            int n10 = n / 10;
            n = n % 10;
            Console.WriteLine("num of notes of10is" + n10);
            int n1 = n / 1;
            Console.WriteLine("Num of coin 1 is" + n1);
            Console.ReadLine();









        }

    }
}
