namespace DesignPatternDemo.Behavioral.Strategy
{
    public class TravelContext
    {
        private ITravelStrategy travelStrategy;
        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            this.travelStrategy = strategy;
        }
        public void gotoAirport()
        {
            travelStrategy.GotoAirport();
        }
    }
}
