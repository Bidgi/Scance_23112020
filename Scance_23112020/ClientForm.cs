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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Client unClient in Client.CollLesClients)
            {
                if (unClient.Id == comboBoxClient.SelectedIndex + 2)
                {
                    textBoxNom.Text = unClient.getLeNom();
                    textBoxPrenom.Text = unClient.getLePrenom();
                    textBoxAdresse.Text = unClient.getLAdresse();
                    comboBoxVille.Text = unClient.getLaVille().Nom;
                    textBoxCP.Text = unClient.getLaVille().Codepostal.ToString();
                    dataGridView1.Refresh();
                    foreach (Colis unColis in Colis.collLesColis)
                    {
                        data.Rows.Add(unColis.getLId(), unColis.getLeVolume(), unColis.getLeClient().getLeNom());
                    }
                    dataGridView1.DataSource = data;
                    foreach ( Client_Pro unClientPro in Client_Pro.collLesClientPro)
                    {
                        if (unClientPro.getLId() == unClient.getLId())
                        {
                            label.Text = "Dernière remise:";
                            textBox.Text = unClientPro.Remise.ToString();
                        }
                    }
                    foreach (Client_Indi unClientIndi in Client_Indi.collLesClientIndi)
                    {
                        if (unClientIndi.getLId() == unClient.getLId())
                        {
                            label.Text = "Coupon:";
                            textBox.Text = unClientIndi.Coupon.ToString();
                        }
                    }
                }
            }
        }
                    textBoxAdresse.Text = unClient.getLAdresse().Adresse;
                    textBoxCP.Text = unClient.getLAdresse().LaVille.Codepostal.ToString();
                }
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            foreach (Client unClient in Client.CollLesClients )
            {
                comboBoxClient.Items.Add(unClient.Id + "-" + unClient.Nom);
            }
        }

        private void ButtonCréer_Click(object sender, EventArgs e)
        {
            if (comboBoxVille.Text == "Nouveau client")
            {
                if (textBoxNom.Text != "")
                {
                    if (textBoxPrenom.Text != "")
                    {
                        if (textBoxCP.Text != "")
                        {
                            if (comboBoxVille.SelectedIndex != 0)
                            {
                                if (textBoxAdresse.Text != "")
                                {
                                    labelErreur.Visible = false;
                                    Client unClient = new Client(int.Parse(textBoxID.Text), textBoxNom.Text, textBoxPrenom.Text, textBoxAdresse.Text, Villes.retourVilleId(int.Parse(comboBoxVille.Text)));
                                    comboBoxClient.Refresh();
                                    foreach (Client unClientRefresh in Client.CollLesClients)
                                    {
                                        comboBoxClient.Items.Add(unClientRefresh.Id + "-" + unClientRefresh.Nom);
                                    }
                                }
                                else
                                {
                                    labelErreur.Text = "L'adresse n'est pas valide.";
                                    labelErreur.Visible = true;
                                }
                            }
                            else
                            {
                                labelErreur.Text = "La ville n'est pas valide.";
                                labelErreur.Visible = true;
                            }
                        }
                        else
                        {
                            labelErreur.Text = "Le code postale n'est pas valide.";
                            labelErreur.Visible = true;
                        }
                    }
                    else
                    {
                        labelErreur.Text = "Le prenom n'est pas valide.";
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
                labelErreur.Text = "Un client possède déjà cette ID";
                labelErreur.Visible = true;
            }
        }

        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "")
            {
                if (textBoxPrenom.Text != "")
                {
                    if (textBoxCP.Text != "")
                    {
                        if (comboBoxVille.SelectedIndex != 0)
                        {
                            if (textBoxAdresse.Text != "")
                            {
                                labelErreur.Visible = false;
                                foreach (Client unClient in Client.CollLesClients)
                                {
                                    if (unClient.Id == int.Parse(textBoxID.Text))
                                    {
                                        unClient.Nom = textBoxNom.Text;
                                        unClient.Prenom = textBoxPrenom.Text;
                                        unClient.Adresse = textBoxAdresse.Text;
                                        unClient.Ville = Villes.retourVilleId(int.Parse(comboBoxVille.Text));
                                        comboBoxClient.Refresh();
                                        foreach (Client unClientRefresh in Client.CollLesClients)
                                        {
                                            comboBoxClient.Items.Add(unClientRefresh.Id + "-" + unClientRefresh.Nom);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                labelErreur.Text = "L'adresse n'est pas valide.";
                                labelErreur.Visible = true;
                            }
                        }
                        else
                        {
                            labelErreur.Text = "La ville n'est pas valide.";
                            labelErreur.Visible = true;
                        }
                    }
                    else
                    {
                        labelErreur.Text = "Le code postale n'est pas valide.";
                        labelErreur.Visible = true;
                    }
                }
                else
                {
                    labelErreur.Text = "Le prenom n'est pas valide.";
                    labelErreur.Visible = true;
                }
            }
            else
            {
                labelErreur.Text = "Le nom n'est pas valide";
                labelErreur.Visible = true;
            } 
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            foreach (Client unClient in Client.CollLesClients)
            {
                if (unClient.Id == int.Parse(textBoxID.Text))
                {
                    Client.CollLesClients.Remove(unClient);
                    foreach(Client_Pro unClientPro in Client_Pro.collLesClientPro)
                    {
                        if (unClientPro.Id == unClient.Id)
                        {
                            Client_Pro.collLesClientPro.Remove(unClientPro);
                        }
                    }
                    foreach (Client_Indi unClientIndi in Client_Indi.collLesClientIndi)
                    {
                        if (unClientIndi.Id == unClient.Id)
                        {
                            Client_Indi.collLesClientIndi.Remove(unClientIndi);
                        }
                    }
                }
            }
            comboBoxClient.Refresh();
            foreach (Client unClientRefresh in Client.CollLesClients)
            {
                comboBoxClient.Items.Add(unClientRefresh.Id + "-" + unClientRefresh.Nom);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
