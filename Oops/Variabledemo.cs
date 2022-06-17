using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class Variabledemo
    {
        public int x;
        public void Accept()
        {
            x = 10;

        }
        public void Display()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Variabledemo v = new Variabledemo();
            
            v.Display();
            Console.ReadLine();
        }

    }
    class Method2
    {
        public int x;
        
        public void ReadValue(int id)
        {
            x = id;
        }

        public void Show()
        {
            Console.WriteLine(x);

        }
        static void Main(string[] args)
        {
            Method2 m = new Method2();
            m.ReadValue(123);
            m.Show();
            Console.ReadLine();
        }
    }
}
