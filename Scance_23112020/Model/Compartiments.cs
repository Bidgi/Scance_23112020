using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Compartiments // raoul 
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
        /// <summary> Raoul
        /// Permet d'ajourter le colis en paramettre au compartiment
        /// </summary>
        /// <param name="colis"> le colis </param>
        public void AddColis(Colis colis)
        {
            this.LesColis.Add(colis);
        }
        /// <summary> Raoul
        /// 
        /// </summary>
        /// <returns></returns>
        public Boxs GetBoxs()
        {
            foreach (Boxs unBoxs in Boxs.CollClassBox) if (unBoxs.LesCompartiment.Contains(this)) return unBoxs;
            return null;
        }
        #endregion
    }
}
