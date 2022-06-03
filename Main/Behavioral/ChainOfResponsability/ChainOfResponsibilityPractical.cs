namespace Main.ChainOfResponsability
{
    public static class ChainOfResponsibilityPractical
    {
        public static void Execute()
        {
            Approver lAssistantManager = new AssistantManager();
            Approver lManager = new Manager();
            Approver lDirector = new Director();

            lAssistantManager.SetSuccessor(lManager);
            lManager.SetSuccessor(lDirector);

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Requesting approval for a order of cost USD 50.");
            lAssistantManager.ApproveOrder(50);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Requesting approval for a order of cost USD 250.");
            lAssistantManager.ApproveOrder(250);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Requesting approval for a order of cost USD 500.");
            lAssistantManager.ApproveOrder(500);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Requesting approval for a order of cost USD 600.");
            lAssistantManager.ApproveOrder(600);
        }
    }

    public abstract class Approver
    {
        protected Approver _SuccessorApprover;
        public void SetSuccessor(Approver prApprover)
        {
            _SuccessorApprover = prApprover;
        }
        public abstract void ApproveOrder(int prCost);
    }

    public class AssistantManager : Approver
    {
        public override void ApproveOrder(int prCost)
        {
            if (prCost <= 50)
                Console.WriteLine("Assistant Manager - Order Approved. Cost: USD" + prCost);
            else
            {
                Console.WriteLine("Assistant Manager - Can't approve (cost > 50), sending to next approver in the hierarchy.");

                if (_SuccessorApprover != null)
                    _SuccessorApprover.ApproveOrder(prCost);
            }
        }
    }

    public class Manager : Approver
    {
        public override void ApproveOrder(int prCost)
        {
            if (prCost <= 250)
                Console.WriteLine("Manager - Order Approved. Cost: USD" + prCost);
            else
            {
                Console.WriteLine("Manager - Can't approve (cost > 250), sending to next approver in the hierarchy.");

                if (_SuccessorApprover != null)
                    _SuccessorApprover.ApproveOrder(prCost);
            }
        }
    }

    public class Director : Approver
    {
        public override void ApproveOrder(int prCost)
        {
            if (prCost <= 500)
                Console.WriteLine("Director - Order Approved. Cost: USD" + prCost);
            else
                Console.WriteLine("Director - Not approved, cost is too high");
        }
    }
}