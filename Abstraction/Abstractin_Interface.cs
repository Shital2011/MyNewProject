using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Abstraction
{//create one interface which contain one variable of int
    //type create a one abtsract class
   //which is also int variable perform addition of both variable in child class
   public interface IGet
    {

         int Y { get; set; } 
        
       

        
       
    }
    abstract class Getvalue
    {
        public int b = 30;
        

        
    }
    class Abstractin_Interface:Getvalue,IGet

    {
        int IGet.Y { get; set; } = 2;

        
        void add()
        {
           
        }

    }
}
