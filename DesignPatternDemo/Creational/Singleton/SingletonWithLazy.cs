namespace DesignPatternDemo.Creational.Singleton
{
    using System;
    public class SingletonWithLazy
    {
        private static int counter = 0;

        private static readonly Lazy<SingletonWithLazy> Instancelock =
                    new Lazy<SingletonWithLazy>(() => new SingletonWithLazy());
        public static SingletonWithLazy GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }
        private SingletonWithLazy() => Console.WriteLine("Counter Value " + (++counter).ToString());
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
