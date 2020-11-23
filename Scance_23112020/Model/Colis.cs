using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Colis
    {
		#region Attributs
		private int _id;
		private string _volume;
		private string etat;
		public static List<Colis> ColllesColis = new List<Colis>();
		#endregion

		#region Constructeurs
		public Colis()
        {
        }
		public Colis(int uneId, string unVolume)
		{
			Id = uneId;
			Volume = unVolume;
			ColllesColis.Add(this);
		}
		#endregion

		#region Getters Setters
		public int Id { get => _id; set => _id = value; }
		public string Volume { get => _volume; set => _volume = value; }
		#endregion

		#region Methodes
		#endregion
	}
}
