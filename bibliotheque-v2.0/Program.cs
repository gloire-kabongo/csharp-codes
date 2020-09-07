using System;
using System.Collections.Generic;
using LibraryManager.Models;
using LibraryManager.Tools;
using LibraryManager.Common.Exceptions;

using static System.Console;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var bib = CreateLibrary();

            int choix;
            do
            {
                choix = Menu();
                switch (choix)
                {
                    case 1:
                        var documents = bib.Documents;
                        Display(documents);
                        break;
                    case 2:
                        Add(bib);
                        break;
                    case 9:
                        Quitter();
                        break;
                }
            } while (choix < 9);

            //AddAvis(bib);
        }

        static void Quitter()
        {
            WriteLine("Programme terminé !");
        }

        static Bibliotheque CreateLibrary()
        {
            uint capacité = 10; //
            var bib = new Bibliotheque(capacité);
            return bib;
        }

        static void Display(List<Document> documents)
        {
            WriteLine();
            WriteLine("Liste des documents");
            foreach (var doc in documents)
            {
                WriteLine(doc);
                WriteLine();
            }
        }

        static void Add(Bibliotheque bib)
        {
            WriteLine();
            WriteLine("Ajout des documents");

            Write("Numero Enregistrement: ");
            var numeroEnregistrement = int.Parse(ReadLine());
            Write("Titre: ");
            var titre = ReadLine();

            var document = new Document(numeroEnregistrement, titre);
            var result = bib.AddDocument(document);
            DisplayResult(result);

            void DisplayResult(Result r)
            {
                if (!result.Success)
                {
                    WriteLine(result.Error);
                }
                else WriteLine("Document successfully added");
            }
        }

        static void AddAvis(Bibliotheque bibliotheque)
        {
            try
            {

                var document = bibliotheque.GetByNumeroEnregistrement(9);
                if (document != null)
                {
                    document
                        .AddAvis(new Avis("Urgent", "Pas interessant comme doc"));
                }
            }
            catch (DocumentNotFoundException ex)
            {
                WriteLine(ex.Message);
                //throw;
            }
            catch (System.Exception)
            {
                WriteLine("Exception");
                throw;
            }

        }

        static int Menu()
        {
            int choix = 0;

            WriteLine();
            WriteLine();
            WriteLine("1. Liste des documents");
            WriteLine("2. Nouveau document");
            WriteLine("9. Quitter");

            while((choix != 1) && (choix != 2) && (choix != 9))
            {
                //choix = int.Parse(ReadLine());
                _ = int.TryParse(ReadLine(), out choix);
            }
            return choix;
        }
    }
}
