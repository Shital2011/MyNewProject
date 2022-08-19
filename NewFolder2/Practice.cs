using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.NewFolder2
{
    class Oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array");
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i] + "even");
                }
                else
                {

                    Console.WriteLine(a[i] + "odd");

                }
            }
            Console.ReadLine();
                
        }
       
    }
    class Palindromenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int copy = num;
            int reverse = 0;
            while(copy>0)
            {
                int r = copy % 10;
                reverse = (reverse * 10)+r;
                copy = copy / 10;
                
            }
            if(num==reverse)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
            Console.ReadLine();
        }
    }
    class Pattern //
    {
        static void Main(string[] args)
        {
            for(int i=7;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    class One_5While
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("//////////");
            int j = 7;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j <= 5);
            Console.ReadLine();
        }
        
    }
    class Prime
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            bool isprime = true;
            for(int i=2;i<p;i++)
            {
                if(p%i==0)
                {
                    isprime = false;
                }
            }
            if(isprime==true)
            {
                Console.WriteLine(" prime");
            }
            else
            {
                Console.WriteLine(" not prime");
            }
            Console.ReadLine();
        }
    }
    class reversearray
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 6, 7 };
            int[] rev = new int[arr.Length];

            int i = 0;
                for(int j=rev.Length-1;j>=0;j--)
                {
                    rev[j] = arr[i];
                  i++;
                }
            
            Console.WriteLine(string.Join(" ", rev));
            Console.ReadLine();

        }
    }
    class reversestring
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
           // string[] arr = s.Split(' ');
            string rev = "";

            for (int i=s.Length-1;i>=0;i--)//for(int i=arr.Length-1;i>=0;i--)
            {
                rev = rev + s[i];
            }
            //Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(rev);
            if (s==rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
                
            Console.ReadLine();
        }
        
    }
    class Reverse_word
    {

    }
    
    class Practice
    {

    }
}
