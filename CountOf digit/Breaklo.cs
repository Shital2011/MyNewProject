using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    class Breaklo
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter th context");
            string s = Console.ReadLine();

            int v = 0;

            for (int i = 0; i < s.Length; i++)

            {

                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    
                    v++;

            }  
                    
                   

                

                Console.WriteLine(v);

                Console.ReadLine();

              
            
        
        }


    }
}
