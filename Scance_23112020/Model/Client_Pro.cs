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
        public static List<Client_Pro> collLesClientPro = new List<Client_Pro>();
        private double _volumeNegocie;
        private double _remise;
        #endregion

        #region Constructeurs
        public Client_Pro ( string unNom, string unPrenom, Adresses uneAdresse, double unVolume, double uneRemise) : base ( unNom,  unPrenom,  uneAdresse)
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
