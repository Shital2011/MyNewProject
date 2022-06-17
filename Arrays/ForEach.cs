using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Arrays
{
    class ForEach
    {
        static void Main(string[] args)
        {
            int[] r = new int[4];
            foreach(int x in r)
            {
                
                Console.WriteLine(x);
            }
            Console.WriteLine(string.Join(" ", r));
            Console.ReadLine();
        }
        
        
    }
    class CharArray
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'a', 'c', 's' };
            char[] ch1 = new char[4];
            for(int i=0;i<ch1.Length;i++)
            {
                ch1[i] = Convert.ToChar(Console.ReadLine());
            }

        }
    }

}
