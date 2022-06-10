using System.Collections;

namespace Main.Iterator
{
    public static class IteratorPractical
    {
        public static void Execute()
        {
            OfficeFiles lOfficeFiles = new OfficeFiles();
            lOfficeFiles[0] = new File() { Name = "File001_PB", IsPrivate = false };
            lOfficeFiles[1] = new File() { Name = "File002_PV", IsPrivate = true };
            lOfficeFiles[2] = new File() { Name = "File003_PB", IsPrivate = false };
            lOfficeFiles[3] = new File() { Name = "File004_PV", IsPrivate = true };
            lOfficeFiles[4] = new File() { Name = "File005_PB", IsPrivate = false };
            lOfficeFiles[5] = new File() { Name = "File006_PV", IsPrivate = true };

            FileIterator lFileIterator = lOfficeFiles.CreateIterator();
            Console.WriteLine("Iterating over files using \"Public File Iterator\": ");

            File lFile = lFileIterator.First();
            Console.WriteLine("First File: " + lFile.Name);

            lFile = lFileIterator.Next();
            Console.WriteLine("Next File: " + lFile.Name);

            List<File> lFiles = lFileIterator.GetAll();
            Console.WriteLine("All Files: " + String.Join(", ", lFiles.Select(X => X.Name).ToList()));

            lFileIterator = new PrivateFileIterator(lOfficeFiles);
            Console.WriteLine("\n\rIterating over files using \"Private File Iterator\": ");

            lFile = lFileIterator.First();
            Console.WriteLine("First File: " + lFile.Name);

            lFile = lFileIterator.Next();
            Console.WriteLine("Next File: " + lFile.Name);

            lFiles = lFileIterator.GetAll();
            Console.WriteLine("All Files: " + String.Join(", ", lFiles.Select(X => X.Name).ToList()));
        }
    }

    // Aggregate (Concrete)
    public class OfficeFiles
    {
        private ArrayList _Items = new ArrayList();

        public FileIterator CreateIterator()
        {
            return new PublicFileIterator(this);
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

    // Iterator
    public abstract class FileIterator
    {
        public abstract File First();
        public abstract File Next();
        public abstract List<File> GetAll();
        public abstract File CurrentItem();
    }

    // Concrete Iterator
    public class PublicFileIterator : FileIterator
    {
        private OfficeFiles _OfficeFiles;
        private int _CurrentElement = 0;

        public PublicFileIterator(OfficeFiles prOfficeFiles)
        {
            _OfficeFiles = prOfficeFiles;
            this.First(); // To set the correct _CurrentElement
        }

        public override File First()
        {
            for (int i = 0; i < _OfficeFiles.Count; i++)
            {
                if (((File)_OfficeFiles[i]).IsPrivate == false)
                {
                    _CurrentElement = i;
                    return ((File)_OfficeFiles[_CurrentElement]);
                }

            }
            return null;
        }

        public override File Next()
        {
            object lResult = null;

            for (int i = _CurrentElement; i < _OfficeFiles.Count; i++)
            {
                _CurrentElement++;
                if (((File)_OfficeFiles[_CurrentElement]).IsPrivate == false)
                    return ((File)_OfficeFiles[_CurrentElement]);
            }

            return null;
        }

        public override List<File> GetAll()
        {
            List<File> lResult = new List<File>();

            for (int i = 0; i < _OfficeFiles.Count; i++)
            {
                if (((File)_OfficeFiles[i]).IsPrivate == false)
                    lResult.Add(((File)_OfficeFiles[i]));
            }

            return lResult;
        }

        public override File CurrentItem()
        {
            return ((File)_OfficeFiles[_CurrentElement]);
        }
    }

    // Concrete Iterator
    public class PrivateFileIterator : FileIterator
    {
        private OfficeFiles _OfficeFiles;
        private int _CurrentElement = 0;

        public PrivateFileIterator(OfficeFiles prOfficeFiles)
        {
            _OfficeFiles = prOfficeFiles;
            _OfficeFiles = prOfficeFiles;
            this.First(); // To set the correct _CurrentElement
        }

        public override File First()
        {
            for (int i = 0; i < _OfficeFiles.Count; i++)
            {
                if (((File)_OfficeFiles[i]).IsPrivate == true)
                {
                    _CurrentElement = i;
                    return ((File)_OfficeFiles[_CurrentElement]);
                }

            }
            return null;
        }

        public override File Next()
        {
            object lResult = null;

            for (int i = _CurrentElement; i < _OfficeFiles.Count; i++)
            {
                _CurrentElement++;
                if (((File)_OfficeFiles[_CurrentElement]).IsPrivate == true)
                    return ((File)_OfficeFiles[_CurrentElement]);
            }

            return null;
        }

        public override List<File> GetAll()
        {
            List<File> lResult = new List<File>();

            for (int i = 0; i < _OfficeFiles.Count; i++)
            {
                if (((File)_OfficeFiles[i]).IsPrivate == true)
                    lResult.Add(((File)_OfficeFiles[i]));
            }

            return lResult;
        }

        public override File CurrentItem()
        {
            return ((File)_OfficeFiles[_CurrentElement]);
        }
    }

    public class File
    {
        public string Name { get; set; }
        public bool IsPrivate { get; set; }
    }
}