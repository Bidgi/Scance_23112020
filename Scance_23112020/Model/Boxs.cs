﻿using System;
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
        private string _adresse;
        private GeoCoordinate _gps;
        private List<Compartiments> _lesCompartiment;
        #endregion

        #region Constructeur
        public Boxs(string id, string adresse, GeoCoordinate gps)
        {
            Id = id;
            Adresse = adresse;
            Gps = gps;
            LesCompartiment = new List<Compartiments>();
            CollClassBox.Add(this);
            DictionnaireBoxs.Add(this, Id);
        }
        #endregion

        #region Getters-Setters
        public string Id { get => _id; set => _id = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public GeoCoordinate Gps { get => _gps; set => _gps = value; }
        internal List<Compartiments> LesCompartiment { get => _lesCompartiment; set => _lesCompartiment = value; }
        #endregion

        #region Méthodes
        public void AddCompartiment(Compartiments unCompartiment)
        {
            this.LesCompartiment.Add(unCompartiment);
        }
        #endregion
    }
}
