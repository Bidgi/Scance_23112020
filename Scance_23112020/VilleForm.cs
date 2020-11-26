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
    public partial class VilleForm : Form
    {
        internal static Villes laVille;
        public VilleForm()
        {
            InitializeComponent();
        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVille.Text == "Nouvelles Villes")
            {
                textBoxId.Text = Villes.retourNouvelleId().ToString();
                textBoxVille.Text = "";
                textBoxCP.Text = "";
            }
            else
            {
                int IDDeVille = comboBoxVille.SelectedIndex + 2;
                Villes laVille = null;
                foreach (Villes uneVille in Villes.CollClassVille)
                {
                    if (uneVille.Id == IDDeVille)
                    {
                        textBoxId.Text = uneVille.Id.ToString();
                        textBoxVille.Text = uneVille.Nom;
                        textBoxCP.Text = uneVille.Codepostal.ToString();
                        laVille = uneVille;
                    }
                }
                DataTable data = new DataTable();
                data.Columns.Add("ID", typeof(int));
                data.Columns.Add("Adresse", typeof(string));

                dataGridViewBoxs.Refresh();
                foreach (Boxs uneBox in laVille.LesBox)
                {
                    data.Rows.Add(uneBox.Id, uneBox.Adresse);

                }
                dataGridViewBoxs.DataSource = data;
            }
        }

        private void ButtonCreer_Click(object sender, EventArgs e)
        {
            if (comboBoxVille.Text == "Nouvelles Villes")
            {
                labelErreur.Text = "Une ville possède déjà cette ID";
                labelErreur.Visible = false;
                if (textBoxVille.Text != "")
                {
                    if (textBoxCP.Text != "")
                    {
                        Villes unVille = new Villes(int.Parse(textBoxId.Text),textBoxVille.Text, int.Parse(textBoxCP.Text));
                    }
                    else
                    {
                        labelErreur.Text = "Le code postale n'est pas valide.";
                        labelErreur.Visible = true;
                    }
                }
                else
                {
                    labelErreur.Text = "Le nom n'est pas valide";
                    labelErreur.Visible = true;
                }
            }
            else
            {
                labelErreur.Text = "Une ville possède déjà cette ID";
                labelErreur.Visible = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach(Villes uneVille in Villes.CollClassVille)
            {
                if(uneVille.Id == int.Parse(textBoxId.Text))
                {
                    if(textBoxVille.Text != "")
                    {
                        if(textBoxCP.Text != "")
                        {
                            uneVille.Nom = textBoxVille.Text;
                            uneVille.Codepostal = int.Parse(textBoxCP.Text);
                        }
                        else
                        {
                            labelErreur.Text = "Le code postale n'est pas valide.";
                            labelErreur.Visible = true;
                        }
                    }
                    else
                    {
                        labelErreur.Text = "Le nom n'est pas valide";
                        labelErreur.Visible = true;
                    }
                }
            }
        }

        private void VilleForm_Load(object sender, EventArgs e)
        {
            foreach (Villes uneVille in Villes.CollClassVille)
            {
                comboBoxVille.Items.Add(uneVille.Id + "-" + uneVille.Nom);
            }
        }

        /// <summary>
        /// Permet de retourner a la page d'avant
        /// </summary>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Program.menu.Visible = true;
            this.Close();
        }

        private void btnDétailBox_Click(object sender, EventArgs e)
        {
            foreach (Villes uneVille in Villes.CollClassVille) if (uneVille.Id == int.Parse(textBoxId.Text)) laVille = uneVille;
            BoxForm boxForm = new BoxForm();
            boxForm.Show();
            this.Visible = false;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
