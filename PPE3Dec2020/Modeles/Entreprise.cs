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

        
        
        #endregion
        #region Constructeurs
        public Entreprise(int id, string nom)
        {
            _id = id;
            _nom = nom;
            Entreprise.CollClasse.Add(this);
        }

        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
