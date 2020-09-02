using System;
using System.Collections.Generic;
using LibraryManager.Models;

namespace LibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Document roman1 = new Roman(12,
                "Notre dame de Paris",
                "Victor Hugo",
                586, prixLitteraire: 5);
            
            ////Display(roman1);

            var revue = new Revue(15, "Jeune Afrique", 12, 2019);
            //Display(revue);

            var documents = new List<Document>
            {
                roman1,
                revue
            };
            Display(documents);
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
