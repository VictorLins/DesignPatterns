namespace Main.Facade
{
    public static class FacadePractical
    {
        public static void Execute()
        {
            OrderFacade lOrderFacade = new OrderFacade();
            lOrderFacade.OrderFood();
        }
    }

    public class OrderFacade
    {
        private Waiter _Waiter;
        private Kitchen _Kitchen;

        public OrderFacade()
        {
            _Waiter = new Waiter();
            _Kitchen = new Kitchen();
        }
        public void OrderFood()
        {
            _Waiter.WriteOrder();
            _Waiter.SendToKitchen();
            _Kitchen.PrepareFood();
            _Kitchen.CallWaiter();
            _Waiter.ServerCustomer();
            _Kitchen.WashDishes();
        }
    }

    public class Waiter
    {
        public void WriteOrder()
        {
            Console.WriteLine("Waiter - Writting Order...");
        }

        public void SendToKitchen()
        {
            Console.WriteLine("Waiter - Sending To Kitchen...");
        }

        public void ServerCustomer()
        {
            Console.WriteLine("Waiter - Serving Customer...");
        }
    }

    public class Kitchen
    {
        public void PrepareFood()
        {
            Console.WriteLine("Kitchen - Preparing Food...");
        }

        public void CallWaiter()
        {
            Console.WriteLine("Kitchen - Calling Waiter...");
        }

        public void WashDishes()
        {
            Console.WriteLine("Kitchen - Washing Dishes...");
        }
    }
}