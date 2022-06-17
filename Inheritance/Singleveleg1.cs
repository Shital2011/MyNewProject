using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    class Tree
    {
        public string leaf;
        public void show()
        {
            Console.WriteLine("Tree");
        }
        
    }
    class MangoTree:Tree
    {
        string fruit = "mango";
        public void showM()
        { leaf = "DarkGreen";
            Console.WriteLine(fruit + " " + leaf);
            show();

        }

       
    }
    class Singleveleg1
    {
        static void Main(string[] args)
        {
            MangoTree m = new MangoTree();
            m.showM();
            Console.ReadLine();
        }
    }
}
