namespace DesignPatternDemo.Structural.Adaptor
{
    using System.Collections.Generic;
    public class VendorAdaptee
    {
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>(capacity: 5)
            {
                "Gaming Consoles",
                "Television",
                "Books",
                "Musical Instruments"
            };
            return products;
        }
    }
}
