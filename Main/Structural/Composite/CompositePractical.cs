namespace Main.Composite
{
    public static class CompositePractical
    {
        public static void Execute()
        {
            ManagementMember lDirector = new ManagementMember("Director");

            ManagementMember lManagerDeptA = new ManagementMember("Manager Department A");
            lManagerDeptA.Add(new StaffMember("Staff 1 Department A"));
            lManagerDeptA.Add(new StaffMember("Staff 2 Department A"));
            ManagementMember lSupervisorDeptA = new ManagementMember("Supervisor Department A");
            lSupervisorDeptA.Add(new StaffMember("Staff 3 Department A"));
            lSupervisorDeptA.Add(new StaffMember("Staff 4 Department A"));
            lManagerDeptA.Add(lSupervisorDeptA);

            ManagementMember lManagerDeptB = new ManagementMember("Manager Department B");
            lManagerDeptB.Add(new StaffMember("Staff 1 Department B"));
            lManagerDeptB.Add(new StaffMember("Staff 2 Department B"));
            lManagerDeptB.Add(new StaffMember("Staff 3 Department B"));
            lManagerDeptB.Add(new StaffMember("Staff 4 Department B"));

            lDirector.Add(lManagerDeptA);
            lDirector.Add(lManagerDeptB);

            lDirector.Display(1);
        }                                                         
    }

    public abstract class Employee
    {
        protected string _Name;

        public Employee(string prName)
        {
            _Name = prName;
        }

        public abstract void Display(int prDepth);
    }

    public class ManagementMember : Employee
    {
        private List<Employee> _Employees = new List<Employee>();

        public ManagementMember(string prName)
            : base(prName)
        {
        }

        public void Add(Employee prEmployee)
        {
            _Employees.Add(prEmployee);
        }

        public void Remove(Employee prEmployee)
        {
            _Employees.Remove(prEmployee);
        }

        public override void Display(int prDepth)
        {
            Console.WriteLine(new String('-', prDepth) + _Name);

            // Recursively display child nodes
            foreach (Employee lEmployeeCurrent in _Employees)
            {
                lEmployeeCurrent.Display(prDepth + 2);
            }
        }
    }

    public class StaffMember : Employee
    {
        // Constructor
        public StaffMember(string prName)
            : base(prName)
        {
        }

        public override void Display(int prDepth)
        {
            Console.WriteLine(new String('-', prDepth) + _Name);
        }
    }
}