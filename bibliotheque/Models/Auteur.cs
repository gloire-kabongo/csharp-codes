namespace LibraryManager.Models
{
    public class Auteur
    {
        public Auteur(string nom, string prénom)
        {
            Nom = nom;
            Prénom = prénom;
        }

        public string Nom { get; set; }
        public string Prénom { get; set; }

    }
}