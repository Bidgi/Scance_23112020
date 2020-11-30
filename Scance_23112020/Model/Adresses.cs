using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Data;
using System.Device.Location;

namespace Scance_23112020.Model
{
    public class Adresses
    {
        #region Attributs
        public static List<Adresses> CollClasseAdresse = new List<Adresses>();
        private Villes _laVille;
        private string _adresse;
        private GeoCoordinate _geoCoordinate;
        private int _id;
        #endregion

        #region Constructeurs
        public Adresses(Villes laVille, string adresse)
        {
            LaVille = laVille;
            Adresse = adresse;
            if (adresse != "non renseigner")
            {
                List<double> latLng = GetLatLong(Adresse + " " + LaVille.Nom + " " + LaVille.Codepostal + "," + LaVille.Pays);
                GeoCoordinate = new GeoCoordinate(latLng.ElementAt(0), latLng.ElementAt(1));
            }
            else GeoCoordinate = new GeoCoordinate();
            Id = Utilitaire.RetourNouvelleId(CollClasseAdresse);
            CollClasseAdresse.Add(this);
        }
        #endregion

        #region Getters Setters
        public Villes LaVille { get => _laVille; set => _laVille = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public GeoCoordinate GeoCoordinate { get => _geoCoordinate; set => _geoCoordinate = value; }
        public int Id { get => _id; set => _id = value; }
        #endregion

        #region Méthode 
        public static List<double> GetLatLong(string strAddress)
        {
            string url = "http://maps.google.com/maps/api/geocode/xml?address=" + strAddress + "&sensor=false";
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    DataSet dsResult = new DataSet();
                    dsResult.ReadXml(reader);
                    List<double> GeoCordonnee = new List<double>();
                    foreach (DataRow row in dsResult.Tables["result"].Rows)
                    {
                        string geometry_id = dsResult.Tables["geometry"].Select("result_id = " + row["result_id"].ToString())[0]["geometry_id"].ToString();
                        DataRow location = dsResult.Tables["location"].Select("geometry_id = " + geometry_id)[0];
                        GeoCordonnee.Add(double.Parse(location["lat"].ToString()));
                        GeoCordonnee.Add(double.Parse(location["lng"].ToString()));
                    }
                    return GeoCordonnee;
                }
            }
        }
        public void NouvelleAdresse(string newAdresse)
        {
            this.GeoCoordinate = new GeoCoordinate(GetLatLong(newAdresse).ElementAt(0), GetLatLong(newAdresse).ElementAt(1));
        }
        #endregion
    }
}
