using System.Text;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

namespace MyNewProject.Written_Test_14Aug
{   /*1.	An IMEI number/ International Mobile Station Equipment Identity is a 15 digit number and it is said to be IMEI number if and only if the sum of the number is exactly divisible by 10.	 [1M]

The IMEI (15 decimal digits: 14 digits plus a check digit) includes information on the origin, model, and serial number of the device.

The IMEI number is used by a GSM network to identify valid devices and therefore can be used for stopping a stolen phone from accessing that network

The IMEI is validated in following steps:
1.	Starting from the rightmost digit, double the value of every second digit (e.g., 7 becomes 14).
2.	If doubling of a number results in a two digits number i.e greater than 9(e.g., 7 × 2 = 14), then add the digits of the product (e.g., 14: 1 + 4 = 5), to get a single digit number.
3.	Now take the sum of all the digits.
4.	Check if the sum is divisible by 10 i.e.(total modulo 10 is equal to 0) then the IMEI number is valid; else it is not valid.


Input IMEI : 490154203237518

 
Output : Since, 60 is divisible by 10, hence the given IMEI number is Valid.
*/
    class Q_01
    {
        static int SumDig(int n)
        {
            int a = 0;
            while(n>0)
            {
                a = a + n % 10;
                n = n / 10;
                

            }
            return a;
        }
        static bool isValidIMEI(long n)
        {
            string s = n.ToString();
            int len = s.Length;
            if (len != 15)
                return false;
            int sum = 0;
            for(int i=len;i>=1;i--)
            {
                int d = (int)(n % 10);
                if(i%2==0)
                d = 2 * d;
                sum = sum + SumDig(d);
                n = n / 10;

            }
            return (sum % 10 == 0);
            

        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            if (isValidIMEI(n) == true)
                Console.WriteLine("Valid IMEI code");
            else
            Console.WriteLine("Invalid IMEI code");
            Console.ReadLine();
        }
    }
    class Q_02
    //2.	Write a program to merge two sorted array of number such that
    //new array is sorted array and there should be no duplicate in new array.[1M]
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of two arrays");
            int size1 = int.Parse(Console.ReadLine());
            int size2 = int.Parse(Console.ReadLine());
            int[] a1 = new int[size1];
            int[] a2 = new int[size2];
            Console.WriteLine("Enter num in first arrays");
            for (int i=0;i<a1.Length;i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(string.Join(" ", a1));
            Console.WriteLine("Enter num in second arrays");
            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(string.Join(" ", a2));

            int[] merged = new int[size1 + size2];
            int j = 0; int k = 0;
            for(int i=0;i<merged.Length;i++)
            {   if (i < a1.Length)
                {
                    merged[i] = a1[j];
                    j++;
                }
                else
                {
                    merged[i] = a2[k];
                    k++;
                }

            }
            Array.Sort(merged);
            Console.Write(string.Join(" ", merged));
            Console.WriteLine();
           

            HashSet<int> d = new HashSet<int>();
            
                for (int i = 0; i < merged.Length; i++)
                    d.Add(merged[i]);
            Console.Write(string.Join(" ", d));
            Console.ReadLine();
            


        }

    }
    class Society_members
    {
        int member_id;
        int Wing_flat_no;
        string name;
        public Society_members(int member_id,int Wing_flat_no,string name)
        {
            this.member_id = member_id;
            this.Wing_flat_no=Wing_flat_no;
            this.name = name;
        }
        public int Member_id
        {
            get{ return member_id; }
            set{ member_id = value; }
        }
        public int wing_flat_no
        {
            get { return Wing_flat_no; }
            set { Wing_flat_no = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    class Q_3
    {
        //3.Assume that there is already  list of members of Society Member{memberid,Wing_flatNo,name}. Write a program which creates Dictionary where
        //key is Wing_FlatNo and value is List of all  names of family members [1M]
        static void Main(string[] args)
        {
            List<Society_members> ss = new List<Society_members>();
            ss.Add(new Society_members(1, 21, "Shital"));
            ss.Add(new Society_members(2, 22, "Sanket"));
            ss.Add(new Society_members(3, 23, "Saurya"));
            ss.Add(new Society_members(4, 24, "bally"));
            foreach(var a in ss)
            {
                Console.WriteLine(a.Name, a.wing_flat_no, a.Member_id);
            }
            
            Dictionary<int, string> dc = new Dictionary<int, string>();
           foreach(var b in ss)
            {
                dc.Add(b.wing_flat_no, b.Name);
            }
            foreach(KeyValuePair<int,string> e in dc)
            {
                Console.WriteLine(e.Key + "==>" + e.Value);
            }
            Console.ReadLine();

        }
        
       
         

    }
    class Q_4
    {//4.	Given two LinkedList, we need to combine two LinkedList  in such a way that the combined aList has alternate elements of both. If one list has extra element, then these elements are appended at the end of the combined list.[1M]

        //Input : list1 = {1, 2, 3, 4, 5, 6}
        //List2 = {11, 22, 33, 44}
        //List3: {1, 11, 2, 22, 3, 33, 4, 44, 5, 6}
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(1);
            l1.AddLast(2);
            l1.AddLast(3);
            l1.AddLast(4);
            l1.AddLast(5);
            l1.AddLast(6);
         
            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddLast(11);
            l2.AddLast(22);
            l2.AddLast(33);
            l2.AddLast(44);

           
            LinkedList<int> l = new LinkedList<int>();
            int k = 0;
            while (l.Count < l1.Count + l2.Count)
            {
                if(k<l1.Count && k<l2.Count)
                {
                    l.AddLast(l1.ElementAt(k));
                    l.AddLast(l2.ElementAt(k));
                    k++;
                }
                else if(k<l1.Count)
                {
                    l.AddLast(l1.ElementAt(k));
                    k++;

                }
                else
                {
                    l.AddLast(l2.ElementAt(k));
                    k++;
                }
            }
            foreach(int i in l)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
            


        }

    }
    class Q_5
    {
        static void Main(string[] args)
        {/*5.	Reverse middle words of a string [1M]
Given a string str, print reverse all words except the first and last words.

Examples:
Input  : Hi how are you students
Output  : Hi woh era uoy students
Input : I am fine
Output : I ma fine
*/
            string s = Console.ReadLine();
            string[] ar = s.Split(' ');
            string newstring = "";
            for(int i=1;i<ar.Length-1;i++)
            {
                string word = ar[i];
                string revword = " ";
                
                for(int j= word.Length-1; j>=0;j--)
                {
                    revword = revword + word[j];
                }
                newstring = (newstring + revword);
            }
            string final = ar[0]+" " + newstring +" " +ar[ar.Length - 1];
            Console.WriteLine(final);
            Console.ReadLine();
        }
    }
    class Q_06
    {
        //6.	WAP to  Reverse a linked list using Stack. [1M]

        static void Main(string[] args)
        {
            LinkedList<int> l = new LinkedList<int>();
            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddLast(4);
            l.AddLast(5);
            foreach(int e in l)
            {
                Console.Write(e);
            }
            Console.WriteLine();
            Stack<int> st = new Stack<int>();

            foreach(int s in l)
            {
                st.Push(s);
            }
            foreach (int e in st)
            {
                Console.Write(e);
            }
            Console.ReadLine();
        }
    }
    class Mobile_no
    {
        static void Main(string[] args)
        {
            long mb = long.Parse(Console.ReadLine());
            string s = mb.ToString();
            char[] arr = s.ToCharArray();
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            

            
            foreach(char c in arr)
            {
                
                if(d1.ContainsKey(c))
                {
                    int oldval = d1[c];
                    d1[c] = oldval + 1;

                }
                else
                {
                    d1.Add(c, 1);
                }
            }
            foreach(KeyValuePair<char,int> kv in d1)
            {
                Console.WriteLine(kv.Key + "==>"+kv.Value);
            }
            Console.ReadLine();
        }
    }
    class Q_7
    {//7.	WAP to find out frequency of each digit in given mobile number using only single loop. [1M]
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string n = num.ToString();
            char[] a = n.ToCharArray();
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                           if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("count of each=" + a[i] + "  " + count);
                }
            }
            Console.ReadLine();
        }
    }
    class Q_8
    {/*8.WAP to accept a string and make following changes[1M]
•	Shift each letter right by two step eg A->C ,Y->A,Z->B
•	Each digit by next higher digit.
•	Space by underscore*/
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToUpper();
            int step = 2;
            int newchar = 0;
            foreach(char ch in s)
            {
                if (char.IsLetter(ch))
                {
                    newchar = ch + step;
                    if (newchar > 90)
                        newchar = newchar - 26;
                }
                else if (char.IsDigit(ch))
                {
                    newchar = ch;
                    newchar++;
                }
                else if (char.IsWhiteSpace(ch))
                {
                    newchar = ch;
                    newchar = '_';
                }
                else
                {
                    newchar = ch;
                }
                Console.Write((char)newchar);


            }

            Console.ReadLine();

        }
    }
    class Q_9
    {
        //9.	WAP to draw the following pattern using . Note: Input is an odd number: [1M]*
        /*12345
          ABCD
          123
          AB
          1
          AB
          123
          ABCD
          12345
         */
        static void Main(string[] args)
        {
            
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    if (i % 2 == 1)
                        Console.Write(j);
                    else
                        Console.Write((char)(64 + j));
                }
                Console.WriteLine();
            }
            for (int i = 2; i <=5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                        Console.Write(j);
                    else
                        Console.Write((char)(64 + j));
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        

    }
    class InValidBinaryNumberException:SystemException
    {
        public InValidBinaryNumberException(string msg):base(msg)
        {

        }
    }
    class Q10
    {
        //10.	WAP to accept a number and check whether it is binary or not.If notthrow custom exceptionInvalidBinaryNumber.[1M]
        static void Main(string[] args)
        {
            int bin = int.Parse(Console.ReadLine());
           bool isbinary = true;
            while(bin>0)
            {
                int digit = bin % 10;
                if(digit>1)
                {
                    throw new InValidBinaryNumberException("Binary number should hav 0 or 1");
                }
                bin = bin / 10;
            }
            Console.ReadLine();
        }
        
    }
    class pattern_s
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (i % 2 == 0)
                        Console.Write(j);
                    else
                        Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
