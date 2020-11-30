using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Boxs // raoul 
    {
        #region Attributs
        public static Dictionary<Boxs, int> DictionnaireBoxs = new Dictionary<Boxs, int>();
        public static List<Boxs> CollClassBox = new List<Boxs>();
        private int _id;
        private Adresses _adresse;
        private List<Compartiments> _lesCompartiment;
        #endregion

        #region Constructeur
        public Boxs(int id, Adresses adresse)
        {
            Id = id;
            Adresse = adresse;
            LesCompartiment = new List<Compartiments>();
            CollClassBox.Add(this);
            DictionnaireBoxs.Add(this, Id);
        }
        #endregion

        #region Getters-Setters
        public int Id { get => _id; set => _id = value; }
        public Adresses Adresse { get => _adresse; set => _adresse = value; }
        internal List<Compartiments> LesCompartiment { get => _lesCompartiment; set => _lesCompartiment = value; }
        #endregion

        #region Méthodes
        /// <summary> ewen
        /// 
        /// </summary>
        /// <param name="unClient"></param>
        /// <returns></returns>
        public static List<Boxs> getBoxsTrieesDistance(Client unClient)
        {
            List<List<object>> LaListe=new List<List<object>>();
            foreach (Boxs uneBoxe in CollClassBox)
                LaListe.Add(new List<object>(){ uneBoxe, uneBoxe.Adresse.GeoCoordinate.GetDistanceTo(unClient.Adresse.GeoCoordinate) });
            LaListe.OrderBy(o => o.ElementAt(1));
            List<Boxs> LaListeBox = new List<Boxs>();
            foreach (List<object> uneListe in LaListe)
            {
                LaListeBox.Add((Boxs)uneListe.ElementAt(0));
            }
            return LaListeBox;
        }
        /// <summary>Raoul
        /// Permet d'ajouter le comparatiment en parametre a la liste des compartiment
        /// </summary>
        /// <param name="unCompartiment"> le comparatiment </param>
        public void AddCompartiment(Compartiments unCompartiment)
        {
            this.LesCompartiment.Add(unCompartiment);
        }
        #endregion
    }
}
