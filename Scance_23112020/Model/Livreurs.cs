using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Livreurs // raoul 
    {
        #region Attributs
        public static List<Livreurs> CollClassLivreur = new List<Livreurs>();
        private Dictionary<DateTime, Boxs> Livraison = new Dictionary<DateTime, Boxs>();
        private int _id;
        private string _nom;
        #endregion

        #region Constructeur
        public Livreurs(string nom)
        {
            Id = Utilitaire.RetourNouvelleId(CollClassLivreur);
            Nom = nom;
            CollClassLivreur.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        #endregion

        #region Méthodes
        public Dictionary<DateTime, Boxs> getLivraison() { return Livraison; }


        #endregion
    }
}
