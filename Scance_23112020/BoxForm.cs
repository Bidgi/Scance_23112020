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
    public partial class BoxForm : Form // raoul
    {
        internal static Compartiments leCompartiment;
        public BoxForm()
        {
            InitializeComponent();
        }
        private void Box_Load(object sender, EventArgs e)
        {
            cbbBox.Items.Add("Nouvelle Box");
            cbbBox.DataSource = new BindingSource(Boxs.DictionnaireBoxs, null);
            cbbBox.DisplayMember = "Value";
            cbbBox.ValueMember = "Key";
            cbbBox.Items.Add("Nouvelle Box");
            foreach (Villes uneVille in Villes.CollClassVille) cbbVilleBox.Items.Add(uneVille);
        }
        private void cbbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Position X", typeof(string));
            dt.Columns.Add("Position Y", typeof(string));
            dt.Columns.Add("Nb colis", typeof(string));
            dataGridView1.Refresh();
            foreach (Compartiments unCompartiment in ((KeyValuePair<Boxs, string>)cbbBox.SelectedItem).Key.LesCompartiment)
                dt.Rows.Add(new string[] { unCompartiment.PositionX, unCompartiment.PositionY, unCompartiment.LesColis.Count().ToString() });
            dataGridView1.DataSource = dt;
            foreach (Boxs unBoxs in VilleForm.laVille.LesBox)
            {
                if(cbbBox.SelectedItem.ToString() == unBoxs.Id.ToString())
                {
                    txtAddressBox.Text = unBoxs.Adresse.Adresse;
                    txtIDBox.Text = unBoxs.Id.ToString();
                }
            }
        }
        private void btnCreeBox_Click(object sender, EventArgs e)
        {
            if (cbbBox.Text == "Nouvelle Box")
            {
                labelErreur.Text = "Une ville possède déjà cette ID";
                labelErreur.Visible = false;
                if (txtAddressBox.Text != "")
                {
                    Villes laVille = null;
                    foreach (Villes uneVille in Villes.CollClassVille)  if (cbbVilleBox.Text == uneVille.Nom) laVille = uneVille;
                    new Boxs(new Adresses(laVille, txtAddressBox.Text));
                }
                else
                {
                    labelErreur.Text = "L'adresse n'est pas valide";
                    labelErreur.Visible = true;
                }
            }
            else
            {
                labelErreur.Text = "Une ville possède déjà cette ID";
                labelErreur.Visible = true;
            }
        }

        private void btnModifierBox_Click(object sender, EventArgs e)
        {
            foreach (Boxs unBoxs in VilleForm.laVille.LesBox)
            {
                if (unBoxs.Id.ToString() == txtIDBox.Text)
                {
                    if (txtAddressBox.Text != "") unBoxs.Adresse.NouvelleAdresse(txtAddressBox.Text);
                    else
                    {
                        labelErreur.Text = "L'adresse n'est pas valide";
                        labelErreur.Visible = true;
                    }
                }
            }
        }

        private void btnEffacerBox_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // marche pas
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) dataGridView1.SelectedRows[i].DefaultCellStyle.BackColor = Color.Empty;
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) dataGridView1.SelectedRows[i].DefaultCellStyle.BackColor = Color.Red;
            }
            catch { }
        }

        private void btnDetailCompartiment_Click(object sender, EventArgs e)
        {
            foreach (Boxs Boxs in Boxs.CollClassBox)
                foreach (Compartiments unCompartiment in Boxs.LesCompartiment)
                    if(unCompartiment.PositionX == dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString() && unCompartiment.PositionY == dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString())
                        leCompartiment = unCompartiment;
            CompartimentForm compartimentForm = new CompartimentForm();
            compartimentForm.Show();
        }

        /// <summary>
        /// Permet de retourner a la page d'avant
        /// </summary>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Program.menu.Visible = true;
            this.Close();
        }
    }
}
