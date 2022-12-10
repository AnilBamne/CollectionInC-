using System;

namespace CollectionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection\n");
            runAgain:
            Console.WriteLine("Select option to execute\n1:List\n2:Array\n");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CollectionDemos.ListDemo();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            goto runAgain;
        }
    }
}
