using System.Collections.Generic;

namespace GestionZoo.Models
{
    public class Cage
    {
        public string Adresse { get; set; }
        public string Numero { get; set; }
        public Agent Agent { get; set; }
        public List<Animal> Animaux { get; set; }
    }
}