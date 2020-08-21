namespace DesignPatternDemo.Behavioral.Interpreter
{
    public interface IAbstractExpression
    {
        void Evaluate(Context context);
    }

    public class DayExpression : IAbstractExpression
    {
        public void Evaluate(Context context) => context.expression = context.expression.Replace("DD", context.date.Day.ToString());
    }
    public class MonthExpression : IAbstractExpression
    {
        public void Evaluate(Context context) => context.expression = context.expression.Replace("MM", context.date.Month.ToString());
    }

    public class YearExpression : IAbstractExpression
    {
        public void Evaluate(Context context) => context.expression = context.expression.Replace("YYYY", context.date.Year.ToString());
    }

    public class SeparatorExpression : IAbstractExpression
    {
        public void Evaluate(Context context) => context.expression = context.expression.Replace(" ", "-");
    }
}
