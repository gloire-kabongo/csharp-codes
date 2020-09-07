namespace LibraryManager.Models
{
    public class Revue : Document
    {
        public Revue(int numeroEnregistrement,
            string titre,
            ushort mois,
            uint année)
            : base(numeroEnregistrement, titre)
        {
            Mois = mois;
            Année = année;
        }

        public ushort Mois { get; set; }
        public uint Année {get;set;}

        public override string ToString() =>
            $"{base.ToString()} \nMois: {Mois} - Année: {Année}";
    }
}