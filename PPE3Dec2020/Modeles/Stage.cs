using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3Dec2020.Modeles
{
    class Stage
    {
        #region Attributs
        public static List<Stage> CollClasse = new List<Stage>();
        private int _id;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private List<Etudiant> _collObjet;
        private Entreprise _uneEntreprise;

        #endregion
        #region Constructeurs
        public Stage(int id, DateTime dateDebut, DateTime dateFin, Entreprise uneEntreprise)
        {
            _id = id;
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            Stage.CollClasse.Add(this);
            _collObjet = new List<Etudiant>();
            _uneEntreprise = uneEntreprise;
        }
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public List<Etudiant> CollObjet { get => _collObjet; set => _collObjet = value; }
        internal Entreprise UneEntreprise { get => _uneEntreprise; set => _uneEntreprise = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
