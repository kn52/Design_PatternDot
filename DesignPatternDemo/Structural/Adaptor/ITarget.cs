namespace DesignPatternDemo.Structural.Adaptor
{
    using System.Collections.Generic;
    public interface ITarget
    {
        List<string> GetProducts();
    }

    public class VendorAdapter : ITarget
    {
        public List<string> GetProducts()
        {
            VendorAdaptee adaptee = new VendorAdaptee();
            return adaptee.GetListOfProducts();
        }
    }
}
