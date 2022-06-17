using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Cars
    {
        public string colour = "black";
    }
    class Audi:Cars
    {
        string engine = "Petrol";
        public void showAudi()
        {
            Console.WriteLine("Audi   " + engine + " " + colour);
        }
    }
    class Scorpio:Cars
    {
        int number = 9090;
        public void showScorpio()
        {
            Console.WriteLine("Scorpio   " + number + " " + colour);
        }

    }

    class Manza:Cars
    {
        string model = "2367";
        public void showManza()
        {
            Console.WriteLine("Manza   " + model + " " + colour);
        }
    }
    class Hierarchicaleg1
    {
        static void Main(string[] args)
        {
            Audi a = new Audi();
            a.showAudi();
            Scorpio s = new Scorpio();
            s.showScorpio();
            Manza m = new Manza();
            m.showManza();
            Console.ReadLine();
        }
    }
}
