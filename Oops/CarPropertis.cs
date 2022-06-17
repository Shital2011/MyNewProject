using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class CarPropertis
    {
        private int modelno;
        private string name;
        private string color;
        private int price;
        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string c
        {
            get;
            set;
        }
        public int Price
        {
            get { return price; }
            set { price=value;}
        }
    } 
    class CarInfo
    {
        static void Main(string[] args)
        {
            CarPropertis c = new CarPropertis();
            c.Modelno = 2344;
            c.Name = "Audi";
            c.c = "Black";
            c.Price = 78900000;
            int number = c.Modelno;
            Console.WriteLine(number);
            Console.WriteLine(c.Name + " " + c.Price + " " + c.c);//Anonyms object creation
            Console.ReadLine();
        }
    }
}
