namespace Main.Visitor
{
    public static class VisitorPractical
    {
        public static void Execute()
        {
            School lSchool = new School();
            lSchool.Attach(new Student() { _Name = "Frank" });
            lSchool.Attach(new Student() { _Name = "Matt" });
            lSchool.Attach(new Student() { _Name = "Jennifer" });

            lSchool.Accept(new Doctor());
            lSchool.Accept(new CarrerCoach());
        }
    }

    public interface IVisitor
    {
        public void Visit(Student prStudent);
    }

    public interface IElement
    {
        public void Accept(IVisitor prVisitor);
    }

    public class Student : IElement
    {
        public string _Name { get; set; }
        public void Accept(IVisitor prVisitor)
        {
            prVisitor.Visit(this);
        }
    }

    public class Doctor : IVisitor
    {
        public void Visit(Student prStudent)
        {
            Console.WriteLine($"Student \"{prStudent._Name}\" visited by {this.GetType().Name}");
        }
    }

    public class CarrerCoach : IVisitor
    {
        public void Visit(Student prStudent)
        {
            Console.WriteLine($"Student \"{prStudent._Name}\" visited by {this.GetType().Name}");
        }
    }

    public class School
    {
        private List<IElement> _Students = new List<IElement>();

        public void Attach(Student prStudent)
        {
            _Students.Add(prStudent);
        }

        public void Detach(Student prStudent)
        {
            _Students.Remove(prStudent);
        }

        public void Accept(IVisitor prVisitor)
        {
            foreach (Student lStudentCurrent in _Students)
            {
                lStudentCurrent.Accept(prVisitor);
            }
        }
    }
}