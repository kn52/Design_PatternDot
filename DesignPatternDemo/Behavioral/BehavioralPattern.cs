namespace DesignPatternDemo.Behavioral
{
    using System;
    using DesignPatternDemo.Behavioral.Observer;
    using DesignPatternDemo.Behavioral.State;
    using DesignPatternDemo.Behavioral.Strategy;

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
                Console.WriteLine("2. State Pattern");
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
