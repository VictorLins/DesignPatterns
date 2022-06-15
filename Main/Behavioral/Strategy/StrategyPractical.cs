namespace Main.Strategy
{
    public static class StrategyPractical
    {
        public static void Execute()
        {
            SortedListContext lSortedListContext = new SortedListContext();
            lSortedListContext.AddItem("D");
            lSortedListContext.AddItem("B");
            lSortedListContext.AddItem("A");
            lSortedListContext.AddItem("C");
            lSortedListContext.AddItem("E");
            lSortedListContext.AddItem("G");
            lSortedListContext.AddItem("F");

            lSortedListContext.SetSortStrategy(new Ascending());
            lSortedListContext.Sort();

            lSortedListContext.SetSortStrategy(new Descending());
            lSortedListContext.Sort();

            lSortedListContext.SetSortStrategy(new Random());
            lSortedListContext.Sort();
        }
    }

    public abstract class SortStrategy
    {
        public abstract List<string> Sort(List<string> prItems);
    }

    public class Ascending : SortStrategy
    {
        public override List<string> Sort(List<string> prItems)
        {
            prItems = prItems.OrderBy(x => x).ToList();
            Console.WriteLine("Ascending Strategy - Result: " + String.Join(", ", prItems));
            return prItems;
        }
    }

    public class Descending : SortStrategy
    {
        public override List<string> Sort(List<string> prItems)
        {
            prItems = prItems.OrderByDescending(x => x).ToList();
            Console.WriteLine("Descending Strategy - Result: " + String.Join(", ", prItems));
            return prItems;
        }
    }

    public class Random : SortStrategy
    {
        public override List<string> Sort(List<string> prItems)
        {
            prItems = prItems.OrderBy(x => System.Guid.NewGuid().ToString()).ToList();
            Console.WriteLine("Random Strategy - Result: " + String.Join(", ", prItems));
            return prItems;
        }
    }

    public class SortedListContext
    {
        private List<string> _Items = new List<string>();
        private SortStrategy _SortStrategy;

        public void SetSortStrategy(SortStrategy prSortStrategy)
        {
            this._SortStrategy = prSortStrategy;
        }

        public void AddItem(string prItem)
        {
            _Items.Add(prItem);
        }

        public void Sort()
        {
            _SortStrategy.Sort(_Items);
        }
    }
}