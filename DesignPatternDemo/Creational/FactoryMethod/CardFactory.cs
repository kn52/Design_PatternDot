namespace DesignPatternDemo.Creational.FactoryMethod
{
    using System;
    public class CardFactory
    {
        public static void Factory()
        {
            Console.WriteLine("=====Factory Method Pattern=====");
            Console.WriteLine();
            ICreditCard creditCard = new TitaniumFactory().CreateProduct();
            Console.WriteLine("=====Credit Card Information=====");
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
    }
}
