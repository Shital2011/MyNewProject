using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.WrittenTest_1Darray_18June
{
    class Q1_EvenOddCount
    {//create a Array of integer and count the number of even  and odd elements from array.
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("enter elements of array");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ", a));
            int countEven = 0;
            int countOdd = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            Console.WriteLine("no. of even no = " + countEven+"  " + "no. of odd no.= " + countOdd);
            Console.ReadLine();
        }
    }
    class Q2
    {//Predict the output: 
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(string []args)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
            Console.ReadLine();
            //101,102
        }


    }
    class Nib
    {
        string materialtype;
        int width;
        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public void shownib()
        {
            Console.WriteLine(Materialtype + " " + Width);
        }
    }
    class Refill
    {//A Pen contains variables Refill, capLength and brand. Refill has variables
     //inkColor, length and Nib(tip). Nib has variables materialType and width.Create
     //a  class structure for above.Write a main method which sets values in all the variables
     //using setter methods and prints all the variables using getter methods.
        string inkColour;
        int Length;
        Nib nib;
        public string InkColour
        {
            get { return inkColour; }
            set { inkColour = value; }
        }
        public int length
        {
            get { return Length; }
            set { Length = value; }
        }
        public Nib Nibtype
        {
            get { return nib; }
            set { nib = value; }
        }
        public void showRefill()
        {
            Console.WriteLine(InkColour + " " + Length);
            Nibtype.shownib();
        }

    }
    class Q3_pen
    {
        Refill refill;
        string brand;
        int caplength;

        public string Brand 
        { get { return brand; }
           set { brand = value; }
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public  Refill Refills
        {
            get { return refill; }
            set { refill = value; }
        }
        public void showPen()
        {
            Refills.showRefill();
            Console.WriteLine(Brand + " " + Caplength);

        }
        static void Main(string[] args)
        {
            Q3_pen m = new Q3_pen();
            m.Brand = "reynolds";
            m.caplength = 5;
            m.Refills.InkColour = "blue";
            m.Refills.length = 10;
            m.Refills.Nibtype.Materialtype = "ss";
            m.Refills.Nibtype.Width = 2;
            




            m.showPen();
            Console.ReadLine();
        }
    }

    class Q4_separatezeros
    {//Write a  program to separate zeros from non-zeros in an integer array?
        static void Main(string[] args)
        {
            int[] a = new int[6];

            Console.WriteLine("enter elements of array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            
            Console.WriteLine(string.Join(" ", a));
        
            int pos = 0;

            for (int i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    a[i] = a[pos];
                    pos++;
                }
               
                
                
            }
            while(pos<a.Length)
            {
                a[pos] = 0;
                pos++;
            }
            Console.WriteLine(string.Join(" ", a));
            Console.ReadLine();
        }

    }
    class Q5_Min_frequencyChar
    {
        static void Main(string[] args)
        {
            char[] a = new char[6];
            int[] freq = new int[a.Length];
            int min1 = 0;
            char ch=' ';
            Console.WriteLine("enter elements of array");
            for (int i = 0; i < a.Length; i++)
            {
                
                a[i] = char.Parse(Console.ReadLine());

            }
            int min = freq[0];
            for(int i=0;i<a.Length;i++)
            {
                freq[i] = 1;
               int count = 1;
                 min1 = int.MaxValue;
             //   Console.WriteLine(min1+" ////////////////////////////");
                bool isvisited = false;
                for (int k=i-1;k >= 0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for (int j = i + 1; j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            freq[i]++;
                            count++;
                        }
                    }
                    if (count<min1)
                    {
                        Console.WriteLine(count+"/////////////////////////////");
                        min1 = count;
                        Console.WriteLine(min1+"..............................");
                        ch = a[i];
                      
                    }

                }
                






            }
            Console.WriteLine( min1+"     "+ch);
/*            int p = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(freq[p]==min)
                {

                }
            }*/
            Console.ReadLine();
        }
    }
    class Q6_Duplicate
    {

        static void Main(string[] args)
        {
            int[] a = new int[6];

            

            for (int i = 0; i < a.Length; i++)
            {

                a[i] = int.Parse(Console.ReadLine());

            }
            int count1 = 6;
            int[] final = new int[20];
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;

                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;

                        }
                    }

                    if (count == 1)
                    {

                        
                        
                            final[s] = a[i];
                        s++;
                        
                        


                    }
                    
                    
                        
                    
                }
                
            }
            for(int i=0;i<s;i++)
            {
                Console.WriteLine(final[i]);
            }
           /// Console.WriteLine(string.Join(" ", final));
            Console.ReadLine();


                
                
        }
            
            


        
    }
    class Q7
    {/*There are four classes a) Car (carId, carcolor) b) Engine
     (engineid ,lastenginecleandate) c) SubEngine (subenginetype)
     d) Gear (type - auto manual)
     Car has Engine, Engine has SubEngine, Car also has Gear
     Create Object in Object (Containment) for above scenario
*/
        static void Main(string[] args)
        {
            Car c = new Car(123, "white", new Engine(111,"06/26/2022", new Subengine("petrol")), new Gear("auto"));
            c.showcar();
            Console.ReadLine();
        }

    }
    class Subengine
    {
        string subenginetype;
        public Subengine(string subenginetype)
        {
            this.subenginetype = subenginetype;
        }
        public void showsub()
        {
            Console.WriteLine(subenginetype);
        }
    }
    class Engine
    {
        int engineid;
        string lastenginecleandate;
        Subengine sub;
        public Engine(int engineid , string lastenginecleandate,Subengine sub)
        {
            this.engineid = engineid;
            this.lastenginecleandate = lastenginecleandate;
            this.sub = sub;
        }
        public void showengine()
        {
            Console.WriteLine(engineid+" "+ lastenginecleandate);
            sub.showsub();
        }

    }
    class Gear
    {
        string type;
        public Gear(string type)
        {
            this.type = type;
        }
        public void showgear()
        {
            Console.WriteLine(type);
        }
    }
    class Car
    {
        int carId;
        string carcolour;
        Engine engine;
        Gear gear;

        public Car(int carId, string carcolour,Engine engine,Gear gear)
        {
            this.carId = carId;
            this.carcolour = carcolour;
            this.engine = engine;
            this.gear = gear;
        }
        public void showcar()
        {
            Console.WriteLine(carId + " " + carcolour);
            engine.showengine();
            gear.showgear();
        }

    }
    class Q8
    {
        //What will be output of following program
        static void Main(string[] args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] +" ");
                i++;
            }
            //0,2,4,6
            Console.ReadLine();
       
        }
    }
    class Q9_perfectsqr
    {/* WAP to display all perfect square number in array. Means e.g. arr[] = [23, 43, 25, 49, 12, 9, 78, 66, 39, 0] so output is 25, 49, 9*/
        static void Main(string[] args)
        {
            int[] a = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            int i;
            foreach(int m in a)
            {
               for(i=1;i<m;i++)
                {
                    if(i*i==m)
                    {
                        Console.WriteLine(m);
                    }
                }
               
            }
            Console.ReadLine();
        }
    }
    class Q10
    {
        static void Main(string[] args)
        {

            int[] a1 = { 1, 2, 3 };

            int[] a2 = new int[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = a1[i];
            }
            for (int i = 0; i < a2.Length; i++)
            {

                Console.WriteLine(a2[i]);
            }
            Console.ReadLine();

        }
        
        
        


        
              
            
        

    }
    class Q11_Replace
    {
        /*WAP to replace all the 0’s with 1’s in your array. Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34].*/
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            int[] a1 = new int[a.Length];
            for(int i=0;i<a1.Length;i++)
            {
                if(a[i]==0)
                {
                    a1[i] = 1;
                }
                else
                {
                    a1[i] = a[i];
                }

            }
            Console.WriteLine(string.Join(" ",a1));
            Console.ReadLine();
        }
        
        
    }
    class Q12_printnumber
    {/*Write a  program that prints the numbers
     from 1 to 50. But for multiples of three print “buzz” instead of the
     number and for the multiples of five print “fizz”. For numbers which
     are multiples of both three and five print “ buzzfizz “. After program
    looping is completed print how many times buzz was printed, fizz
        was printed and buzzfizz was printed.
          */
        static void Main(string[] args)
        {
            int countbuzz = 0;
            int countfizz = 0;
            int countbuzzfizz = 0;

            for (int i=1;i<=50;i++)
            {
              if(i%3==0&&i%5==0)
              {
                    Console.WriteLine("buzzfizz");
                    countbuzzfizz++;

              }
              else if (i % 3 == 0)
              {
                    Console.WriteLine("buzz");
                    countbuzz++;
              }
              else if(i%5==0)
              {
                    Console.WriteLine("fizz");
                    countfizz++;

              }
              else
              {
                    Console.WriteLine(i);
              }



            }
            Console.WriteLine("count of buzzfizz= " + countbuzzfizz + " count of buzz = " + countbuzz + " count of buzz= " + countfizz);
            Console.ReadLine();

        }

    }

}



