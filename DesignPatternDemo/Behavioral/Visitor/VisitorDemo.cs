namespace DesignPatternDemo.Behavioral.Visitor
{
    using System;
    public class VisitorDemo
    {
        public static void Visitor()
        {
            Console.WriteLine("=====Visitor Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====School Visit=====");
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Salesman("John");
            school.PerformOperation(visitor2);
        }
    }
}
