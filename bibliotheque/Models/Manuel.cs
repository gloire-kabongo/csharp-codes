namespace LibraryManager.Models
{
    class Manuel : Livre
    {
        public int NiveauScolaire { get; set; }

        public Manuel(int numeroEnregistrement,
            string titre,
            string auteur,
            int nombreDePages,
            int niveauScolaire)
                : base(numeroEnregistrement, titre, auteur, nombreDePages)
        {
            NiveauScolaire = niveauScolaire;
        }

        public override string ToString() =>
            $"{base.ToString()} - {NiveauScolaire}";
    }
}