using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Abstraction
{
    class Tworaay_3rdarray_with_unque
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = { 1, 6, 7, 2 };
            int[] c = new int[20];
            for (int s = 0; s < a1.Length; s++)
            {
                c[s] = a1[s];
            }

            int j = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                bool ispresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == a2[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    c[j] = a2[i];
                    j++;
                }
            }
            Console.WriteLine(string.Join(" ", a1));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", a2));
            for (int i=0;i<20;i++)
            {
                Console.WriteLine(c[i] + "  ");
            }
            Console.ReadLine();












        }
    }
}
