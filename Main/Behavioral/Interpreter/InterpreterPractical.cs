namespace Main.Interpreter
{
    public static class InterpreterPractical
    {
        // Client
        public static void Execute()
        {
            CommandLineContext lCommandLineContext = new CommandLineContext();
            lCommandLineContext._UserExpression = " Lorem Ipsum Dolor Sit Amet, Consectetur -u -t";

            CommandLineInterpreter lCommandLineInterpreter = new CommandLineInterpreter();
            lCommandLineInterpreter.Interprete(lCommandLineContext);

            lCommandLineContext._UserExpression = " Lorem Ipsum Dolor Sit Amet, Consectetur -l";
            lCommandLineInterpreter.Interprete(lCommandLineContext);
        }
    }

    public class CommandLineInterpreter
    {
        public void Interprete(CommandLineContext prCommandLineContext)
        {
            List<CommandLineExpression> _CommandLineExpressions = new List<CommandLineExpression>();

            // GET EXPRESSIONS
            List<string> lExpressions = prCommandLineContext._UserExpression.Substring(prCommandLineContext._UserExpression.IndexOf("-")).Split(" ").ToList();
            
            prCommandLineContext._Result = prCommandLineContext._UserExpression.Substring(0, prCommandLineContext._UserExpression.IndexOf("-"));

            foreach (string lExpressionCUrrent in lExpressions)
            {
                switch (lExpressionCUrrent)
                {
                    case ("-u"): _CommandLineExpressions.Add(new ToUpperCaseExpression()); break;
                    case ("-l"): _CommandLineExpressions.Add(new ToLowerCaseExpression()); break;
                    case ("-t"): _CommandLineExpressions.Add(new TrimExpression()); break;
                    default: break;
                }
            }

            // EXECUTE EXPRESSIONS
            Console.WriteLine($"\n\r- INTERPRETING INPUT: \"{prCommandLineContext._Result}\"");
            foreach (CommandLineExpression lCommandLineExpressionCurrent in _CommandLineExpressions)
            {
                lCommandLineExpressionCurrent.Evaluate(prCommandLineContext);
                Console.WriteLine($"-- {lCommandLineExpressionCurrent.GetType().Name} Executed - Result: \"{prCommandLineContext._Result}\"");
            }
            Console.WriteLine($"- INTERPRETATION RESULT: \"{prCommandLineContext._Result}\"");
        }
    }

    public abstract class CommandLineExpression
    {
        public abstract void Evaluate(CommandLineContext prCommandLineContext);
    }

    public class ToUpperCaseExpression : CommandLineExpression
    {
        public override void Evaluate(CommandLineContext prCommandLineContext)
        {
            prCommandLineContext._Result = prCommandLineContext._Result.ToUpper();
        }
    }

    public class ToLowerCaseExpression : CommandLineExpression
    {
        public override void Evaluate(CommandLineContext prCommandLineContext)
        {
            prCommandLineContext._Result = prCommandLineContext._Result.ToLower();
        }
    }

    public class TrimExpression : CommandLineExpression
    {
        public override void Evaluate(CommandLineContext prCommandLineContext)
        {
            prCommandLineContext._Result = prCommandLineContext._Result.Trim();
        }
    }

    public class CommandLineContext
    {
        public string _UserExpression { get; set; }
        public string _Result { get; set; }
    }
}