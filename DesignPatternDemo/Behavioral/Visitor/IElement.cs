namespace DesignPatternDemo.Behavioral.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class Kid : IElement
    {
        public string KidName { get; set; }

        public Kid(string name) => KidName = name;

        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
