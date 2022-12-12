using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInCSharp
{
    public class SetDemo
    {
        public static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");
            HashSet<string> set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add(null);      //Allows a only one null value
            set.Add("Ajay");    //Set doesnot allow Duplicate values
            set.Add("Anil");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            Console.WriteLine("\n Elements in set :");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            //We can fetch perticular element by the help of index
            Console.WriteLine("\n Element at index=1 :");
            Console.WriteLine(set.ElementAt(1));
        }
    }
}
