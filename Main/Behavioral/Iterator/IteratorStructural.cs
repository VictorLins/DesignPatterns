using System.Collections;

namespace Main.Iterator
{
    public static class IteratorStructural
    {
        public static void Execute()
        {
            ConcreteAggregate lConcreteAggregate = new ConcreteAggregate();
            lConcreteAggregate[0] = "Item A";
            lConcreteAggregate[1] = "Item B";
            lConcreteAggregate[2] = "Item C";
            lConcreteAggregate[3] = "Item D";

            // Create Iterator and provide aggregate
            ConcreteIterator lConcreteIterator = new ConcreteIterator(lConcreteAggregate);

            Console.WriteLine("Iterating over collection:");

            object lobject = lConcreteIterator.First();
            while (lobject != null)
            {
                Console.WriteLine(lobject);
                lobject = lConcreteIterator.Next();
            }
        }
    }

    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    public class ConcreteAggregate : Aggregate
    {
        private ArrayList _Items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _Items.Count; }
        }

        public object this[int prIndex]
        {
            get { return _Items[prIndex]; }
            set { _Items.Insert(prIndex, value); }
        }
    }

    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _ConcreteAggregate;
        private int _CurrentElement = 0;

        public ConcreteIterator(ConcreteAggregate prConcreteAggregate)
        {
            _ConcreteAggregate = prConcreteAggregate;
        }

        public override object First()
        {
            return _ConcreteAggregate[0];
        }

        public override object Next()
        {
            object lResult = null;
            if (_CurrentElement < _ConcreteAggregate.Count - 1)
            {
                lResult = _ConcreteAggregate[++_CurrentElement];
            }

            return lResult;
        }

        public override object CurrentItem()
        {
            return _ConcreteAggregate[_CurrentElement];
        }

        public override bool IsDone()
        {
            return _CurrentElement >= _ConcreteAggregate.Count;
        }
    }
}