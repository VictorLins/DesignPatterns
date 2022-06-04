namespace Main.State
{
    public static class StatePractical
    {
        public static void Execute()
        {
            DocumentContext lDocumentContext = new DocumentContext(new Draft());

            Console.WriteLine("\\\\ Calling method \"GoToNextStatus\" - Result: ");
            lDocumentContext.GoToNextStatus();

            Console.WriteLine("\n\r\\\\ Calling method \"GoToNextStatus\" - Result: ");
            lDocumentContext._DocumentContent = "Lorem ipsum";
            lDocumentContext.GoToNextStatus();

            Console.WriteLine("\n\r\\\\ Calling method \"GoToNextStatus\" - Result: ");
            lDocumentContext._DocumentContent = "Lorem ipsum dolor sit amet";
            lDocumentContext.GoToNextStatus();

            Console.WriteLine("\n\r\\\\ Calling method \"GoToNextStatus\" - Result: ");
            lDocumentContext.GoToNextStatus();

            Console.WriteLine("\n\r\\\\ Calling method \"GoToNextStatus\" - Result: ");
            lDocumentContext.GoToNextStatus();
        }
    }

    public abstract class DocumentState
    {
        public abstract void GoToNextStatus(DocumentContext prDocumentContext);
        public abstract void Close(DocumentContext prDocumentContext);
        public abstract void Publish(DocumentContext prDocumentContext);
    }

    public class Draft : DocumentState
    {
        public override void GoToNextStatus(DocumentContext prDocumentContext)
        {
            if (string.IsNullOrWhiteSpace(prDocumentContext._DocumentContent))
                Console.WriteLine("Is not possible to send a document with empty content for review");
            else
            {
                Console.WriteLine("Document submitted to review");
                prDocumentContext.DocumentState = new InReview();
            }
        }

        public override void Close(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Is not possible to close a document in the status \"Draft\"");
        }

        public override void Publish(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Is not possible to publish a document in the status \"Draft\"");
        }
    }

    public class InReview : DocumentState
    {
        public override void GoToNextStatus(DocumentContext prDocumentContext)
        {
            if (prDocumentContext._DocumentContent.Length < 15)
            {
                Console.WriteLine("Document rejected as the content has less than 15 characters");
                prDocumentContext.DocumentState = new Rejected();
            }
            else
            {
                Console.WriteLine("Review approved");
                prDocumentContext.DocumentState = new Approved();
            }
        }

        public override void Close(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Document closed");
            prDocumentContext.DocumentState = new Closed();
        }

        public override void Publish(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Is not possible to publish a document in the status \"In Review\"");
        }
    }

    public class Approved : DocumentState
    {
        public override void GoToNextStatus(DocumentContext prDocumentContext)
        {
            Publish(prDocumentContext);
        }

        public override void Close(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Document closed");
            prDocumentContext.DocumentState = new Closed();
        }

        public override void Publish(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Document published");
            prDocumentContext.DocumentState = new Published();
        }
    }

    public class Rejected : DocumentState
    {
        public override void GoToNextStatus(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Document already in the last status (Rejected)");
        }

        public override void Close(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Is not possible to close a rejected document");
        }

        public override void Publish(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Is not possible to publish a document in the status \"Rejected\"");
        }
    }

    public class Published : DocumentState
    {
        public override void GoToNextStatus(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Document already in the last status (Published)");
        }

        public override void Close(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Is not possible to close a published document");
        }

        public override void Publish(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Document already published");
        }
    }

    public class Closed : DocumentState
    {
        public override void GoToNextStatus(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Document already in the last status (Closed)");
        }

        public override void Close(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Document already closed");
        }

        public override void Publish(DocumentContext prDocumentContext)
        {
            Console.WriteLine("Is not possible to publish a closed document");
        }
    }

    public class DocumentContext
    {
        private DocumentState _DocumentState;
        public string _DocumentContent;

        public DocumentContext(DocumentState prDocumentState)
        {
            _DocumentState = prDocumentState;
        }

        public DocumentState DocumentState
        {
            get { return _DocumentState; }
            set
            {
                if (value != _DocumentState)
                {
                    Console.WriteLine($"<< Document state changed from {_DocumentState.GetType().Name} to {value.GetType().Name} >>");
                    _DocumentState = value;
                }
            }
        }

        public void GoToNextStatus() { _DocumentState.GoToNextStatus(this); }
        public void Close() { _DocumentState.Close(this); }
        public void Publish() { _DocumentState.Publish(this); }
    }
}