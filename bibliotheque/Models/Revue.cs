namespace LibraryManager.Models
{
    class Revue : Document
    {
        public Revue(int numeroEnregistrement,
            string titre,
            int mois,
            int année)
                : base(numeroEnregistrement, titre)
        {
            Mois = mois;
            Année = année;
        }

        public int Mois { get; set; }
        public int Année { get; set; }

        public override string ToString() =>
            $"{base.ToString()} - {Mois} - {Année}";
    }
}