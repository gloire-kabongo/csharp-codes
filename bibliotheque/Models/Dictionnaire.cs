using LibraryManager.Models.Enums;

namespace LibraryManager.Models
{
    public class Dictionnaire : Document
    {
        public Dictionnaire(int numeroEnregistrement,
            string titre,
            Langue langue)
                : base(numeroEnregistrement, titre)
        {
            Langue = langue;
        }

        public Langue Langue { get; set; }

        public override string ToString() =>
            $"{base.ToString()} - Langue: {Langue}";
    }
}