using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            MultipleSources();
        }

        static void LinqToObject()
        {
            List<Personne> personnes = new List<Personne>()
            {
                new Personne(1, "wick", "john", 500),
                new Personne(2, "abruzzi", "john", 700),
                new Personne(3, "dalton", "jack", 300),
                new Personne(4, "white", "mike", 800),
            };

            var query = from p in personnes
                        where p.Budget > 500
                        orderby p.Nom
                        select new { p.Prenom,  Name = p.Nom};

            foreach (var p in query)
            {
                Console.WriteLine($"Je m'appelle {p.Name}");
            }

        }

        private static void NewMethod()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var query = from number in numbers
                        where (number % 2) == 0 && (number > 5 || number < 3)
                        select number;
            var queryMethod = numbers
                .Where(number => (number % 2) == 0 && (number > 5 || number < 3));

            var first = query.First();
            var firstOrDefault = query.FirstOrDefault();
            // var single = query.Single();
            // var singleOrDefault = query.SingleOrDefault();

            // foreach (var item in queryMethod.Skip(1).Take(2))
            // {
            //     Console.Write($"{item} ");
            // }
            foreach (var item in queryMethod.SkipWhile(n => n < 8))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(queryMethod.Average());
        }

        static void MultipleSources()
        {
            int[] premiers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] impairs = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            var unionQuery = (from premier in premiers
                             where premier < 10
                             select premier)
                             .Union(from impair in impairs
                                    where impair < 10
                                    select impair);
            var queryMethod = premiers.Where(p => p < 10)
                                .Intersect(impairs.Where(i => i < 10));

            foreach (var item in queryMethod)
            {
                Console.Write($"{item} ");
            }
        }
    }

    class Personne
    {
        public Personne(int num, string nom, string prenom, int budget)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Num = num;
            this.Budget = budget;
        }
        public int Num { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Budget { get; set; }
    }

}
