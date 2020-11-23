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
        private List<Colis> _lesColis;
        #endregion

        #region Constructeur
        public Compartiments(string positionX, string positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
            LesColis = new List<Colis>();
            CollClassCompartiment.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string PositionX { get => _positionX; set => _positionX = value; }
        public string PositionY { get => _positionY; set => _positionY = value; }
        public List<Colis> LesColis { get => _lesColis; set => _lesColis = value; }

        #endregion

        #region Méthodes
        public void AddColis(Colis colis)
        {
            this.LesColis.Add(colis);
        }
        #endregion
    }
}
