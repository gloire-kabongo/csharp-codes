namespace LibraryManager.Models
{
    public class Document
    {
        public Document(int numeroEnregistrement, string titre)
        {
            NumeroEnregistrement = numeroEnregistrement;

            if (string.IsNullOrEmpty(titre))
                throw new System.ArgumentException("Le titre est null", nameof(titre));
            Titre = titre;
        }

        public int NumeroEnregistrement { get; set; }
        public string Titre { get; set; }

        public override string ToString() =>
            $"No {NumeroEnregistrement} - Titre: {Titre}";
    }
}