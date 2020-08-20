namespace DesignPatternDemo.Creational
{
    using System;
    using DesignPatternDemo.Creational.AbstractFactory;
    using DesignPatternDemo.Creational.FactoryMethod;
    
    public class CreationalPattern
    {
        public void Creational()
        {
            while (choice.ToLower().Equals("y"))
            {
                Console.Clear();
                Console.WriteLine("=====Creational Design Pattern====");
                Console.WriteLine("1. Factory Method Pattern");
                Console.WriteLine("2. Abstract Factory Pattern");
                Console.WriteLine("n. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        CardFactory.Factory();
                        break;

                    case "2":
                        AbFactory.AFactory();
                        break;

                    case "n":
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine();
                Console.Write("Enter y to see other creational patterns or n to exit: ");
                this.choice = Console.ReadLine();
            }
        }

        private string choice = "y";
    }
}
