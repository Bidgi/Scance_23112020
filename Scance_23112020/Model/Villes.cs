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
        private int _id;
        private string _nom;
        private string _pays;
        private int _codepostal;
        private List<Boxs> _lesBox;
        #endregion

        #region Constructeur
        public Villes(string nom, int codepostal, string nomPays)
        {
            Id = Utilitaire.retourNouvelleId(CollClassVille);
            Nom = nom;
            Codepostal = codepostal;
            Pays = nomPays;
            LesBox = new List<Boxs>();
            CollClassVille.Add(this);
        }
        public Villes() { }
        #endregion

        #region Getters-Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Pays { get => _pays; set => _pays = value; }
        public int Codepostal { get => _codepostal; set => _codepostal = value; }
        internal List<Boxs> LesBox { get => _lesBox; set => _lesBox = value; }
        #endregion

        #region Méthodes
        public void AddBox(Boxs unBoxs)
        {
            this.LesBox.Add(unBoxs);
        }
        public static Villes retourVilleId(int uneId)
        {
            Villes uneVilleRetour = null;
            foreach (Villes uneVille in CollClassVille)
            {
                if (uneVilleRetour.Id == uneId)
                {
                    uneVilleRetour = uneVille;
                }
            }
            return uneVilleRetour;
        }
        #endregion
    }
}
