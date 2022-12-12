using System;

namespace CollectionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection\n");
            runAgain:
            Console.WriteLine("\nSelect option to execute\n1:List\n2:Set\n");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ListDemo.DoList();
                    break;
                case 2:
                    SetDemo.doSetDemo();
                    break;
                case 3:
                    break;
            }
            goto runAgain;
        }
    }
}
