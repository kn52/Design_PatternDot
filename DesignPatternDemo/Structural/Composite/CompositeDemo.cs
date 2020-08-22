namespace DesignPatternDemo.Structural.Composite
{
    using System;
    public class CompositeDemo
    {
        public static void Composite()
        {
            Console.WriteLine("=====Composite Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Computer=====");
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);

            Composite motherBoard = new Composite("Peripherals");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);

            computer.DisplayPrice();
            Console.WriteLine();

            keyboard.DisplayPrice();
            Console.WriteLine();

            cabinet.DisplayPrice();
        }
    }
}
