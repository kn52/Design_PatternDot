namespace DesignPatternDemo.Behavioral.State
{
    using System;
    public class StateDemo
    {
        public static void State()
        {
            Console.WriteLine("=====State Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Vending Machine=====");
            VendingMachine vendingMachine = new VendingMachine();
            Console.WriteLine("Current VendingMachine State : " + vendingMachine.vendingMachineState.GetType().Name + "\n");

            vendingMachine.DispenseProduct();
            vendingMachine.SelectProductAndInsertMoney(50, "Pepsi");
            Console.WriteLine("\nCurrent VendingMachine State : " + vendingMachine.vendingMachineState.GetType().Name + "\n");

            vendingMachine.SelectProductAndInsertMoney(50, "Fanta");
            vendingMachine.DispenseProduct();

            Console.WriteLine("\nCurrent VendingMachine State : " + vendingMachine.vendingMachineState.GetType().Name);
        }
    }
}
