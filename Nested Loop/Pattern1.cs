using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Nested_Loop
{
    class Pattern1//****
                  //***
                  //**
                  //*
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    
    }   
    class pattern2//   *
                  //  **
                  // ***
                  //****
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }

                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    class pattern3//****
                  //*  *
                  //*  *
                  //****
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {


                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 4)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
    class table1_5
    {

        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    Console.WriteLine(i+"*"+j+"="+(i * j));
                   
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
    class pattern4//*
                  //**
                  //* *
                  //****
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i==3&&j==2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }   
    }
    
    class Patttern5//*  *
                   //** *
                   //* **
                   //*  *
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1 || j == 4 ||(i==2&&j==2)||(i==3&&j==3))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
    class pattern06//   *
                   //   *
                   // *****
                   //   *
                   //   *
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if(i==3||j==3)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
    class pattern07//4321
                   //432
                   //43
                   //4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write(j+" ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    class pattern08//1234
                   //123
                   //12
                   //1
    {
        static void Main(string[] args)
        {
            for(int i=4;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    class pattern09//1234
                   //234
                   //34
                   //4
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + k);

                }
                Console.WriteLine();
                k++;

            }
            Console.ReadLine();
        }

    }
    class pattern10 //1
                    //23
                    //456
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i=1;i<=3;i++)
            {
                
                for(int j=1;j<=i;j++)
                {
                    Console.Write(k+" ");
                    k++;
                }
                Console.WriteLine();
                
                
            }
            Console.ReadLine();
        }
    }
    class pattern11//1
                   //10
                   //101
                   //1010
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    class pattern12//1
                   //AB
                   //123
                   //ABCD
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {



                int c = 64;
                    for (int k = 1; k <= i; k++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write((char)(k+c));
                        }
                        else
                        {
                            Console.Write(k);
                        }
                    }
                
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }



















        
            
            
        
    

}
