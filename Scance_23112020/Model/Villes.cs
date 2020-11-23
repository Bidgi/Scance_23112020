using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Villes // raoul 
    {
        #region Attributs
        public static List<Villes> CollClassVille = new List<Villes>();
        private string _id;
        private string _nom;
        private int _codepostal;
        private List<Boxs> _lesBox;
        #endregion

        #region Constructeur
        public Villes(string id, string nom, int codepostal, List<Boxs> lesBox)
        {
            Id = id;
            Nom = nom;
            Codepostal = codepostal;
            LesBox = lesBox;
            CollClassVille.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Codepostal { get => _codepostal; set => _codepostal = value; }
        internal List<Boxs> LesBox { get => _lesBox; set => _lesBox = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
