using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Ville
    {
        #region Attributs
        private string _id;
        private string _nom;
        private int _codepostal;



        #endregion
        #region Constructeur
        public Ville(string id, string nom, int codepostal)
        {
            Id = id;
            Nom = nom;
            Codepostal = codepostal;
        }

        #endregion
        #region Getters-Setters
        public string Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Codepostal { get => _codepostal; set => _codepostal = value; }
        #endregion
        #region Méthodes
        #endregion
    }
}
