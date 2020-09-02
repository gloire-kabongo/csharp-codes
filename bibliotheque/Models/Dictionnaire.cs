namespace LibraryManager.Models
{
    public class Dictionnaire : Document
    {
        public Dictionnaire(int numeroEnregistrement,
            string titre,
            string langue)
                : base(numeroEnregistrement, titre)
        {
            Langue = langue;
        }

        public string Langue { get; set; }

        public override string ToString() =>
            $"{base.ToString()} - {Langue}";
    }
}