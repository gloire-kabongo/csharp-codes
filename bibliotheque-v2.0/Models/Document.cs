using System;
using System.Collections.Generic;

namespace LibraryManager.Models
{
    public class Document
    {
        private int _numeroEnregistrement;
        private string _titre;
        private List<Avis> _avis = new List<Avis>();


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

        public List<Avis> Avis => _avis;

        public override string ToString() =>
            $"No {NumeroEnregistrement} \nTitre: {Titre}";

        public void AddAvis(Avis avis) => _avis.Add(avis);
    }
}