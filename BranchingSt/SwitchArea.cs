using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.BranchingSt
{
    class SwitchArea
    {
        static void Main (string[] args)
        {
            //area of circle=pi *r*r
            //area of squre= l*l
            //area of right angle trainlse = 0.5*l*b
            //area of rectagle=l*b
            //Circumference of a circle= 2*pi*3.14
            // Perimeter of a square=4*l
           
            
          
            Console.WriteLine("1.Area of a circle \n 2. Area of a square \n 3.Area of a right angled triangle \n 4.Area of a rectangle \n 5.Circumference of a circle \n6. Perimeter of a square");
            double calculate = Convert.ToDouble(Console.ReadLine());
            float pi = 3.14f;


            switch(calculate)
            {
                case 1:
                    Console.WriteLine("Enter radius");
                    double r = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine($"Area of circle = {pi * r * r}");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter length ");
                    double l = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Area of square= {l * l}");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter height ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter base ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Area of right angle traingle= {0.5* h * b}");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter length ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter breadth ");
                    double br = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Area of rectangle= {0.5 * length * br}");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Enter Diamter ");
                    double Di = Convert.ToDouble(Console.ReadLine());
                    

                    Console.WriteLine($"Circumference of a circle = {pi*Di}");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Enter length side ");
                    double s = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine($" Perimeter of a square = {4*s}");
                    Console.ReadLine();
                    break;



            }

        }
    }
}
