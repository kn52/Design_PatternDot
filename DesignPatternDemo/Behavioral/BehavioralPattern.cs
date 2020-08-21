namespace DesignPatternDemo.Behavioral
{
    using System;
    using DesignPatternDemo.Behavioral.Interpreter;
    using DesignPatternDemo.Behavioral.Iterator;
    using DesignPatternDemo.Behavioral.Observer;
    using DesignPatternDemo.Behavioral.State;
    using DesignPatternDemo.Behavioral.Strategy;
    using DesignPatternDemo.Behavioral.Template;
    using DesignPatternDemo.Behavioral.Visitor;

    public class BehavioralPattern
    {
        public void Behavioral()
        {
            while (choice.ToLower().Equals("y"))
            {
                Console.Clear();
                Console.WriteLine("=====Behavioral Design Pattern====");
                Console.WriteLine("1. Observer Pattern");
                Console.WriteLine("2. Strategy Pattern");
                Console.WriteLine("3. State Pattern");
                Console.WriteLine("4. Iterator Pattern");
                Console.WriteLine("5. Interpreter Pattern");
                Console.WriteLine("6. Template Pattern");
                Console.WriteLine("7. Template Pattern");
                Console.WriteLine("8. Visitor Pattern");
                Console.WriteLine("n. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        ObserverDemo.Observer();
                        break;

                    case "2":
                        StretegyDemo.Strategy();
                        break;

                    case "3":
                        StateDemo.State();
                        break;

                    case "4":
                        IteratorDemo.Iterator();
                        break;

                    case "5":
                        InterpreterDemo.Interpreter();
                        break;

                    case "6":
                        TemplateDemo.Template();
                        break;

                    case "7":
                        VisitorDemo.Visitor();
                        break;

                    case "n":
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine();
                Console.Write("Enter y to see other behavioral patterns or n to exit: ");
                this.choice = Console.ReadLine();
            }
        }

        private string choice = "y";
    }
}
