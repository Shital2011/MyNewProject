using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Arrays
{//1.Write a code for sum of prime no.in array
    class Sum_prime_inarray
    {
        public int Prime_sum(int [] arr)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                for(int j=2;j<i;j++)
                {
                    if (i%j==0)
                    {
                        count++;
                        break;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                if(count==0)
                {
                    Console.WriteLine("prime number=" + i);
                    sum = sum + i;
                }

            }

                
            return sum;
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements of array");
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = int.Parse(Console.ReadLine());
                

            }
            Console.WriteLine(string.Join(" ",a));

            Sum_prime_inarray m = new Sum_prime_inarray();
            int sum = m.Prime_sum(a);
            Console.WriteLine("sum of prime number is="+sum);
            Console.ReadLine();
        }
    }
    class Alternative
    {//2.to print alternative element from array
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements of array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());


            }
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }


    }
    class Max
    {//3.find out max element from int type of array
        public int max(int[] arr)
        {
            int maxvalue = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>maxvalue)
                {
                    maxvalue = arr[i];
                   
                }
            }

            return maxvalue;
        }
        static void Main(string[] args)
        {
            int[] n = new int[4];
            for (int i=0;i<n.Length;i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ", n));
            Max m = new Max();
            int maxvalue= m.max(n);
            Console.WriteLine("max value=" + maxvalue);
            Console.ReadLine();
        }
    }
    class Min
    {//4.find min elememnt from array 
        public void Minv()
        {

        }

        static void Main(string[] args)
        {
            char[] array = new char[4];
            Console.WriteLine("enter character of array");
                for (int i = 0; i < array.Length; i++)
                {
                 array[i] = Convert.ToChar(Console.ReadLine());

                }
            char min = array[0];
                for(int j=0;j<array.Length;j++)
                {
                   if (min > array[j])
                   {
                    min = array[j];
                   }
                }
            Console.WriteLine("min= " + min);
            Console.ReadLine();

        }
    }
    class TwoarrayInOne
    {//5.write code to merge two array in 3rd array
        static void Main(string[] args)
        {
            
            int[] a1 = new int[5];
            Console.WriteLine("enter elements for first array");
            for (int i = 0; i < a1.Length; i++)
            {
               
                a1[i] = int.Parse(Console.ReadLine());
                


            }
            Console.WriteLine("first arry=  " + string.Join(" ", a1));
            int[] a2 = new int[4];
            Console.WriteLine("enter elements for Second array");
            for (int j = 0; j < a2.Length; j++)
            {
                a2[j] = int.Parse(Console.ReadLine());
              

            }
            Console.WriteLine("second arry=  " + string.Join(" ", a2));


            int[] a = new int[(a1.Length + a2.Length)];
            int pos = 0;
            int position = 0;
            for( int k = 0; k < a.Length;k++)
            {
                if (k < a1.Length)
                {
                    a[k] = a1[pos];
                    pos++;
                }
                
                
                else


                {
                    a[k] = a2[position];
                    position++;
                }
                
                
            }
            Console.WriteLine(string.Join(" ", a));
            Console.ReadLine();








        }
       

    }
}
