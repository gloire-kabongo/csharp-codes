using System;
using LibraryManager.Models;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var bib = new Bibliotheque(10);
            var capacite = bib.Capacité;

            var document = new Document(1, "titre");
            bib.AddDocument(document);

            document.NumeroEnregistrement = 56;

            var a = document.NumeroEnregistrement;


            document.Titre = "Bonjour le monde";
            var b = document.Titre;

            var doc1 = new Document(3, "Vade mecum");
            var doc2 = new Document(5, "L'odysée");
            bib.AddDocument(doc1);
            bib.AddDocument(doc2);

            var documents = bib.Documents;
            foreach (var doc in documents)
            {
                Console.WriteLine(doc.Titre);
            }
        }
    }
}
