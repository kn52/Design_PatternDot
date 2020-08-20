namespace DesignPatternDemo.Creational.AbstractFactory
{
    using System;
    public class AbFactory
    {
        public static void AFactory()
        {
            Console.WriteLine("=====Abstract Factory Pattern=====");
            Console.WriteLine();
            IAnimal animal = AnimalFactory.CreateAnimalFactory("Land").GetAnimal("Lion");
            Console.WriteLine("=====Animal Information=====");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            Console.WriteLine(animal.GetType().Name + " Speak : " + animal.Speak());
        }
    }
}
