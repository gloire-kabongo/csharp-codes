using System.Collections.Generic;

using LibraryManager.Tools;
using LibraryManager.Common.Exceptions;

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

        public uint Capacité => _capacité;

        public List<Document> Documents => _documents;

        public Result AddDocument(Document document)
        {
            if (document == null) return
                Result.Failure("Impossible d'ajouter ce document!");
            if (_documents.Count >= _capacité)
                return Result.Failure("Probleme de capacite");

            _documents.Add(document);
            return Result.Ok();
        }

        public Result RemoveDocument(Document document)
        {
            if (document == null) return
                Result.Failure("Document null");
            _documents.Remove(document);
            return Result.Ok();
        }

        public Document GetByNumeroEnregistrement(uint numeroEnregistrement)
        {
            foreach (var document in _documents)
            {
                if (document.NumeroEnregistrement == numeroEnregistrement)
                    return document;
            }
            throw new DocumentNotFoundException(numeroEnregistrement);
        }
    }
}