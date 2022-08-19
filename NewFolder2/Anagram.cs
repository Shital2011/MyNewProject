using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.NewFolder2
{
    class Anagram
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();


            if (s1.Length == s2.Length)
            {
                char[] a1 = s1.ToCharArray();
                foreach (char ch in a1)
                {

                    int idx = s2.IndexOf('z');
                    if (idx != -1)
                    {
                        s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);

                    }
                }

                if (s2.Length == 0)
                    Console.WriteLine("Anagram");
                else
                    Console.WriteLine("Not");

            }
            else
                Console.WriteLine("Not anagaram");

            Console.ReadLine();

        }
    }
    class anagram1

    {
        public string Sorting(string str)
        {
            string newstr = "";
            char[] c = str.ToCharArray();
            for(int i=0;i<c.Length;i++)
            {
                for (int j = i + 1; j < c.Length; j++)
                {
                    if(c[i]>c[j])
                    {
                        char Temp = c[i];
                        c[i] = c[j];
                        c[j] = Temp;
                       

                    }
                    
                    

                }
                newstr = newstr + c[i];


            }
            
            
            return newstr;
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            
           
            anagram1 s = new anagram1();
            string ss1 = s.Sorting(s1);
            string ss2 = s.Sorting(s2);
            if(ss1==ss2)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("Not");
            }
            Console.ReadLine();



        }
    }
    class anagram2
    {
        public string anagramcheck(string input1,string input2)
        {
            char[] a = input1.ToCharArray();
            char[] a1 = input2.ToCharArray();
            Array.Sort(a);
            Array.Sort(a1);
            string s1 = new string(a);
            string s2 = new string(a1);
            if(s1.CompareTo(s2)==0)
            {
                return "yes";
            }
            else
            {
                return "no";
            }
            throw new NotImplementedException("Method anagramcheck(string input1,string input2)");
        }

    }
    
    class largest_subarray_length
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int j;
            int max = 0;
            int zero, ones = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }

            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
    class SubArrY
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = 0;
            int zero = 0;
            int ones = 0;                     
            for(int i=0;i<arr.Length;i++)
            {
                zero = 0;
                ones = 0;
                for(int j=i;j<arr.Length;j++)
                {
                    
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if(zero==ones)
                    {
                        max = max > (j - i + 1) ? max : (j - i + 1);
                    }
                }
                
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
    class Cuckoo
    {
        int coo(int s)
        {
            if (s == 1)
            {
                s = 0;
            }
            if (s == 2)
            {
                s = 1;
            }

            return s;
        }
        static void Main(string[] args)
        {


            Cuckoo ck = new Cuckoo();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
           // int cu1 = 0;
           // int cu2 = 1;

            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.WriteLine("1");

            }
            else if (n > 2)
            {
                c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;

                Console.WriteLine(c);
            }
            Console.WriteLine("...................................................................");
           

            Console.ReadLine();
        }
    }
    class ANAGRAM_Final
    {
        public static void check(string str1,string str2)
        {
            if(str1.Length==str2.Length)
            {
                string s1 = str1.ToLower();
                string s2 = str2.ToLower();
                char[] ch1 = s1.ToCharArray();
                char[] ch2 = s2.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string st1 = new string(ch1);
                string st2 = new string(ch2);
                if(st1==st2)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            ANAGRAM_Final.check(s1,s2);

            Console.ReadLine();

        }
        
    }
    class CoPrime
    {
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int gcd = 0;
            int count = 0;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i%j==0&&n%j==0)
                    {
                        gcd = j;
                    }
                }
                if(gcd==1)
                {
                    count++;
                }
            }
            Console.WriteLine("num of Coprime= " + count);
            Console.ReadLine();
        }

    }
    class Arthmatic
    {
        
        static void Main(string[] args)
        {
           
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int d = a3 - a2;
            for(int i = 4;i <= n;i++)
            {
                a3 = a3 + d;
                Console.WriteLine(a3);
            }
            Console.WriteLine(a3);
            Console.ReadLine();
        }
    }
    class cukkoo
    {
        int coo(int n)
        {
            if(n==1)
            {
                n = 0;
            }
            else if(n==2)
            {
                n = 1;
            }
            return n;

        }
        static void Main(string[] args)
        {
            cukkoo ck = new cukkoo();
            int c = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<=n;i++)
            {
                if(n==1)
                {
                    Console.WriteLine("0");
                }
                else if(n==2)
                {
                    Console.WriteLine("1");
                }
                else if(n>2)
                {
                    c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;
                }
               
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
    class Pattern1
    {
      static void Main(string[] args)
        {
            int c = 96;
            for(int i=1;i<=4;i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write((char)(j + 96));
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
      }

    }
    class pr
    {
        static void Main(string[] args)
        {
            int[][]a= new int[2][];
            a[0] = new int[4] { 6, 1, 4, 3 };
            a[1] = new int[3] { 9,2,7 };
            Console.WriteLine(a[1].GetUpperBound(0));
            Console.ReadLine();

        }
    }
    public class av
    {
        
        void display(int i) { Console.WriteLine("s"); }


            
        
    }
    public class b:av
    {
        void display() { Console.WriteLine("n"); }
        static void Main(string[] args)
        {
            b s = new b();
         
        }
    }

    
    
}


