﻿namespace DesignPatternDemo.Structural.Decorator
{
    using System;
    public class DecoratorDemo
    {
        public static void Decorator()
        {
            Console.WriteLine("=====Decorator Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Car=====");
            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();
            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
        }
    }
}