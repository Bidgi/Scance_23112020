using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Client_Pro : Client
    {
        #region Attributs
        private double _volumeNegocie;
        private double _remise;
        #endregion

        #region Constructeurs
        public Client_Pro (int uneId, string unNom, string unPrenom, string uneAdresse, Ville uneVille, int unCP, GeoCoordinate unGPS, double unVolume, double uneRemise) : base ( uneId,  unNom,  unPrenom,  uneAdresse,  uneVille,  unCP,  unGPS)
        {
            VolumeNegocie = unVolume;
            Remise = uneRemise;
        }

        #endregion

        #region Getters Setters
        public double VolumeNegocie { get => _volumeNegocie; set => _volumeNegocie = value; }
        public double Remise { get => _remise; set => _remise = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
