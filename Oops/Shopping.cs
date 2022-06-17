using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Oops
{
    class Shopping
    {   /*2)create shopping class 
     Shopping class contain purchase item;prize per item and quanity;
     Create 1st method to accept shopping details
     If the quantity is greater than zero then calculate the bill for the purchase using get bill method otherwise show the error and create 3rd method to show total bill including all shopping details */
         string item;
       double price;
        int quantity;
        double bill;
        public void accept(string item,double price,int quantity)
        {
            this.item = item;
            this.price = price;
            this.quantity = quantity;

        }
        public void getbill()

        {   if (quantity > 0)
            {
                bill = price * quantity;
                Console.WriteLine(bill);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
        public void  show()
        {
            Console.WriteLine("item="+item);
            Console.WriteLine("price="+price);
            Console.WriteLine("quantity="+quantity);
            

        }
        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.accept("book", 500, 0);
            s.getbill();
            s.show();
            

            Console.ReadLine();
        } 


            

    

    }
}
