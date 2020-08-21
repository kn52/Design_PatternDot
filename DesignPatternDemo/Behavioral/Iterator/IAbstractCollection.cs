namespace DesignPatternDemo.Behavioral.Iterator
{
    using System;
    using System.Collections.Generic;

    interface IAbstractCollection
    {
        Iterator GetCreateIterator();
    }

    public class ConcreteCollection : IAbstractCollection
    {
        private List<Employee> listEmployees = new List<Employee>();

        public Iterator GetCreateIterator() => new Iterator(this);

        public int Count => listEmployees.Count;
        public void AddEmployee(Employee employee) => listEmployees.Add(employee);
        public Employee GetEmployee(int IndexPosition) => listEmployees[IndexPosition];
    }
}
