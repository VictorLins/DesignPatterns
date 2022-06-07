namespace Main.Command
{
    public static class CommandPractical
    {
        public static void Execute()
        {
            User lUser = new User();

            // User presses calculator buttons
            lUser.Compute('+', 100);
            lUser.Compute('-', 50);
            lUser.Compute('*', 10);
            lUser.Compute('/', 2);

            // Undo 4 commands
            lUser.Undo(4);

            // Redo 3 commands
            lUser.Redo(3);
        }
    }

    public abstract class Operation
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }

    class CalculatorCommand : Operation
    {
        private char _Operator;
        private int _Operand;
        private Calculator _Calculator;

        public CalculatorCommand(Calculator prCalculator,
            char prOperator, int prOperand)
        {
            _Calculator = prCalculator;
            _Operator = prOperator;
            _Operand = prOperand;
        }

        public char Operator
        {
            set { _Operator = value; }
        }

        public int Operand
        {
            set { _Operand = value; }
        }

        public override void Execute()
        {
            _Calculator.Operation(_Operator, _Operand);
        }

        public override void UnExecute()
        {
            _Calculator.Operation(Undo(_Operator), _Operand);
        }

        private char Undo(char prOperator)
        {
            switch (prOperator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException(prOperator.ToString());
            }
        }
    }

    public class Calculator
    {
        private int _CurrentValue = 0;

        public void Operation(char prOperator, int prOperand)
        {
            int lValueBefore = _CurrentValue;

            switch (prOperator)
            {
                case '+': _CurrentValue += prOperand; break;
                case '-': _CurrentValue -= prOperand; break;
                case '*': _CurrentValue *= prOperand; break;
                case '/': _CurrentValue /= prOperand; break;
            }

            Console.WriteLine($"Operation: {lValueBefore} {prOperator} {prOperand} - Result = {_CurrentValue}");
        }
    }

    public class User
    {
        private Calculator _Calculator = new Calculator();
        private List<Operation> _PerformedCommands = new List<Operation>();
        private int _CurrentOperation = 0;

        public void Redo(int prLevels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", prLevels);

            for (int i = 0; i < prLevels; i++)
            {
                if (_CurrentOperation < _PerformedCommands.Count - 1)
                {
                    Operation lOperation = _PerformedCommands[_CurrentOperation];
                    lOperation.Execute();
                    _CurrentOperation++;
                }
            }
        }

        public void Undo(int prLevels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", prLevels);

            for (int i = 0; i < prLevels; i++)
            {
                if (_CurrentOperation > 0)
                {
                    _CurrentOperation--;
                    Operation lOperation = _PerformedCommands[_CurrentOperation] as Operation;
                    lOperation.UnExecute();
                }
            }
        }

        public void Compute(char prOperator, int prOperand)
        {
            Operation lCommand = new CalculatorCommand(_Calculator, prOperator, prOperand);
            lCommand.Execute();

            _PerformedCommands.Add(lCommand);
            _CurrentOperation++;
        }
    }
}