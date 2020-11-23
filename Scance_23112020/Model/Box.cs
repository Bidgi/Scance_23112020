using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    class Box
    {
        #region Attributs
        public static List<Box> CollClassBox = new List<Box>();
        private string _id;
        private string _adresse;
        private GeoCoordinate _gps;
        private List<Compartiment> _lesCompartiment;
        #endregion

        #region Constructeur
        public Box(string id, string adresse, GeoCoordinate gps, List<Compartiment> lesCompartiment)
        {
            Id = id;
            Adresse = adresse;
            Gps = gps;
            LesCompartiment = lesCompartiment;
            CollClassBox.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string Id { get => _id; set => _id = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public GeoCoordinate Gps { get => _gps; set => _gps = value; }
        internal List<Compartiment> LesCompartiment { get => _lesCompartiment; set => _lesCompartiment = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
