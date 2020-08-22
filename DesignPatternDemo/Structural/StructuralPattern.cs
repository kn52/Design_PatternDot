namespace DesignPatternDemo.Structural
{
    using System;
    using DesignPatternDemo.Structural.Composite;
    using DesignPatternDemo.Structural.Decorator;
    using DesignPatternDemo.Structural.Facade;

    public class StructuralPattern
    {
        public void Structural()
        {
            while (choice.ToLower().Equals("y"))
            {
                Console.Clear();
                Console.WriteLine("=====Structural Design Pattern====");
                Console.WriteLine("1. Composite Pattern");
                Console.WriteLine("2. Facade Pattern");
                Console.WriteLine("3. Decorator Pattern");
                Console.WriteLine("n. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        CompositeDemo.Composite();
                        break;

                    case "2":
                        FacadeDemo.Facade();
                        break;

                    case "3":
                        DecoratorDemo.Decorator();
                        break;

                    case "n":
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine();
                Console.Write("Enter y to see other structural patterns or 'n' to exit: ");
                this.choice = Console.ReadLine();
            }
        }

        private string choice = "y";
    }
}
