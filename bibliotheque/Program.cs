using System;
using System.Collections.Generic;
using LibraryManager.Models;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var bib = CreateLibrary();

            Display(bib.GetDocuments());

            GetAuteurs(bib);
        }

        private static void GetAuteurs(Bibliotheque bib)
        {
            foreach (var item in bib.GetAuteurs())
            {
                Console.WriteLine(item);
            }
        }

        static Bibliotheque CreateLibrary()
        {
            var bib = new Bibliotheque(5);

            bib.AddDocument(new Roman(1,
                "Notre dame de Paris",
                "Victor Hugo",
                586, prixLitteraire: 5));
            bib.AddDocument(new Revue(2, "Jeune Afrique", 12, 2019));
            bib.AddDocument(new Dictionnaire(3, "Larousse de Poche", "Anglais" ));

            return bib;
        }

        static void Display(List<Document> documents)
        {
            foreach (var document in documents)
            {
                Console.WriteLine(document);
            }
        }
    }
}
