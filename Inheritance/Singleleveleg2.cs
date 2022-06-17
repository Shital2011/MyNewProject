using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{   class Water
    {
        public string Colour;
        
    }
    class SeaWater:Water
    {
        string Taste = "Salty";
       
        
        public void show()
        {
            Colour = "Blue";
            Console.WriteLine(Taste + " " + Colour);
        }

    }

    class Singleleveleg2
    {
        static void Main(string[] args)
        {
            SeaWater s = new SeaWater();
            s.show();
            Console.ReadLine();

        }
    }
}
