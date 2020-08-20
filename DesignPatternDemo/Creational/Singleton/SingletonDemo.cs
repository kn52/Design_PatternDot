namespace DesignPatternDemo.Creational.Singleton
{
    using System;
    public class SingletonDemo
    {
        public static void SFactory()
        {
            Console.WriteLine("=====Singleton Options=====");
            Console.WriteLine();
            Console.WriteLine("1. With out thread safe.");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    WithoutThreadSafe();
                    break;
            }            
        }

        private static void WithoutThreadSafe()
        {
            Console.WriteLine("=====Singleton Pattern Without Thread Safe=====");
            SingletonWithoutThreadSafe.GetInstance.PrintDetails("from Teacher");
            SingletonWithoutThreadSafe.GetInstance.PrintDetails("From Student");
        }        
    }
}
