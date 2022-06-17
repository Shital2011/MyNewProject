using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class Whilemagical//magical num using while
    {
        static void Main(string[] args)
        {
            int magicnum = 56;
            int i = 0;
            while (i >= 0 || i <= 0)
            {

                Console.WriteLine("enter num");
                int n = Convert.ToInt16(Console.ReadLine());


                if (magicnum < n)
                {
                    Console.WriteLine("num is greater than magicnum");
                    continue;
                }
                if (magicnum > n)
                {
                    Console.WriteLine("num is less than magic num");
                    continue;
                }
                else
                {
                    Console.WriteLine("This is mgic num");
                    break;
                }


            }
            Console.ReadLine();

        }

    }
    class en1_10 //no.between 1 to 10, if n = even then no. if n is odd then display square of that num
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * i);

                }
                i++;
            }
            Console.ReadLine();
        }

    }
    class series1//write logic for series (2,5,10,17,26)
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 100;




            for(i=1;i<=n;i++)
            {
                int s = (i*i) + 1;
                
                Console.WriteLine(s);
                Console.ReadLine();
            }
        }
    }
    class spy //check no. is spy or not......sum of digit==product of digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = Convert.ToInt32(Console.ReadLine());
            int c;
            int sum = 0;
            int p = 1;
            while(n>0)
            {
                int r = n % 10;
                sum = sum + r;
                p = p * r;
                n = n / 10;
                

            }
            if (sum == p)
            {
                Console.WriteLine("this is spy num");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("this is not spy num");
                Console.ReadLine();

            }
        }
    }
    class palindrom//reverse==original
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = n;
            int s = 0;
            while (n > 0)
            {
                int r = n % 10;
                s = (s * 10) + r;
                n = n / 10;
                
               if(c==s)
                {
                    Console.WriteLine("this is palindrome no");
                    Console.ReadLine();

                }
               else
                {
                    Console.WriteLine("this is not palindrome no");
                    Console.ReadLine();
                }
            }
            

        }

    }
    class armstrong //addition cube of each digit=original num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int c = n;
            int num = n;
            int count = 0;
           


            while (n > 0)
            {

               
                count++;
                n = n / 10;
            }
            Console.WriteLine("num of digit= "+count);

            while (num > 0) 
            {

                int i = num % 10;
                int power = 1;
                for (int j = 1; j <= count; j++)
                {
                    
                    power = power * i;
                   
                   

                }
                sum = sum + power;
                num = num / 10;


                Console.WriteLine("Power is="+power);
                



            }
            Console.WriteLine(sum);

            
            

            if (sum == c)
            {
                Console.WriteLine("this is armstrong num");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("this is not armstrong num");
                Console.ReadLine();
            }
            Console.ReadLine();


        }

    }
    class series2 //(2,12,36,80)
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 100;
            for (i = 1; i <= n; i++)
            {
                int s = (i * i) +(i*i*i);

                Console.WriteLine(s);
                Console.ReadLine();
            }



        }
    }
    class series3//(0,3,8,15,24..)
    {
        static void Main(string[] args)
        {
            int n = 100;
            for(int i=1;i<=100;i++)
            {
                int s = (i * i) - 1;//
                Console.WriteLine(s);
                Console.ReadLine();
            }

        }
    }
    class Decimal_Binary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                int i = n % 2;
                n = n / 2;
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
    class Binary_decimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter binary num");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int p = 0;
            while (n > 0)
            {
                int r = n % 10;
                int power = (int)(Math.Pow(2, p));
                sum = sum + (power * r);
                n = n / 10;
                p++;

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
    class Factorial//1 to 5 facorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            int sum = 0;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
                sum = fact + sum;
                
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }











    

}
