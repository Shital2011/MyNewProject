using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Abstraction
{
    abstract class Trees
    {
        public abstract void leaf();
        
        
    }
    class MangoTree:Trees
    {
        public override void leaf()
        {
            Console.WriteLine("Leaves are green");
        }
        public void fruit()
        {
            Console.WriteLine("Mango");
        }
    }
    class AppleTree:Trees
    {
        public override void leaf()
        {
            Console.WriteLine("Leaves are green");
        }
        public void fruit()
        {
            
            Console.WriteLine("Apple");
        }
    }
    class HierarchycalAbstraction
    {
        static void Main(string[] args)
        {
            MangoTree m = new MangoTree();
            m.leaf();
            m.fruit();
            AppleTree m1 = new AppleTree();
            m1.leaf();
            m1.fruit();
            Console.ReadLine();


        }
        
    }
}
