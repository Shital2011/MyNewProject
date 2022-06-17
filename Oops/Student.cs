using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class Student
    {
        //code to create student class student has ID,name,3 subject marks,
        //create 1st method to accept detalis of student
        //create 2 nd method to calculate % of student
        //create 3rd method display details of student with percentage
        int id;
        string name;
        int sub1;
        int sub2;
        int sub3;
        int per;
        public void Accept(int eid, string ename, int subject1, int subject2, int subject3)
        {   
           id = eid;
            name = ename;
            sub1 = subject1;
            sub2 = subject2;
            sub3 = subject3;
            

        }
        public void Percentage()
        {
            int per = (sub1 + sub2 + sub3) / 3;
            this.per = per;
           
            

        }
        void display()
        {
            
            Console.WriteLine("id= " + id + '\n' + "name= " + name + '\n' + "marks of sub1= " + sub1 + '\n' + "marks of sub2= " + sub2 + '\n' + " marks of sub3=" + sub3);
            Percentage();
            Console.WriteLine("percentage=" + per+"%");

        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Accept(1, "sanket", 77, 89, 78);
            s.display();
            
          

            /*s.Accept(2, "saurav", 97, 39, 67);
            s.display();
            s.Percentage();
            s.Accept(3, "shital", 57, 69, 40);
            s.display();
            s.Percentage();*/


          
           
           
            Console.ReadLine();
        }
    }
}
