using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Strings
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            //char[] ch = str.ToCharArray();
            string reverse = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }

    }
    //1.Write a code for count of word

    class CountOfword
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            int count = 0;
            string[] n = s.Split(' ');
            for(int i=0;i<n.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        } 
    }
 //2.write a code to reverse words from the string except first and last word
   class ReverseWordExcept
    {
        public static string ReverseShow(string str)
        {
            string[] s = str.Split();
            string reverse = " ";
            for(int i=0;i<s.Length;i++)
            {//for(int=str.Length-1;i>=0;i--),,,for reverse string
                string word = s[i];
                string reverseword = "";
                for(int j=word.Length-1;j>=0;j--)//for reverse for(int j=word.Length-1;j>=0;j--)
                {
                    reverseword = reverseword + word[j];
                }
                reverse = reverse + " "+ reverseword;
            }
            
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            string reversenew = ReverseShow(s);
            Console.WriteLine(reversenew);
            Console.ReadLine();
        }
    }
 //3.write c code to display in string in pattern from
 class Patternstring
    {
        public void show(string str)
        {
            string[] p = str.Split(' ');
            for(int i=0;i<p.Length;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write(p[j]+" ");
                }
                Console.WriteLine();
            }
        
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Patternstring st = new Patternstring();
            st.show(s);
            Console.ReadLine();
        }
    }
 //4.avg of digit present in string
    class DigitPresnt
  {
        public static int Avgshow(string str)
        {
            int sum = 0;
            int avg = 0;
            int count = 0;
            
            
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='0'&&str[i]<='9')
                //if(Char.IsDigit(str[i]))
                {
                    sum = sum + (int)Char.GetNumericValue(str[i]);
                    count++;
                    
                }
                
            }
            avg = sum / count;
            Console.WriteLine("sum= "+sum + " count+ " + count);
            Console.WriteLine("avg= "+avg);
            return avg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();

            int avg = DigitPresnt.Avgshow(s);
            Console.ReadLine();
        }
    }
    class ToggleCase
    {
        public static string ByusingMethod(string str)
        {
            string toggle = "";
            for(int i=0;i<str.Length;i++)
            {
                if(char.IsUpper(str[i]))
                {
                    toggle = toggle + char.ToLower(str[i]);
                }
                else if(char.IsLower(str[i]))
                {
                    toggle = toggle + char.ToUpper(str[i]);
                }
                else
                {
                    toggle = toggle + str[i];
                }
            }

            return toggle;
        }
        public static string Show(string str)
        {
            string toggle = "";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='a'&&str[i]<='z')
                {
                    toggle = toggle + ((char)(str[i] - 32));
                }
                else if(str[i]>='A'&&str[i]<='Z')
                {
                    toggle = toggle + ((char)(str[i] + 32));
                }
                else
                {
                    toggle = toggle + str[i];
                }
            }
            return toggle;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter strigng");
            string s = Console.ReadLine();
            Console.WriteLine(Show(s));
            Console.WriteLine(ByusingMethod(s));
            Console.ReadLine();
        }
    }
    class DebugDemo
    {
        static void Main(string[] args)
        {
            int count=0;
            for(int i =0;i<=10;i++)
            {
                if(i%2==0)
                {
                    count++;                }
                else
                {
                    continue;
                }
            }
        }
    }
    class Palindrome
    {//write code to check string is plaindrom or noy
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();

            string reverse = "";
            
            for(int i=s.Length-1;i>=0;i--)
            {
                reverse = reverse + s[i];
            }
            Console.WriteLine(string.Join(reverse, " "));
            if (s == reverse)
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
    class StringarraywithDigit
    {//create string type of array array conatinsA+1,B+4,V+1 take character input from user if that char presnt in this array display it integer value
        public void show(string s)
        {
            char[] ch = s.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                if(char.IsDigit(ch[i]))
                {
                    Console.WriteLine(ch[i]);
                }
            }

        }
        static void Main(string[] args)
        {
            string[] s = { "A+3", "B+6", "c+9", "z+8" };
            Console.WriteLine("Enter char");
            char c = char.Parse(Console.ReadLine());
            for(int i=0;i<s.Length;i++)
            {
                char[] word = s[i].ToCharArray() ;
                for(int j=0;j<s[i].Length;j++)
                {
                    if(c==word[j])
                    {
                       
                    }
                }

            }
            Console.ReadLine();

        }
       

    }
    class FindLongestword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            string[] s = str.Split(' ');
            int Maxlength = 0;
            //string Longestword = "";
            for(int i=0;i<s.Length;i++)
            {
                if(s[i].Length>Maxlength)
                {
                    Maxlength = s[i].Length;
                    //Longestword=s[i]
                }

            }
            for(int i=0;i<s.Length;i++)
            {
                if(Maxlength==s[i].Length)
                {
                    Console.WriteLine(s[i]);
                }
            }
            Console.ReadLine();
        }
    }
    class StringSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            String[] s = str.Split( );
            for(int i=0;i<s.Length;i++)
            {
              for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i].CompareTo(s[j])==1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ", s));
            Console.ReadLine();
        }
    }
    
}

