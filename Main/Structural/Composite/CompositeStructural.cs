namespace Main.Composite
{
    public static class CompositeStructural
    {
        public static void Execute()
        {
            Composite lRoot = new Composite("Root");
            lRoot.Add(new Leaf("Leaf A"));
            lRoot.Add(new Leaf("Leaf B"));

            Composite lComposite = new Composite("Composite X");
            lComposite.Add(new Leaf("Leaf XA"));
            lComposite.Add(new Leaf("Leaf XB"));

            lRoot.Add(lComposite);
            lRoot.Add(new Leaf("Leaf C"));

            Leaf lLeaf = new Leaf("Leaf D");
            lRoot.Add(lLeaf);
            lRoot.Remove(lLeaf);

            // Recursively display tree
            lRoot.Display(1);
        }
    }

    public abstract class Component
    {
        protected string _Name;

        public Component(string prName)
        {
            _Name = prName;
        }

        public abstract void Display(int prDepth);
    }

    public class Composite : Component
    {
        private List<Component> _Children = new List<Component>();

        public Composite(string prName)
            : base(prName)
        {
        }

        public void Add(Component prComponent)
        {
            _Children.Add(prComponent);
        }

        public void Remove(Component prComponent)
        {
            _Children.Remove(prComponent);
        }

        public override void Display(int prDepth)
        {
            Console.WriteLine(new String('-', prDepth) + _Name);

            // Recursively display child nodes
            foreach (Component lComponentCurrent in _Children)
            {
                lComponentCurrent.Display(prDepth + 2);
            }
        }
    }

    public class Leaf : Component
    {
        // Constructor
        public Leaf(string prName)
            : base(prName)
        {
        }

        public override void Display(int prDepth)
        {
            Console.WriteLine(new String('-', prDepth) + _Name);
        }
    }
}