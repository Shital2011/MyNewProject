using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Arrays
{
    class Frequencyofelement
    {
        static void Main(string[] args)
        {//frequency of each element
            int[] a = { 4, 1, 3, 2, 1, 1, 2, 4 };
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited =false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    if (a[i]==a[j])
                    {
                            count++;
                    }
                    Console.WriteLine("count of each="+a[i] + "  " + count);
                    if(count==1)//unique
                    {
                        Console.WriteLine("unique value"+a[i] + "  " + count);
                    }
                    if (count>1)//duplicate
                    {
                        Console.WriteLine("duplicate value"+a[i] + "  " + count);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
    
}
