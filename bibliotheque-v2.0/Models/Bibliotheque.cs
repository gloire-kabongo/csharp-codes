using System.Collections.Generic;

namespace LibraryManager.Models
{
    public class Bibliotheque
    {
        private readonly uint _capacité;
        private List<Document> _documents;

        public Bibliotheque(uint capacité)
        {
            _capacité = capacité;
            _documents = new List<Document>();
        }

        public uint Capacité
        {
            get
            {
                return _capacité;
            }
        }

        public List<Document> Documents
        {
            get { return _documents; }
        }

        public void AddDocument(Document document)
        {
            _documents.Add(document);
        }
    }
}