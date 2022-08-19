using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Arrays
{
    class numbersorting
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 3, 2, 11, 0, 66, 3, 4, 1, 4 };
            for (int i = 0; i < s.Length;i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if(s[i]<s[j])
                    {
                        int temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;

                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", s));
            Console.ReadLine();
        }
       
    }
    class CharSorting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array");
            char[] ch = new char[10];
            for(int i=0;i<ch.Length;i++)
            {
                ch[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", ch));
            for(int i=0;i<ch.Length;i++)
            {
                for(int j=i+1;j<ch.Length;j++)
                {
                    if (ch[i] > ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }

                }

            }
            Console.WriteLine(string.Join(" ", ch));
            Console.ReadLine();

        }
    }
}
