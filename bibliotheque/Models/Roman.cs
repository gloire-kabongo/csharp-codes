using System.Collections.Generic;
using LibraryManager.Models.Enums;

namespace LibraryManager.Models
{
    public class Roman : Livre
    {
        public Roman(int numeroEnregistrement,
            string titre,
            List<Auteur> auteurs,
            int nombreDePages,
            PrixLitteraire prixLitteraire)
                :base (numeroEnregistrement, titre, auteurs, nombreDePages)
        {
            PrixLitteraire = prixLitteraire;
        }

        public PrixLitteraire PrixLitteraire { get; set; }

        public override string ToString() =>
            $"{base.ToString()} - Prix litteraire: {PrixLitteraire}";
    }
}