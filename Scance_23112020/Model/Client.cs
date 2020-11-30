using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scance_23112020.Model
{
    public class Client
    {
        #region Attributs
        private int _id;
        private string _nom;
        private string _prenom;
        private Adresses _adresse;
        public static List<Client> CollLesClients = new List<Client>();
        #endregion

        #region Constructeurs
        public Client()
        {
        }
        public Client(int unId,string unNom, string unPrenom, Adresses uneAdresse)
        {
            Id = unId;
            Nom = unNom;
            Prenom = unPrenom;
            Adresse = uneAdresse;
            CollLesClients.Add(this);
        }
        #endregion

        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public Adresses Adresse { get => _adresse; set => _adresse = value; }
        #endregion

        #region Méthode 
        public int getLId() { return _id; }
        public string getLeNom() { return _nom; }
        public string getLePrenom() { return _prenom; }
        public Adresses getLAdresse() { return _adresse; }
        public static Client getClient(string unNom)
        {
            Client newClient = null;
            foreach (Client unClient in Client.CollLesClients)
            {
                if (unClient.getLeNom() == unNom)
                {
                    newClient = unClient;
                }
            }
            return newClient;
        }
        #endregion
    }
}
