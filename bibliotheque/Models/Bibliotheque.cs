using System.Collections.Generic;

namespace LibraryManager.Models
{
    public class Bibliotheque
    {
        private readonly int capacité;

        public Bibliotheque(int capacité)
        {
            this.capacité = capacité;
        }
        public List<Document> Documents { get; set; }
    }
}