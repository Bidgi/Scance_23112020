using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Client_Indi : Client
    {
        #region Attributs
        private int _coupon;
        #endregion

        #region Constructeurs
        public Client_Indi(int uneId, string unNom, string unPrenom, string uneAdresse, Villes uneVille, int unCP, GeoCoordinate unGPS, int nbrCoupon) : base(uneId, unNom, unPrenom, uneAdresse, uneVille, unCP, unGPS)
        {
            Coupon = nbrCoupon;
        }
        #endregion

        #region Getters Setters
        public int Coupon { get => _coupon; set => _coupon = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
