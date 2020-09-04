using System;

namespace LibraryManager.Models
{
    public class Document
    {
        private int _numeroEnregistrement;
        private string _titre;

        public Document(int numeroEnregistrement, string titre)
        {
            _numeroEnregistrement = numeroEnregistrement;

            if(string.IsNullOrEmpty(titre))
                throw new ArgumentException(
                    "Les valeurs vides et null ne sont acceptees",
                    nameof(titre));
            _titre = titre;
        }

        public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }

        public int NumeroEnregistrement
        {
            get { return _numeroEnregistrement; }
            set { _numeroEnregistrement = value; }
        }
    }
}