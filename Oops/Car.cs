using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class Car
    {//code to create car class..class has model no.,car name,car colour,price.create data for e classes and display it
        
        
            float modelNo;
            string name;
            string colour;
            int price;
        public void show(float modelNo, string name, string colour, int price)
        {
            this.modelNo = modelNo;
            this.name = name;
            this.colour = colour;
            this.price = price;
            Console.WriteLine("Model no= " + modelNo +'\n'+ "car name= " + name + '\n' + "car colour= " + colour + '\n' + "Price=" + price);
            
        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.show(3.2f, "manza", "Black", 300000);
            Console.WriteLine();
            Car c2 = new Car();
            c2.show(4.1f, "Scorpio", "Red", 400000);
            Console.WriteLine();
            Car c3 = new Car();
            c3.show(2.0f, "Indica", "White", 350000);
            Console.WriteLine();
            Console.ReadLine();

        }



             
            
        


    }
}
