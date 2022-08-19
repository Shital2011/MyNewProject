using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Written_test_string_24june
{
    class Q1_Duplicatewords
    {//1.	Write a  program to find the duplicate words and their number of occurrences in a string
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            
            for(int i=0;i<arr.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                { 
                    isvisited = true;
                    break;
                }
                if(isvisited==false)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }

                    }
                    if (count > 1)//duplicate
                    {
                        Console.WriteLine("duplicate value" + arr[i] + "  " + count);
                    }
                }
                if (count > 1)//duplicate
                {
                    Console.WriteLine("duplicate value" + arr[i] + "  " + count);
                }

            }
            Console.ReadLine();


        }
    }
    class Q2_Count//2.	Write a program to count the number of words in a string
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            char[] ch = s.ToCharArray();
            Console.WriteLine("no  of words= " + arr.Length+" no.  of cha="+ch.Length);
            Console.ReadLine();
        }
    }
    class Q3_anagram
    {//3.	Write a  program to check whether two strings are anagram or not?
        public static string sortchar(string str)
        {
            
            char[] arr = str.ToCharArray();
            string newstr = "";
            for (int i=0;i<arr.Length;i++)
            {
                for (int j = i + 1; j < arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        char temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        
                    }
                   
                    
                }
                newstr = newstr + arr[i];
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(newstr);
            return newstr;
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string newstring1 = Q3_anagram.sortchar(s1);
            string newstring2 = Q3_anagram.sortchar(s2);
            Console.WriteLine(newstring1 + " " + newstring2);
            if(newstring1==newstring2)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("Not anagram");
            }
            Console.ReadLine();
        }
    }
    class Q4_Desc
    {//4.	Create an array of 10 names sort in descending order
        static void Main(string[] args)
        {
            string[] arr = { "shital", "abh", "saury", "ketan", "koli", "de", "ew", "hi", "hello", "op" };
            int s = 1, s1 = 2;
            Console.WriteLine(s.CompareTo(s1));
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i].CompareTo(arr[j])==-1)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.ReadLine();
        }
    }
    class Q5_Total
    {//5.	Write a program to find total number of alphabets, digits or special character in a string.
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            int countalph = 0;
            int countdigit = 0;
            int countspcl = 0;
            for (int i = 0; i < ch.Length; i++) 
            {
                if((ch[i]>='a'&&ch[i]<='z')|| (ch[i] >= 'A' && ch[i] <= 'Z'))
                {
                    countalph++;
                }
                else if(char.IsDigit(ch[i]))
                {
                    countdigit++;
                }
               else if(ch[i]==' ') 
                {
                    continue;
                }
                else
                {
                    countspcl++;
                }
            }
            Console.WriteLine("count of digi" + countdigit + "count of alphabets" + countalph + "count of special" + countspcl);
            Console.ReadLine();
        }
    }
    class Q6_UppercaseTolower
    {//6.	Write a  program to convert uppercase string to lowercase
        public string chage(string str)
        {
            string Newstr = "";
            char[] arr = str.ToCharArray();
            for(int i=0;i<arr.Length;i++)
            {
               if(arr[i]>='A'&&arr[i]<='Z')
                //if(char.IsUpper(arr[i]))
               {
                    //arr[i] = char.ToLower(arr[i]);
                    arr[i] = (char)(arr[i] + 32);
               }
                Newstr = Newstr + arr[i];
            }
            Console.WriteLine(Newstr);

            return Newstr;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Q6_UppercaseTolower str = new Q6_UppercaseTolower();
            string upperstring=str.chage(s);
            Console.WriteLine(upperstring);
            Console.ReadLine();

        }
    }
    class Q7_reverse
    {/*7.	WAP to reverse the array itself, don’t print array in reverse – 
      * I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78] 
      * so your same array must be [78, 37, 29, 45, 90, 3] without using temporary 
      * array*/
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            int i = 0;
            int j = arr.Length - 1;
            while(i<j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            
            Console.WriteLine(string.Join(" ", arr));
            Console.ReadLine();

        }

        


    }
    class Q8_2arrayinone
    //WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 7, 2, 9 };
            int[] b = { 12, 23, 56, 7, 6, 76, 95 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
         
            int[] final = new int[20];
            int s = 0;
            for(int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j++;

            }
            for (int i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;

            }
            Console.WriteLine(".........");
            for(int i=0;i<c.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(c[i]==c[k])
                    {
                        isvisited = true;
                        break;
                    }
                   
                }
                if(isvisited==false)
                {
                    for(int p=i+1;p<c.Length; p++)
                    {
                        if(c[i]==c[p])
                        { 
                            count++; 
                        }
                        
                    }
                    if(count==1)
                    {
                        final[s] = c[i];
                        s++;
                    }
                    Console.WriteLine(final[s]);

                }
              
               
            }
            
            Console.ReadLine();



        }
    }
    class Q9_Asc
    {//9.	WAP sort array elements in ascending order
        static void Main(string[] args)
        {
            int[] arr = { 13, 9, 2, 12, 3, 00, 10, 11 };
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.ReadLine();
        }

    }
    class Q10_replace
    {//10.	WAP to replace all the 0’s with 1’s in your array. Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34].
       
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==0)
                {
                    a[i] = 1;
                }
            }
            Console.WriteLine(string.Join(" ", a));
            Console.ReadLine();
            
        }
        
    }
    class Q11_Replace
    {/*11.	WAP to replace all negative value with its immediate left elements square. Means arr[] = [12, 3,
     -19, 29, 5, -61, 44, 7, -9] Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].//12 3 9 29 5 25 44 7 49
     */
        static void Main(string[] args)
        {

            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            Console.WriteLine(string.Join(" ", arr));
            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    arr[i] = (arr[i - 1] * arr[i - 1]);
                   

                }
                else
                {
                    arr[i] = arr[i];
                    
                }
                
            }
            Console.WriteLine(string.Join(" ", arr));

            Console.ReadLine();
        }
    }
    class Q12_Chararray
    {//12.	WAP to find min character in character array. Means e.g. arr[] = [‘A’, ‘D’, ‘E’, ‘x’, ‘z’, ‘R’], so min character is ‘A’
        
        static void Main(string[] args)
        {
            char[] a = new char[6];
            Console.WriteLine("enter element of array");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = char.Parse(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ",a));
            char min = a[0];
            for(int i=0;i<a.Length;i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        min = a[j];
                    }
                }
                /*if (a[i] == min)
                {
                    Console.WriteLine(min);
                }*/
            }
            Console.WriteLine(min);
            Console.ReadLine();

        }
    }
    class Q13_Unique
    {//13.	WAP to print all unique elements in the array

        
        static void Main(string[] args)
        {
            char[] arr = { 'q', 'q', 'Q', '2', 's', 's', 's', '2', '1' };
            Console.WriteLine(string.Join(" ", arr));
            int size = 0;
            
            for (int i=0;i<arr.Length;i++)
            {
                int count = 1;
                bool isvisted = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(arr[i]==arr[k])
                    {
                        isvisted = true;
                        break;
                    }
                }
                if(isvisted==false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;

                        }
                        else
                            count = 1;

                    }
                    if (count == 1)
                    {
                        size++;
                        
                    }




                }
                

                Console.ReadLine();
            }
        }
    }
}
