namespace DesignPatternDemo.Creational.Builder
{
    using System;
    public class BeverageDirector
    {
        public static void GetBeverageDetail()
        {
            var beverage = MakeBeverage(new CoffeeBuilder());
            Console.WriteLine();
            Console.WriteLine(beverage.ShowBeverage());
        }

        private static Beverage MakeBeverage(BeverageBuilder beverageBuilder)
        {
            Console.WriteLine("=====Builder Pattern=====");
            Console.WriteLine();
            beverageBuilder.CreateBeverage();
            beverageBuilder.SetBeverageType();
            beverageBuilder.SetWater();
            beverageBuilder.SetMilk();
            beverageBuilder.SetSugar();
            beverageBuilder.SetPowderQuantity();

            return beverageBuilder.GetBeverage();
        }
    }
}
