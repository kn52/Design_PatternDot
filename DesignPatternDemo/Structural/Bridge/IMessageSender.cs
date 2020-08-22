namespace DesignPatternDemo.Structural.Bridge
{
    using System;
    public interface IMessageSender
    {
        void SendMessage(string Message);
    }

    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string Message) => Console.WriteLine("'" + Message + "'   : This Message has been sent using SMS");
    }

    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string Message) => Console.WriteLine("'" + Message + "'   : This Message has been sent using Email");
    }
}
