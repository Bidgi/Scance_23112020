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
        public static List<Client_Indi> collLesClientIndi = new List<Client_Indi>();
        private int _coupon;
        #endregion

        #region Constructeurs
        public Client_Indi(string unNom, string unPrenom, Adresses uneAdresse, int nbrCoupon) : base(unNom, unPrenom, uneAdresse)
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
