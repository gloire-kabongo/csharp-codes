namespace LibraryManager.Models
{
    public class Roman : Livre
    {
        public Roman(int numeroEnregistrement,
            string titre,
            string auteur,
            int nombreDePages,
            int prixLitteraire)
                :base (numeroEnregistrement, titre, auteur, nombreDePages)
        {
            PrixLitteraire = prixLitteraire;
        }

        public int PrixLitteraire { get; set; }

        public override string ToString() =>
            $"{base.ToString()} - Prix litteraire: {PrixLitteraire}";
    }
}