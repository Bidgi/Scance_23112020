using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    class Compartiment
    {
        #region Attributs
        public static List<Compartiment> COllClassCompartiment = new List<Compartiment>();
        private string _positionX;
        private string _positionY;
        private int _volume;
        private List<Colis> _lesColis;
        #endregion

        #region Constructeur
        public Compartiment(string positionX, string positionY, int volume)
        {
            PositionX = positionX;
            PositionY = positionY;
            Volume = volume;
            LesColis = new List<Colis>();
            COllClassCompartiment.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string PositionX { get => _positionX; set => _positionX = value; }
        public string PositionY { get => _positionY; set => _positionY = value; }
        public int Volume { get => _volume; set => _volume = value; }
        public Colis LesColis { get => _lesColis; set => _lesColis = value; }

        #endregion

        #region Méthodes
        #endregion
    }
}
