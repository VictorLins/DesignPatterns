namespace Main.Interpreter
{
    public static class InterpreterStructural
    {
        // Client
        public static void Execute()
        {
            Context lContext = new Context();
            lContext._UserInput = "AABBCC";

            Interpreter lInterpreter = new Interpreter();
            lInterpreter.Interprete(lContext);
        }
    }

    public class Interpreter
    {
        public void Interprete(Context prContext)
        {
            List<Expression> _Expressions = new List<Expression>();
            _Expressions.Add(new NonTerminalExpression());
            _Expressions.Add(new TerminalExpression());

            foreach (Expression lExpressionCurrent in _Expressions)
            {
                lExpressionCurrent.Evaluate(prContext);
            }
        }
    }

    public abstract class Expression
    {
        public abstract void Evaluate(Context prContext);
    }

    public class NonTerminalExpression : Expression
    {
        public override void Evaluate(Context prContext)
        {
            Console.WriteLine($"--Executing a Non-Terminal Operation with the input \"{prContext._UserInput}\"");
        }
    }

    public class TerminalExpression : Expression
    {
        public override void Evaluate(Context prContext)
        {
            Console.WriteLine($"----Executing a Terminal Operation with the input \"{prContext._UserInput}\"");
        }
    }

    public class Context
    {
        public string _UserInput { get; set; }
    }
}