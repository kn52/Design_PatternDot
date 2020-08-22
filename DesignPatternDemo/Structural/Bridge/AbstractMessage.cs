namespace DesignPatternDemo.Structural.Bridge
{
    using System;
    public abstract class AbstractMessage
    {
        protected IMessageSender messageSender;
        public abstract void SendMessage(string Message);
    }

    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender) => this.messageSender = messageSender;
        public override void SendMessage(string Message)
        {
            if (Message.Length <= 60)
            {
                messageSender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 60 characters");
            }
        }
    }

    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSendor) => this.messageSender = messageSendor;
        public override void SendMessage(string Message) => messageSender.SendMessage(Message);
    }
}
