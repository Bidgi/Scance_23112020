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
        public static Dictionary<Boxs, string> DictionnaireBoxs = new Dictionary<Boxs, string>();
        public static List<Boxs> CollClassBox = new List<Boxs>();
        private string _id;
        private Adresses _adresse;
        private List<Compartiments> _lesCompartiment;
        #endregion

        #region Constructeur
        public Boxs(string id, Adresses adresse)
        {
            Id = id;
            Adresse = adresse;
            LesCompartiment = new List<Compartiments>();
            CollClassBox.Add(this);
            DictionnaireBoxs.Add(this, Id);
        }
        #endregion

        #region Getters-Setters
        public string Id { get => _id; set => _id = value; }
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
        public static int retourNouvelleId()
        {
            int x = 0;
            foreach (Boxs uneBox in CollClassBox)
            {
                x++;
            }
            return x;
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
