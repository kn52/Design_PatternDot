namespace DesignPatternDemo.Behavioral.Visitor
{
    using System;
    public interface IVisitor
    {
        void Visit(IElement element);
    }

    public class Doctor : IVisitor
    {
        public string Name { get; set; }
        public Doctor(string name) => Name = name;

        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Doctor: " + this.Name + " did the health checkup of the child: " + kid.KidName);
        }
    }

    public class Salesman : IVisitor
    {
        public string Name { get; set; }
        public Salesman(string name) => Name = name;
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Salesman: " + this.Name + " gave the school bag to the child: "
                            + kid.KidName);
        }
    }
}
