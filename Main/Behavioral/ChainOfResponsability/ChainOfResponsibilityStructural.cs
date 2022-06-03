namespace Main.ChainOfResponsability
{
    public static class ChainOfResponsibilityStructural
    {
        public static void Execute()
        {
            Handler lConcreteHandler1 = new ConcreteHandler1();
            Handler lConcreteHandler2 = new ConcreteHandler2();
            Handler lConcreteHandler3 = new ConcreteHandler3();

            lConcreteHandler1.SetSuccessor(lConcreteHandler2);
            lConcreteHandler2.SetSuccessor(lConcreteHandler3);

            lConcreteHandler1.HandleRequest("AAA");
            lConcreteHandler1.HandleRequest("BBB");
        }
    }

    public abstract class Handler
    {
        protected Handler _SuccessorHandler;
        public void SetSuccessor(Handler prSuccessorHandler)
        {
            _SuccessorHandler = prSuccessorHandler;
        }
        public abstract void HandleRequest(string prRequest);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(string prRequest)
        {
            Console.WriteLine("ConcreteHandler1 - Handling Request: " + prRequest);

            if (_SuccessorHandler != null)
                _SuccessorHandler.HandleRequest(prRequest);
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(string prRequest)
        {
            Console.WriteLine("ConcreteHandler2 - Handling Request: " + prRequest);

            if (_SuccessorHandler != null)
                _SuccessorHandler.HandleRequest(prRequest);
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(string prRequest)
        {
            Console.WriteLine("ConcreteHandler3 - Handling Request: " + prRequest);

            if (_SuccessorHandler != null)
                _SuccessorHandler.HandleRequest(prRequest);
        }
    }
}