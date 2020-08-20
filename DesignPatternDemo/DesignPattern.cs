﻿namespace DesignPatternDemo
{
    using System;
    using DesignPatternDemo.Creational;
    
    class DesignPattern
    {
        private string choice = "y";
        static void Main(string[] args)
        {
            new DesignPattern().DesignDattern();
        }

        private void DesignDattern()
        {
            while (choice.ToLower().Equals("y"))
            {
                Console.Clear();
                Console.WriteLine("=====Design Pattern====");
                Console.WriteLine("1. Creational Design Pattern");
                Console.WriteLine("n. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        new CreationalPattern().Creational();
                        break;

                    case "n":
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine();
                Console.Write("Enter y to see other design patterns or n to exit: ");
                choice = Console.ReadLine();
            }
        }
    }
}
