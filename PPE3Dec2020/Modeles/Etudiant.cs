using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3Dec2020.Modeles
{
    class Etudiant
    {
        #region Attributs
        public static List<Etudiant> CollClasse = new List<Etudiant>();
        private int _id;
        private string _nom;
        private string _prenom;
        private List<Stage> _collObjet;
        
        #endregion
        #region Constructeurs
        public Etudiant(int id, string nom, string prenom)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            Etudiant.CollClasse.Add(this);
            _collObjet = new List<Stage>();
        }
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Stage> CollObjet { get => _collObjet; set => _collObjet = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
