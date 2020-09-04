using System.Collections.Generic;

namespace LibraryManager.Models
{
    public class Livre : Document
    {
        // Liste d'auteurs
        private List<Auteur> auteurs;

        public Livre(int numeroEnregistrement,
            string titre,
            List<Auteur> auteurs,
            int nombreDePages)
            : base(numeroEnregistrement, titre)
        {
            this.auteurs = new List<Auteur>();
            this.auteurs.AddRange(auteurs);
            NombreDePages = nombreDePages;
        }

        public List<Auteur> Auteurs => auteurs;
        public int NombreDePages { get; set; }

        public override string ToString() =>
            $"{base.ToString()} - Auteurs: {GetAuteurs()} - Pages: {NombreDePages}";

        public string GetAuteurs ()
        {
            string auteurs = "";
            foreach (var auteur in this.auteurs)
            {
                auteurs += $"{auteur.Nom}, {auteur.Prénom};";
            }
            return auteurs;
        }

        public void AddAuteur(Auteur auteur)
        {
            Auteurs.Add(auteur);
        }

        public void RemoveAuteur(Auteur auteur) => Auteurs.Remove(auteur);
    }
}