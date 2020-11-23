using Scance_23112020.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            buttonGene.Text = "Livré";
        }

        private void buttonAffecter_Click(object sender, EventArgs e)
        {
            buttonGene.Text = "Affecter";
        }

        private void buttonNAffecter_Click(object sender, EventArgs e)
        {
            buttonGene.Text = "Désaffecter";
        }

        private void buttonGene_Click(object sender, EventArgs e)
        {
            if (buttonGene.Text == "Livré") 
            {
                string idColis = dataGriedViewColis.SelectedRows[0].Cells[0].Value.ToString();
                Colis.ReturnColis(idColis).Etat = "Livré";
            }
            if (buttonGene.Text == "Désaffecter")
            {
                string idColis = dataGriedViewColis.SelectedRows[0].Cells[0].Value.ToString();
                Colis.ReturnColis(idColis).Etat = "Non Affecté";
            }
            else
            {
                string idColis = dataGriedViewColis.SelectedRows[0].Cells[0].Value.ToString();
                
            }
        }

        private void ColisForm_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Volume", typeof(double));
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
    }
}
