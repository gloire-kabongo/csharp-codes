using System.Collections.Generic;
using LibraryManager.Utils;

namespace LibraryManager.Models
{
    public class Bibliotheque
    {
        private readonly int capacité;
        private List<Document> documents;

        public Bibliotheque(int capacité)
        {
            this.capacité = capacité;
            documents = new List<Document>();
        }

        public List<Document> GetDocuments() => documents;

        public Document Document(int i)
        {
            if (documents.Count >= i && i >= 0)
            {
                var document = documents[i];
                return document;
            }
            else return null;
        }

        public Result AddDocument(Document document)
        {
            if (document == null)
                return Result.Failure("Le document est null");
            if (documents.Count >= capacité)
                return Result.Failure("Capacité maximale atteinte");
            documents.Add(document);
            return Result.Ok();
        }

        public Result RemoveDocument(Document document)
        {
            if (document == null)
                return Result.Failure("Le document est null");
            if (documents.Count == 0)
                return Result.Failure("La bibliotheque ne contient pas de livres");
            documents.Remove(document);
            return Result.Ok();
        }

        public List<string> GetAuteurs()
        {
            var auteurs = new List<string>();
            foreach (var document in documents)
            {
                if (document is Livre livre)
                    auteurs.Add(livre.GetAuteurs());
            }
            return auteurs;
        }
    }
}