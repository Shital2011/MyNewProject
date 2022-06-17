using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class Vowel_consonent
    {
        static void Main(string[] args)
        {
            char c = Console.ReadLine()[0];
            if (c=='a' || c=='e' || c=='i' || c=='o' || c =='u' || c== 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("vowel");

            }
            else
            {
                Console.WriteLine("Consonent");

            }
            Console.ReadLine();
        }   
    }
}
