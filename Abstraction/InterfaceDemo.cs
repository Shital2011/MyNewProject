using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Abstraction
{
    public interface IPrintable
    {
        void run();
    }
    public interface IMovable
    {
      int X
        {
            get;
            set;
        }


        void show(int x);

       /* static void move()
        {
            Console.WriteLine("move");
        }
        internal void foo()
        {
            Console.WriteLine("foo");
        }*/
    }
    class InterfaceDemo:IMovable,IPrintable
    {

        int IMovable.X
            {
            get;
            set;
        }
        public void show(int x)
        {
            Console.WriteLine("show Method" + "  "+x);
        }
        public void run()
        {
            Console.WriteLine("run.....");
        }
        static void Main(string[] args)
        {
            IMovable m = new InterfaceDemo();

            m.X = 200;
                 m.show(m.X);
            /*  IMovable.move();
              m.foo();*/
            IPrintable p = new InterfaceDemo();
            p.run();
            Console.ReadLine();
        }
    }
}
