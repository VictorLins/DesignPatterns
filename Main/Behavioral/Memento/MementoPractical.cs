namespace Main.Memento
{
    public static class MementoPractical
    {
        public static void Execute()
        {
            WordDocument lWordDocument = new WordDocument();
            DocumentCaretaker lDocumentCaretaker = new DocumentCaretaker();
            
            lWordDocument.Content = "Content ABC";
            lWordDocument.SaveContentState(lDocumentCaretaker);

            lWordDocument.Content = "Content ABCDEFG";
            lWordDocument.RevertToLastSave(lDocumentCaretaker);

            lWordDocument.Content = "Content 123";
            lWordDocument.RevertToLastSave(lDocumentCaretaker);
        }
    }

    public class WordDocument
    {
        private string _Content;

        public string Content
        {
            get { return _Content; }
            set
            {
                Console.WriteLine($"WordDocument - Changing content from \"{_Content}\" to \"{value}\"");
                _Content = value;
            }
        }

        public void SaveContentState(DocumentCaretaker prDocumentCaretaker)
        {
            Console.WriteLine($"WordDocument - Saving current content");
            prDocumentCaretaker._DocumentMemento = new DocumentMemento(Content);
        }

        public void RevertToLastSave(DocumentCaretaker prDocumentCaretaker)
        {
            Console.WriteLine($"WordDocument - Restoring state...");
            Content = prDocumentCaretaker._DocumentMemento._Content;
        }
    }

    public class DocumentMemento
    {
        public string _Content { get; set; }

        public DocumentMemento(string _prContent)
        {
            _Content = _prContent;
        }
    }

    public class DocumentCaretaker
    {
        public DocumentMemento _DocumentMemento { get; set; }
    }
}