using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.WrittenTest_11june
{
    class Q1_1_100not_divibleby5_10
    {//1)Write a program to print all numbers between 1 and 100 except
        //the numbers which are divisible by 5or 10

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 10 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }

        }
    }


    class Q2_Loop
    {//2) Predict behaviour of the following code: 
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);

            }

            while (b != 3);

            Console.ReadLine();
        }//2 2 2




    }
    class Q3

    { //2) Predict behaviour of the following code:
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k = k * i;

            }
            Console.WriteLine("k =" + k + "i =" + i);
            //k=720;i=7

            Console.ReadLine();

        }
    }
    class Q4_Spy
    {//4)write a  program to check given number is spy number or not
     // e.g 123 if sum of digit is equals to product of digit the number is spy number
     //i.e 123=1+2+3=6 and 1*2*3=6 so the number is spy number
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int p = 1;
            while (n > 0)
            {
                int rem = n % 10;
                sum = sum + rem;
                p = p * rem;
                n = n / 10;

            }
            if (sum == p)
            {
                Console.WriteLine("spy");
            }
            else
            {
                Console.WriteLine("not spy");
            }
            Console.ReadLine();
        }

    }
    class Q5_Trimorphic//last digits cube of number is number iteslef
    {
        // write a program to check given number is trimorphic number or not
        //4 is trimorphic number as its cube(64) contains 4  at the end.
        //5 is trimorphic number as its cube(625)contains 5 at the end.
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());
            int copy = n;

            int count = 0;

            while (copy > 0)
            {
                count++;
                copy = copy / 10;
            }
            int power = 1;
            int cube = n * n * n;
            for (int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            Console.WriteLine(cube + "  " + power);
            int LastDigits = cube % power;
            Console.WriteLine(LastDigits);
            if (LastDigits == n)
            {
                Console.WriteLine("trimorphic");
            }
            else
            {
                Console.WriteLine("Not trimorphic");
            }
            Console.ReadLine();
        }
    }
    class Q6_Pattern
    {
        //WAP to print following pattern.
        //              1
        //            2 2 2
        //          3 3 3 3 3
        //        4 4 4 4 4 4 4
        static void Main(string[] args)//k=2*n-2
        {
            int n = 4;
            int k = 3;
            int len = 1;

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= k; j++)
                {
                    Console.Write(" ");

                }

                for (int s = 1; s <= len; s++)
                {
                    Console.Write(i);


                }
                k--;
                len = len + 2;
                Console.WriteLine();
                Console.ReadLine();
            }
        }

    }
    class Q7_Pattern
    {
        // 7.WAP to print following pattern.
        //        *****
        //****
        //***
        //**
        //*
        static void Main(string[] args)
        {

            int k = 0;
            for (int i = 5; i >=1; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for ( k = 1; k <= i; k++)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine();


                Console.ReadLine();
            }
        }

    }
    class Q8_pattern
    /* 8) WAP to print following pattern. 
  1 2 3 4 5
    1 2 3 4
      1 2 3
        1 2
          1*/
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int i = 5; i >= 1; i--)
            {
                
                int j;
                for (j = 1; j <= 5; j++)
                {


                    int s = k + j;
                    if(s<=0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(s);
                    }

                   
                }
                k--;
                
                Console.WriteLine();
                
                
                Console.ReadLine();
            }
        }



    }
    class Q9
    {//Predict the output of following: 
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt = mysteryInt - i;
                Console.WriteLine(mysteryInt);
            }//95 96 97 98 99
            Console.ReadLine();
        }
          



    }
    class Q10_TwinPrime
    {
        static void Main(string[] args)
        {
            /*Write a program to find twin prime number. (Accept two no from
           user and check, if both are prime and their difference is 2 then they
          are twin prime). 
          */
            Console.WriteLine("enter number num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number num2");
            int num2 = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i=2;i<num1;i++)
            {
                
                if (num1%i==0)
                {
                    count++;
                    break;
                }
                else
                {
                    for (int j = 2; j < num2; j++)
                    {
                        
                        if (num2 % j == 0)
                        {
                            count++;
                            break;
                        }
                        

                    }
                }
              

            }
            
            if(count==0&&((num1-num2)==2||(num2-num1)==2))
            {

                Console.WriteLine("this are twin Prime number");
            }
            else
            {
                Console.WriteLine("this are not twin prime no.either one of them is not prime or diffrence is not 2");
            }
            Console.ReadLine();
        }
    }
    class Q11_series1//    Print the Series 
              //2 12 36 80 150 252....upto 10 terms

    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                int n = (i * i) + (i * i * i);
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
    class Q12
    {  //WAP to print number from 1 to 50 if number is even then print as it is and number is odd then print negative number with its square
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    int n = i * i;
                    Console.WriteLine(-n);
                }
                Console.ReadLine();
            }
        }
    }
    class Q13
    //Predict the output of following:what are the value of i and j [1M]
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
                //infinity 1 loop 
            }
        }
    }
    class Q14_fibbo
    {//WAP to print fibbo series upto 20 terms
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            
            for(int i=1;i<=20;i++)
            {
                int sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                Console.WriteLine(sum);
               
               
            }
            Console.ReadLine();
        }
    }
    class Q15_FactorialSum
    {//1!+2!+3!+4!...n WAP a program to find sum
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }





}



