using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Livreurs
    {
        #region Attributs
        public static List<Livreurs> CollClassLivreur = new List<Livreurs>();
        private Dictionary<DateTime, Livreurs> Livraison = new Dictionary<DateTime, Livreurs>();
        private string _id;
        private string _nom;
        #endregion

        #region Constructeur
        public Livreurs(string id, string nom)
        {
            Id = id;
            Nom = nom;
            CollClassLivreur.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
