using System.Collections.Generic;

namespace LibraryManager.Models
{
    public class Manuel : Livre
    {
        public int NiveauScolaire { get; set; }

        public Manuel(int numeroEnregistrement,
            string titre,
            List<Auteur> auteurs,
            int nombreDePages,
            int niveauScolaire)
                : base(numeroEnregistrement, titre, auteurs, nombreDePages)
        {
            NiveauScolaire = niveauScolaire;
        }

        public override string ToString() =>
            $"{base.ToString()} - Niveau scolaire: {NiveauScolaire}";
    }
}