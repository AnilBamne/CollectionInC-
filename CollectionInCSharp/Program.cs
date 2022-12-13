using System;

namespace CollectionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection");
            runAgain:
            Console.WriteLine("\nSelect option to execute\n1:List\n2:Set\n3:Queue\n4:Dictionary");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CollectionDemo.DoList();
                    break;
                case 2:
                    CollectionDemo.doSetDemo();
                    break;
                case 3:
                    CollectionDemo.DoQueueDemo();
                    break;
            }
            goto runAgain;
        }
    }
}
