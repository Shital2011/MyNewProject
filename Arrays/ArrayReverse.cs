using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Arrays
{
    class ArrayReverse
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 2, 3 };
            Console.WriteLine(string .Join("-",a));
            
            for (int i=a.Length-1;i>=0;i--)
            {
                Console.Write(a[i]+" ");
            }
            Console.ReadLine();
        }
    }
    class EvenArray
    {
        static void Main(string[] args)
            
        {
            int[] a = { 5, 7, 2, 3, 6 };
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(string.Join(" ", a[i]));
                    
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
