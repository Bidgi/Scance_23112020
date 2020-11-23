﻿using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Boxs
    {
        #region Attributs
        public static List<Boxs> CollClassBox = new List<Boxs>();
        private string _id;
        private string _adresse;
        private GeoCoordinate _gps;
        private List<Compartiments> _lesCompartiment;
        #endregion

        #region Constructeur
        public Boxs(string id, string adresse, GeoCoordinate gps, List<Compartiments> lesCompartiment)
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
        internal List<Compartiments> LesCompartiment { get => _lesCompartiment; set => _lesCompartiment = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}