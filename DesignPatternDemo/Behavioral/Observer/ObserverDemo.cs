namespace DesignPatternDemo.Behavioral.Observer
{
    using System;
    public class ObserverDemo
    {
        public static void Observer()
        {
            Console.WriteLine("=====Observer Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Online Phone Shopping=====");
            Subject redMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            Observer user1 = new Observer("Anurag", redMI);
            Observer user2 = new Observer("Pranaya", redMI);
            Observer user3 = new Observer("Priyanka", redMI);

            Console.WriteLine("Red MI Mobile current state : " + redMI.getAvailability());
            Console.WriteLine();
            redMI.setAvailability("Available");
        }
        
    }
}
