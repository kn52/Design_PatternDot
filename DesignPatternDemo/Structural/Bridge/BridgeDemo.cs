namespace DesignPatternDemo.Structural.Bridge
{
    using System;
    public class BridgeDemo
    {
        public static void Bridge()
        {
            Console.WriteLine("=====Bridge Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Messaging=====");
            int messageType = 2;
            string message = "We shall meet at a coffee shop in Istanbul near my home.";
            if (messageType == 1)
            {
                AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
                longMessage.SendMessage(message);
            }
            else
            {
                AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
                shortMessage.SendMessage(message);
            }
        }
    }
}
