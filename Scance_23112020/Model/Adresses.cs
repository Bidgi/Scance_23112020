﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Data;

namespace Scance_23112020.Model
{
    class Adresses
    {
        #region Attributs
        public static List<Adresses> CollClasseAdresse = new List<Adresses>();
        private Villes _laVille;
        private string _adresse;
        private double _lat;
        private double _lng;
        private int _id;
        #endregion

        #region Constructeurs
        public Adresses(Villes laVille, string adresse, int id)
        {
            LaVille = laVille;
            Adresse = adresse;
            List<double> latLng = GetLatLong(LaVille.Nom + " " + LaVille.Codepostal + " " + Adresse + "," + LaVille.Pays);
            Lat = latLng.ElementAt(0);
            Lng = latLng.ElementAt(1);
            Id = id;
            CollClasseAdresse.Add(this);
        }
        #endregion

        #region Getters Setters
        public Villes LaVille { get => _laVille; set => _laVille = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public double Lat { get => _lat; set => _lat = value; }
        public double Lng { get => _lng; set => _lng = value; }
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
        #endregion
    }
}
