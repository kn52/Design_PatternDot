namespace DesignPatternDemo.Structural.Facade
{
    using System;
    public class FacadeDemo
    {
        public static void Facade()
        {
            Console.WriteLine("=====Facade Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Order=====");
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}
