using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInCSharp
{
    public class ListDemo
    {
        ///<summary>
        ///LIST
        ///creating a static method ListDemo,performing list operations 
        /// </summary>
        public static void DoList()
        {
            ///<summary>
            ///creating a list of strings
            ///Add method is used to add elements to list
            /// </summary>
            List<string> list = new List<string>();
            list.Add("Anil");
            list.Add("Bamne");
            list.Add("From");
            list.Add("Bidar");
            list.Add("Karnataka");
            list.Add("India");

            Console.WriteLine("\nElfements in list are :\n");
            //Iterating over list to print elements of list
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            //list.Remove to remove elements from list 
            list.Remove("India");                           //removing by elements
            list.RemoveAt(3);                               //removing by element index
            Console.WriteLine("\nAfter removing Elfements in list are :\n");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
