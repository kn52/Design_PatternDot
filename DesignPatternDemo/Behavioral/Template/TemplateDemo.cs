namespace DesignPatternDemo.Behavioral.Template
{
    using System;
    public class TemplateDemo
    {
        public static void Template()
        {
            Console.WriteLine("=====Template Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====House Building=====");
            Console.WriteLine("Build a Concrete House\n");
            HouseTemplate houseTemplate = new ConcreteHouse();
            houseTemplate.BuildHouse();
            Console.WriteLine();
            Console.WriteLine("Build a Wooden House\n");
            houseTemplate = new WoodenHouse();
            houseTemplate.BuildHouse();
        }
    }
}
