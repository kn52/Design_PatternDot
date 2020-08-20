namespace DesignPatternDemo.Creational.Singleton
{
    using System;
    public class SingletonWithoutThreadSafe
    {
        private static int counter = 0;
        private static SingletonWithoutThreadSafe instance = null;
        public static SingletonWithoutThreadSafe GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonWithoutThreadSafe();
                return instance;
            }

        }

        private SingletonWithoutThreadSafe() => Console.WriteLine("Counter Value " + (++counter).ToString());
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
