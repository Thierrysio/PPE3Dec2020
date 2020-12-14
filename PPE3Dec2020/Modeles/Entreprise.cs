using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3Dec2020.Modeles
{
    class Entreprise
    {
        #region Attributs
        public static List<Entreprise> CollClasse = new List<Entreprise>();
        private int _id;
        private string _nom;
        private List<Stage> _collObjet;


        #endregion
        #region Constructeurs
        public Entreprise(int id, string nom)
        {
            _id = id;
            _nom = nom;
            Entreprise.CollClasse.Add(this);
            _collObjet = new List<Stage>();
        }

        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        internal List<Stage> CollObjet { get => _collObjet; set => _collObjet = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
