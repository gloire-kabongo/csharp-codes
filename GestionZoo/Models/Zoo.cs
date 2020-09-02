using System.Collections.Generic;

namespace GestionZoo.Models
{
    public class Zoo
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public List<Cage> Cages { get; set; }
    }
}