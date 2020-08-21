namespace DesignPatternDemo.Behavioral.Strategy
{
    using System;
    public interface ITravelStrategy
    {
        void GotoAirport();
    }
    public class AutoTravelStrategy : ITravelStrategy
    {
        public void GotoAirport() => Console.WriteLine("Traveler is going to Airport by Auto and will be charged Rs 600");
    }
    public class TrainTravelStrategy : ITravelStrategy
    {
        public void GotoAirport() => Console.WriteLine("Traveler is going to Airport by Train and will be charged Rs 200");
    }
    public class TaxiTravelStrategy : ITravelStrategy
    {
        public void GotoAirport() => Console.WriteLine("Traveler is going to Airport by Taxi and will be charged Rs 1000");
    }

    public class BusTravelStrategy : ITravelStrategy
    {
        public void GotoAirport() => Console.WriteLine("Traveler is going to Airport by bus and will be charged Rs 300");
    }
}
