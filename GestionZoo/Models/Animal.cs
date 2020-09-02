namespace GestionZoo.Models
{
    public class Animal
    {
        public string Nom { get; set; }
        public string Famille { get; set; }

        public void Mange(Nourriture nourriture)
        {
            nourriture.Diminue();
        }
    }
}