﻿namespace DesignPatternDemo.Creational.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct() => this.MakeProduct();
    }

    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new MoneyBack();
    }

    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new Platinum();
    }
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new Titanium();
    }
}
