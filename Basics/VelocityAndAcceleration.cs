using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Basics
{
    class VelocityAndAcceleration
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter distance in meter");
            int dist = int.Parse(Console.ReadLine());
            Console.WriteLine("enter distance in min");
            int time = int.Parse(Console.ReadLine());
            double velocity = dist / time;
            double accl = velocity / time;
            Console.WriteLine("velocity=" + velocity + "accl=" + accl);

        }

    }
    class SpeedTime
    {
        static void Main(string[] args)
        {
            float distance;
            float hr, min, sec;
            float timesec;
            float mps;
            float kph, mph;
            Console.WriteLine("enter distance in meter");
            distance = float.Parse(Console.ReadLine());
            Console.WriteLine("hr");
            hr = float.Parse(Console.ReadLine());
            Console.WriteLine("min");
            min = float.Parse(Console.ReadLine());
            Console.WriteLine("sec");
            sec = float.Parse(Console.ReadLine());
            timesec = (hr * 3600) + (min * 60) + sec;
            mps = distance / timesec;
            kph = (distance / 1000.0f) / (timesec / 3600.0f);
            Console.WriteLine(mps + " " + kph);
            Console.ReadLine();

        }
    }
        
}
