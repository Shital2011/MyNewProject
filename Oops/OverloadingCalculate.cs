using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class OverloadingCalculate
    {//Q.write a code to show overloading for calculate method to calculate arithmetic operation
        public int x;
        public int y;

        void Calculate()
        {
            x = 2;
            y = 3;
            Console.WriteLine("Addition is= " + (x + y));
        }

        void Calculate(int x)
        {
            this.x = x;
            y = 3;
            Console.WriteLine("Substraction= " + (x - y));
        }

         void Calculate(int x,int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Multiplication =" + (x * y));
        }

        void Calculate(float x,int y)
        {
            Console.WriteLine("Division =" + (x / y));

        }

        static void Main(string[] args)
        {
            OverloadingCalculate c = new OverloadingCalculate();
            c.Calculate();
            c.Calculate(2);
            c.Calculate(2,3);
            c.Calculate(2f, 3);
            Console.ReadLine();

        }
    }
}
