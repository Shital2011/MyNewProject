using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Conditional
{
    class GreatestNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number3");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is greater");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine(num3 + " is greater");
                    Console.ReadLine();

                }






            }
            else
            {
                if (num2 > num3)
                {


                    Console.WriteLine(num2 + "is Greater");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(num3 + "is greater");
                    Console.ReadLine();

                }



            }      

                
                
                
                    
             
                
            
            
            
                
            
            
                
               
           
           /* if (num1 > num2 && num1 > num3) ;
            {
                Console.WriteLine(num1 +" "+ " is greatest number");
                Console.ReadLine();






            }
            else
            {
                if(num2>num1 && num2>num3)
                {
                    Console.WriteLine(num2 + " " + "is greatest number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(num3 + " " + "is greatest number");
                    Console.ReadLine();

                }
            }*/

                
            

        }

    }


}
