using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Client
    {
        #region Attributs
        private int _id;
        private string _nom;
        private string _prenom;
        private string _adresse;
        private Ville _ville;
        private int _cp;
        private GeoCoordinate _gps;
        public static List<Client> CollLesClients = new List<Client>();
        #endregion

        #region Constructeurs
        public Client()
        {
        }
        public Client(int uneId,string unNom, string unPrenom, string uneAdresse, Ville uneVille, int unCP, GeoCoordinate unGPS)
        {
            Id = uneId;
            Nom = unNom;
            Prenom = unPrenom;
            Adresse = uneAdresse;
            Ville = uneVille;
            CP = unCP;
            GPS = unGPS;
            CollLesClients.Add(this);
        }
        #endregion

        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public Ville Ville { get => _ville; set => _ville = value; }
        public int CP { get => _cp; set => _cp = value; }
        public GeoCoordinate GPS { get => _gps; set => _gps = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
