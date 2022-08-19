using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    class Collection
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            //Add remove eplace
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Add(500);
            lst.Remove(300);
            lst[0] = 1000;
            lst.Insert(2, 2000);
            // lst.Clear();


            Console.WriteLine(lst.Contains(90));//checking for 90 is availabe oer not
            int l = lst.IndexOf(300);
            lst.LastIndexOf(300);


            List<int> lst2 = new List<int>() { 101, 111, 121 };
            //lst2.AddRange(lst);
            lst.InsertRange(1, lst2);
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
            Console.WriteLine(lst);
            for (int i = 0; i < lst2.Count; i++)
                Console.WriteLine(lst2[i]);

            foreach (int data in lst)
                Console.WriteLine(data);

            Console.ReadLine();
        }

    }
     class DemoLinkedList
     {
        static void Main(string[] args)
        {

        }
     }

    class sagitec
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", a));
            int max = 0;
            int diff = 0;
            for(int i=0;i<a.Length;i++)

            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    diff = a[i] - a[j];
                    if (diff > max)
                    {
                        max = diff;
                    }
                    else if ((-(diff)) > max)
                    {
                        max = (-diff);
                    }
                    else
                    {
                        max = diff;
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }

    }
    class DictDemo
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string>()
            { "red","pink","Blue","red","pink","yellow","red"};
            string s = "Pratiksha";
            char[] arr = s.ToCharArray();
            //key-Colour
            //Value is Count
            Dictionary<char, int> ddd = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if(ddd.ContainsKey(c))
                {
                    int value = ddd[c];
                    ddd[c] = value + 1;
                }
                else
                {
                    ddd.Add(c, 1);
                }
            }
            foreach (KeyValuePair<char, int> kvs in ddd)
                Console.WriteLine(kvs.Key + " " + kvs.Value);
            Dictionary<string, int> dd = new Dictionary<string, int>();
            foreach(string color in ll)
            {
                if(dd.ContainsKey(color))
                {
                    int oldvalue = dd[color];
                    dd[color] = oldvalue + 1;

                }
                else
                {
                    dd.Add(color, 1);
                }
                

            }
            foreach (KeyValuePair<string, int> kv in dd)
                Console.WriteLine(kv.Key + " " + kv.Value);
           
            Console.ReadLine();
        }

    }
    class order
    {
        int orderid;
       
    }
    class Demostack
    {
        //first in last out
        //last in first out
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("A");
            st.Push("B");
            st.Push("C");
            st.Push("D");
           

            //string dataremove = st.Pop();
            //Console.WriteLine(dataremove);
            string datapak = st.Peek();
            Console.WriteLine(datapak);

            foreach (string d in st)
                Console.WriteLine(d);
            Console.ReadLine();
        }

    }
    class DemoQueue
    {
        static void Main(string[] args)
        {
            //first in first out
            Queue<int> q = new Queue<int>();
            q.Enqueue(11);
            q.Enqueue(12); q.Enqueue(13);
            int remove = q.Dequeue();
            q.Clear();
            //q.CopyTo();
        }
    }
    class Empp
    {
        int eno;
        string name;
        string deptname;
        public Empp(int eno,string name,string deptname)
        {
            this.Eno = eno;
            this.Name = name;
            this.Deptname = deptname;

        }
        public override string ToString()
        {
            return"Eno:"+eno+"Name:"+name+"Departmentname:"+deptname;

        }
        public int Eno
        {
            get { return eno; }
            set { eno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Deptname
        {
            get { return deptname; }
            set { deptname = value; }
        }
    }
    class Sol
    {
        static void Main(string[] args)
        {
            LinkedList<Empp> ll = new LinkedList<Empp>();
            ll.AddLast(new Empp(1, "AA", "IT"));
            ll.AddLast(new Empp(3, "bb", "Testing"));
            ll.AddLast(new Empp(5, "cc", "HR"));
            ll.AddLast(new Empp(7, "dd", "IT"));
            ll.AddLast(new Empp(10, "ee", "IT"));
            ll.AddLast(new Empp(12, "ff", "HR"));
            string dname = " ";
            foreach(Empp e in ll)
            {
                if(e.Eno==10)
                {
                    dname = e.Deptname;
                    break;
                }
            }
            foreach(Empp e in ll)
            {
                if(e.Deptname==dname)
                {
                    Console.WriteLine(e);
                }
            }
            Console.ReadLine();

        }
    }
    class DemoSS
    {
        static void Main(string[] args)
        {
            //stored data in order according to the keys
            //tree
           //BST--binary

        }
    }
    class Solution
    {
        static void Main(string[] args)


        {
            string s = "Shital";
     
      for (int i = 0; i < s.Length; i++)
         {
                if (i % 2 == 0)

                    Console.Write(s[i]);
                else

                    Console.Write('*');
            }
        }
    }






}
