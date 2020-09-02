namespace LibraryManager.Models
{
    public class Livre : Document
    {
        public Livre(int numeroEnregistrement,
            string titre,
            string auteur,
            int nombreDePages)
            : base(numeroEnregistrement, titre)
        {
            Auteur = auteur;
            NombreDePages = nombreDePages;
        }

        public string Auteur { get; set; }
        public int NombreDePages { get; set; }

        public override string ToString() =>
            $"{base.ToString()} - {Auteur} - {NombreDePages}";
    }
}