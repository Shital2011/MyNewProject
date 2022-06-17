using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    public class AccessModifierDemo
    {
        private int x = 10;
        public int y = 300;
        protected int z = 45;
        static void Main(string[] args)
        {
            AccessModifierDemo a = new AccessModifierDemo();
            Console.WriteLine(a.x);//private only access in same class
            Console.WriteLine(a.y);
            Console.WriteLine(a.z);
        }
    }
    class Modifiers: AccessModifierDemo
    {
        static void Main(string[] args)
        {
            AccessModifierDemo m = new AccessModifierDemo();
            //Console.WriteLine(m.x);private cant acces outside the class
            Console.WriteLine(m.y);
            //Console.WriteLine(m.z);
            Modifiers d = new Modifiers();
            Console.WriteLine(d.z);
            Console.ReadLine();
        }
    } 
}
