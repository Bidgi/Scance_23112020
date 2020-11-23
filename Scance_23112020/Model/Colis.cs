﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Colis
    {
		#region Attributs
		private string _id;
		private string _volume;
		private string _etat;
		private Client _leClient;
		public static List<Colis> collLesColis = new List<Colis>();
		#endregion

		#region Constructeurs
		public Colis()
        {
        }
		public Colis(string unId, string unVolume, Client unClient)
		{
			Id = unId;
			Volume = unVolume;
			LeClient = unClient;
			collLesColis.Add(this);
		}
		#endregion

		#region Getters Setters
		public Client LeClient { get => _leClient; set => _leClient = value; }
		public string Id { get => _id; set => _id = value; }
		public string Volume { get => _volume; set => _volume = value; }
		public string Etat { get => _etat; set => _etat = value; }
		#endregion

		#region Methodes
		public Client getLeClient() { return _leClient; }
		public string getLId() { return _id; }
		public string getLeVolume() { return _volume; }
		public string getLetat() { return _etat; }
		public static Colis ReturnColis(string unId)
		{
			foreach (Colis unColis in collLesColis)
			{
				if (unColis.Id == unId)
				{
					return unColis;
				}
			}
			return null;
		}
		#endregion
	}
}
