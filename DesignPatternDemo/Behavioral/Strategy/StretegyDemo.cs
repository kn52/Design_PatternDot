namespace DesignPatternDemo.Behavioral.Strategy
{
    using System;
    public class StretegyDemo
    {
        public static void Strategy()
        {
            Console.WriteLine("=====Observer Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Traveling=====");
            string travelType = "bus";

            TravelContext ctx = null;
            ctx = new TravelContext();
            if ("Bus".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetTravelStrategy(new BusTravelStrategy());
            }
            else if ("Train".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetTravelStrategy(new TrainTravelStrategy());
            }
            else if ("Taxi".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetTravelStrategy(new TaxiTravelStrategy());
            }
            else if ("Auto".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetTravelStrategy(new AutoTravelStrategy());
            }
            ctx.gotoAirport();
        } 
    }
}
