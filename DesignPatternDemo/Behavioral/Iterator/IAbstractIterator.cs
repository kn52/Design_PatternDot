namespace DesignPatternDemo.Behavioral.Iterator
{
    interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }

    public class Iterator : IAbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Gets first item
        public Employee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }
        public Employee Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployee(current);
            }
            else
            {
                return null;
            }
        }
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}
