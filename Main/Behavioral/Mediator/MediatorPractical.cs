namespace Main.Mediator
{
    public static class MediatorPractical
    {
        public static void Execute()
        {
            Chatroom lChatroom = new Chatroom();

            // Create participants
            Participant lGeorge = new Teacher("George");
            Participant lPaul = new Studant("Paul");
            Participant lRingo = new Studant("Ringo");
            Participant lJohn = new Studant("John");

            // Register them
            lChatroom.Register(lGeorge);
            lChatroom.Register(lPaul);
            lChatroom.Register(lRingo);
            lChatroom.Register(lJohn);

            // Chatting participants
            lPaul.Send("George", "Hi Teacher!");
            lGeorge.Send("Paul", "Hi Paul, how are you?");
            lPaul.Send("George", "I am good thanks");
            lGeorge.Send("John", "John, did you finish your homework?");
            lJohn.Send("George", "Hi Teacher, yes I did");
            lGeorge.Send("Ringo", "Ringo, what about you?");
            lRingo.Send("George", "Hi Teacher, I finished as well");
        }
    }

    public abstract class AbstractChatroom
    {
        public abstract void Register(Participant prParticipant);
        public abstract void Send(string prFrom, string prTo, string prMessage);
    }

    public class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> _Participants = new Dictionary<string, Participant>();

        public override void Register(Participant prParticipant)
        {
            if (!_Participants.ContainsValue(prParticipant))
                _Participants[prParticipant._Name] = prParticipant;

            prParticipant._Chatroom = this;
        }

        public override void Send(string prFrom, string prTo, string prMessage)
        {
            Participant lParticipant = _Participants[prTo];

            if (lParticipant != null)
                lParticipant.Receive(prFrom, prMessage);
        }
    }

    public class Participant
    {
        public Chatroom _Chatroom { get; set; }
        public string _Name { get; set; }

        public Participant(string prName)
        {
            _Name = prName;
        }

        public void Send(string prTo, string prMessage)
        {
            _Chatroom.Send(_Name, prTo, prMessage);
        }

        public virtual void Receive(string prFrom, string prMessage)
        {
            Console.WriteLine("{0} to {1}: '{2}'", prFrom, _Name, prMessage);
        }
    }

    public class Teacher : Participant
    {
        public Teacher(string prName) : base(prName) { }

        public override void Receive(string prFrom, string prMessage)
        {
            Console.Write("To a Teacher: ");
            base.Receive(prFrom, prMessage);
        }
    }

    public class Studant : Participant
    {
        public Studant(string prName) : base(prName) { }

        public override void Receive(string prFrom, string prMessage)
        {
            Console.Write("To a Studant: ");
            base.Receive(prFrom, prMessage);
        }
    }
}