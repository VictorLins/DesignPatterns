namespace Main.Visitor
{
    public static class VisitorStructural
    {
        public static void Execute()
        {
            ObjectStructure lObjectStructure = new ObjectStructure();
            lObjectStructure.Attach(new ConcreteElementA());
            lObjectStructure.Attach(new ConcreteElementB());

            ConcreteVisitor1 lConcreteVisitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 lConcreteVisitor2 = new ConcreteVisitor2();

            lObjectStructure.Accept(lConcreteVisitor1);
            lObjectStructure.Accept(lConcreteVisitor2);
        }
    }

    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA prConcreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB prConcreteElementB);
    }

    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA prConcreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
                prConcreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB prConcreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
                prConcreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA prConcreteElementA)
        {
            Console.WriteLine("{0} visited by {1}", prConcreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB prConcreteElementB)
        {
            Console.WriteLine("{0} visited by {1}", prConcreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    public abstract class Element
    {
        public abstract void Accept(Visitor prVisitor);
    }

    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor prVisitor)
        {
            prVisitor.VisitConcreteElementA(this);
        }
    }

    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor prVisitor)
        {
            prVisitor.VisitConcreteElementB(this);
        }
    }

    public class ObjectStructure
    {
        private List<Element> _Elements = new List<Element>();

        public void Attach(Element prElement)
        {
            _Elements.Add(prElement);
        }

        public void Detach(Element prElement)
        {
            _Elements.Remove(prElement);
        }

        public void Accept(Visitor prVisitor)
        {
            foreach (Element lElementCurrent in _Elements)
            {
                lElementCurrent.Accept(prVisitor);
            }
        }
    }
}