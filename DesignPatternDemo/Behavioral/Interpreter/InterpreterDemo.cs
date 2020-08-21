namespace DesignPatternDemo.Behavioral.Interpreter
{
    using System;
    using System.Collections.Generic;
    public class InterpreterDemo
    {
        public static void Interpreter()
        {
            Console.WriteLine("=====Interpreter Pattern=====");
            Console.WriteLine();
            Console.WriteLine("=====Date Expression=====");
            List<IAbstractExpression> objExpressions = new List<IAbstractExpression>();
            Context context = new Context(DateTime.Now);
            Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");
            context.expression = Console.ReadLine();
            string[] strArray = context.expression.Split(' ');
            foreach (var item in strArray)
            {
                if (item == "DD")
                {
                    objExpressions.Add(new DayExpression());
                }
                else if (item == "MM")
                {
                    objExpressions.Add(new MonthExpression());
                }
                else if (item == "YYYY")
                {
                    objExpressions.Add(new YearExpression());
                }
            }
            objExpressions.Add(new SeparatorExpression());
            foreach (var obj in objExpressions)
            {
                obj.Evaluate(context);
            }
            Console.WriteLine(context.expression);
        }
    }
}
