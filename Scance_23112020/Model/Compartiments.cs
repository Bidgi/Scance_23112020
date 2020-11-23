using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Compartiments
    {
        #region Attributs
        public static List<Compartiments> CollClassCompartiment = new List<Compartiments>();
        private string _positionX;
        private string _positionY;
        private int _volume;
        private List<Colis> _lesColis;
        #endregion

        #region Constructeur
        public Compartiments(string positionX, string positionY, int volume)
        {
            PositionX = positionX;
            PositionY = positionY;
            Volume = volume;
            LesColis = new List<Colis>();
            CollClassCompartiment.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string PositionX { get => _positionX; set => _positionX = value; }
        public string PositionY { get => _positionY; set => _positionY = value; }
        public int Volume { get => _volume; set => _volume = value; }
        public List<Colis> LesColis { get => _lesColis; set => _lesColis = value; }

        #endregion

        #region Méthodes
        #endregion
    }
}
