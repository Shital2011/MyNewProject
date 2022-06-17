using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class PositiveNegativeZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine(num + "is positive");
                Console.ReadLine();
            }
            if (num < 0)
            {
                Console.WriteLine(num + "is negative");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine(num + "is zero");
                Console.ReadLine();
            }
        }
    }



    class AlphabetsDigitSymbol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Character");
            char Ch = Convert.ToChar(Console.ReadLine());



            if (Ch >='a' && Ch<='z' || Ch>='A' && Ch<='Z')
            {
                Console.WriteLine("it is Albhabet");
                Console.ReadLine();

            }
            if(Ch>='0' && Ch<='9')
            {
                Console.WriteLine("it is digit ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It is symbol");
                Console.ReadLine();
            }



        }
    }








}
