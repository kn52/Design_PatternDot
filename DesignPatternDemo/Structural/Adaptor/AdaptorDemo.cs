namespace DesignPatternDemo.Structural.Adaptor
{
    using System;
    public class AdaptorDemo
    {
        public static void Adaptor()
        {
            Console.WriteLine("=====Adaptor Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Vendor=====");
            ITarget adapter = new VendorAdapter();
            adapter.GetProducts().ForEach(product => Console.WriteLine(product));
        }
    }
}
