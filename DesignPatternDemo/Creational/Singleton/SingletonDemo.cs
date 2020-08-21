namespace DesignPatternDemo.Creational.Singleton
{
    using System;
    using System.Threading.Tasks;

    public class SingletonDemo
    {
        public static void SFactory()
        {
            Console.WriteLine("=====Singleton Options=====");
            Console.WriteLine();
            Console.WriteLine("1. With out thread safe.");
            Console.WriteLine("2. With thread safe.");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    WithoutThreadSafe();
                    break;

                case "2":
                    WithThreadSafe();
                    break;
            }            
        }

        private static void WithoutThreadSafe()
        {
            Console.WriteLine("=====Singleton Pattern Without Thread Safe=====");
            SingletonWithoutThreadSafe.GetInstance.PrintDetails("from Teacher");
            SingletonWithoutThreadSafe.GetInstance.PrintDetails("From Student");
        }

        private static void WithThreadSafe()
        {
            Console.WriteLine("=====Singleton Pattern With Thread Safe=====");
            Parallel.Invoke(
                () => SingletonWithThreadSafe.GetInstance.PrintDetails("from Teacher"),
                () => SingletonWithThreadSafe.GetInstance.PrintDetails("From Student"));
        }
    }
}
