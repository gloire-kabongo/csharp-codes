using System;
using System.Collections.Generic;
using LibraryManager.Models;
using LibraryManager.Models.Enums;

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

            var auteurs = new List<Auteur>
            {
                new Auteur("Hugo", "Victor"),
                new Auteur ("Dumas", "Alexndre")
            };

            bib.AddDocument(new Roman(1,
                "Notre dame de Paris",
                auteurs,
                586, PrixLitteraire.Goncourt));
            bib.AddDocument(new Revue(2, "Jeune Afrique", 12, 2019));
            bib.AddDocument(new Dictionnaire(3, "Larousse de Poche", Langue.Francais ));


            var livre = new Livre(15, "The C# Programmer’s Study Guide (MCSD)",
                new List<Auteur>(), 482);
            livre.AddAuteur(new Auteur("Asad", "Ali"));


            bib.AddDocument(livre);

            livre.AddAuteur(new Auteur("Ali", "Hamza"));
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
