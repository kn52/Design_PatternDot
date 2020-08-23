namespace DesignPatternDemo.Structural.Facade
{
    using System;
    public class Order
    {
        public void PlaceOrder()
        {
            int count = 0;
            Console.WriteLine("Place Order Started");
            while (choice.ToLower().Equals("y"))
            {
                Console.Clear();
                Console.WriteLine("=====Structural Design Pattern====");
                Console.WriteLine("1. Get Orders");
                Console.WriteLine("2. Payment");
                Console.WriteLine("3. Get invoice summary");
                Console.WriteLine("n. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Product product = new Product();
                        count++;
                        product.GetProductDetails();
                        break;

                    case "2":
                        Payment payment = new Payment();
                        count++;
                        payment.MakePayment();
                        break;

                    case "3":
                        Invoice invoice = new Invoice();
                        count++;
                        invoice.Sendinvoice();
                        if (count == 3)
                        {
                            order = true;
                        }
                        break;

                    case "n":
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine();
                Console.Write("Enter y to see other structural patterns or 'n' to exit: ");
                this.choice = Console.ReadLine();
            }

            if (order)
            {
                Console.WriteLine("Order Placed Successfully");
            }
        }

        private bool order = false;
        private string choice = "y";
        
    }
}
