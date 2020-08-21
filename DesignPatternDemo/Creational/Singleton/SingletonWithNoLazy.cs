namespace DesignPatternDemo.Creational.Singleton
{
    using System;
    public class SingletonWithNoLazy
    {
        
        public static SingletonWithNoLazy GetInstance { get; } = new SingletonWithNoLazy();

        private static int counter = 0;
        private SingletonWithNoLazy() => Console.WriteLine("Counter Value " + (++counter).ToString());
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
