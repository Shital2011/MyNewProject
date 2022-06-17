using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{   class Vehicles
    {
        public string wheels = "4";
    }
    class MotorDriven:Vehicles
    {
        public string engine = "Inline";
        
    }
    class Car: MotorDriven
    {
        public string Colour = "Black";
        public void ShowCar()
        {
            Console.WriteLine(Colour + " " + engine + " " + wheels);
            
            
        }
    }
    class MultiLeveleg
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.ShowCar();
            Console.ReadLine();
        }
    }
}
