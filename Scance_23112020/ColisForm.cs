using Scance_23112020.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scance_23112020
{
    public partial class ColisForm : Form
    {
        public ColisForm()
        {
            InitializeComponent();
        }

        private void buttonLivre_Click(object sender, EventArgs e)
        {
            string idColis = dataGriedViewColis.SelectedRows[0].Cells[0].Value.ToString();
            Colis.ReturnColis(idColis).Etat = "Livré";
        }

        private void buttonAffecter_Click(object sender, EventArgs e)
        {
            string idColis = dataGriedViewColis.SelectedRows[0].Cells[0].Value.ToString();
            Colis LeColisClient = Colis.ReturnColis(idColis);
            Client LeClientColis = Colis.ReturnColis(idColis).getLeClient();
            List<Boxs> lesBoxsPresClient = Boxs.getBoxsTrieesDistance(LeClientColis);
            foreach (Boxs laBoxeLaPlusProche in lesBoxsPresClient)
            {
                foreach (Compartiments unCompa in laBoxeLaPlusProche.LesCompartiment)
                {
                    if (unCompa.LesColis[0].LeClient == LeClientColis)
                    {
                        int volumeTotal = 0;
                        foreach (Colis unColis in unCompa.LesColis)
                        {
                            if (unColis.getLeVolume() == "Gros")
                            {
                                volumeTotal += 2;
                            }
                            else volumeTotal++;
                        }
                        if (LeColisClient.getLeVolume() == "Gros") volumeTotal += 2;
                        else volumeTotal++;
                        if (volumeTotal <= 4)
                        {
                            unCompa.LesColis.Add(LeColisClient);
                            LeColisClient.Etat = "Affecté";
                            textBox.Text = laBoxeLaPlusProche.Adresse;
                            textCompartiment.Text = "X= " + unCompa.PositionX + " Y= " + unCompa.PositionY;
                            foreach (Livreurs unLivreur in Livreurs.CollClassLivreur)
                            {
                                foreach(KeyValuePair<DateTime,Boxs> uneLivraison in unLivreur.getLivraison())
                                {
                                    if (uneLivraison.Key == DateTime.Now)
                                    {
                                        if (uneLivraison.Value == laBoxeLaPlusProche)
                                        {
                                            textLivreur.Text = unLivreur.Nom;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonNAffecter_Click(object sender, EventArgs e)
        {
            string idColis = dataGriedViewColis.SelectedRows[0].Cells[0].Value.ToString();
            Colis.ReturnColis(idColis).Etat = "Non Affecté";
        }
        private void ColisForm_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(string));
            data.Columns.Add("Volume", typeof(string));
            data.Columns.Add("Client", typeof(string));

            dataGriedViewColis.Refresh();
            foreach (Colis unColis in Colis.collLesColis)
            {
                data.Rows.Add(unColis.getLId(), unColis.getLeVolume(), unColis.getLeClient().getLeNom());
            }
            dataGriedViewColis.DataSource = data;
        }

        private void dataGriedViewColis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Permet de retourner a la page d'avant
        /// </summary>
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            Program.menu.Visible = true;
            this.Close();
        }
    }
}
