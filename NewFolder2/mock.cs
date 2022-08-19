using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.NewFolder2
{
    class Cukoos
    {
        
          static public int coo(int s)
          {
            if(s==1)
            {
                s = 0;
            }
            else if(s==2)
            {
                s = 1;
            }
            return s;
          }
          static public void cuk(int n)
          {
            int c = 0;
            for(int i=0;i<=n;i++)
            {
                if (n == 1)
                {
                    Console.WriteLine("0");
                }
                else if (n == 2)
                {
                    Console.WriteLine("01");
                }
                else if (n > 2)
                {
                    c = 1 * Cukoos.coo(n - 1) + 2 * Cukoos.coo(n - 2) + 3 * 1;
                    
                }
            }
            Console.WriteLine(c);

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Cukoos.cuk(num);
            Console.ReadLine();
        }
        
        
        
    }
    class Lrgest_subarray
    {
        public static int LengthArray(int n, int[] arr)
        {

            int max = 0;
            int zeros = 0;
            int ones = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zeros = 0;
                ones = 0;
                for (int j = i ; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zeros++;
                    else 
                        ones++;

                    if (zeros == ones)
                    {
                        max = max > j - i + 1 ? max : j - i + 1;
                    }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = Lrgest_subarray.LengthArray(size, arr);
            Console.WriteLine(max);
            Console.ReadLine();

        }
    }
    class AP
    {
        static public int Ap(int b2, int b3, int num)
        {
            int d = b3 - b2;
            for(int i=4;i<=num;i++)
            {
                b3 = b3 + d;
            }
            return b3;
        }
        static void Main(string[] args)
        {
            int a2 = int.Parse(Console.ReadLine());
            int a3= int.Parse(Console.ReadLine());
            int n= int.Parse(Console.ReadLine());
            int l = AP.Ap(a2, a3, n);
            Console.WriteLine(l);
            Console.ReadLine();
        }
    }
    class CoPrime2
    {
        public static int find(int n)
        {
            int c = 0;
            int gcd = 0;
            for(int i=1;i<=n;i++)
            {
                for (int j = 1; j <= i;j++)
                {
                    if(i%j==0&&n%j==0)
                    {
                        gcd = j;
                    }
                }
                if(gcd==1)
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int c = CoPrime2.find(num);
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
    class CheckCoPrime
    {
        public static int gcd(int a,int b)
        {
            if (a == 0 || b == 0)
                return 0;
            if (a == b)
                return a;
            if (a > b)
                return gcd(a - b, b);
            return gcd(a, b - a);
        }
        public static void coprime(int a,int b)
        {
            if (gcd(a, b) == 1)
                Console.WriteLine("CoPrime");
            else
                Console.WriteLine("not");
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            CheckCoPrime.coprime(a, b);
            Console.ReadLine();
        }
    }
    class Angram5
    {
        public static void checkA(string str1,string str2)
        {
            if(str1.Length==str2.Length)
            {
                string s1 = str1.ToLower();
                string s2 = str2.ToLower();
                char[] a1 = s1.ToCharArray();
                char[] a2 = s2.ToCharArray();
                Array.Sort(a1);
                Array.Sort(a2);
                string st1 = new string(a1);
                string st2 = new string(a2);
                if(st1==st2)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no");
            }

           
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Angram5.checkA(s1, s2);
            Console.ReadLine();
        }
    }
    
    
    class prime
    {
        static public void rev(string s)
        {
            string[] c = s.Split(' ');
            string rev = "";
            for(int i=0;i<c.Length;i++)
            {
                string word = c[i];
                string revword = "";
                for(int j=word.Length-1;j>=0;j--)
                {
                    revword = revword + word[j];
                }
                rev = rev +" "+ revword;
            }
            Console.WriteLine(rev);
        }
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            prime.rev(s);
            Console.ReadLine();

        }
    }
        
}
