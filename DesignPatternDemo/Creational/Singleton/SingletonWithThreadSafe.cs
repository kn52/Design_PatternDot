namespace DesignPatternDemo.Creational.Singleton
{
    using System;
    public class SingletonWithThreadSafe
    {
        private static int counter = 0;
        private static SingletonWithThreadSafe instance = null;
        public static SingletonWithThreadSafe GetInstance
        {
            get
            {
                lock (new object())
                {
                    if (instance == null)
                    {
                        instance = new SingletonWithThreadSafe();
                    }
                    return instance;
                }
            }

        }

        private SingletonWithThreadSafe() => Console.WriteLine("Counter Value " + (++counter).ToString());
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}