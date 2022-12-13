using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInCSharp
{
    public class CollectionDemo
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
        //stores the elements in FIFO style (First In First Out)
        public static void DoQueueDemo()  
        {
            Console.WriteLine("\nIn Queue Demo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Shah");
            queue.Enqueue("Narendra Modi");
            queue.Enqueue("JaiShankar");
            queue.Enqueue("Rajnath");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");
            foreach (var elements in queue)
            {
                Console.WriteLine(elements);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Deque element:" + dequeue);
            Console.WriteLine("\nIterating the queue elements after deque one element:");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void DoStackDemo()   //Stack represents a last-in, first out collection of object.
        {
            Console.WriteLine("\nIn Stack Demo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();
            foreach (var elements in stack)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("Poped Element: " + pop);
        }
    }
}
