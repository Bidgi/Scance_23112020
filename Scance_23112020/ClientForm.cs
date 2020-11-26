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
                    textBoxID.Text =unClient.getLId().ToString();
                    textBoxAdresse.Text = unClient.getLAdresse();
                    comboBoxVille.Text = unClient.getLaVille().Nom;
                    textBoxCP.Text = unClient.getLaVille().Codepostal.ToString();
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

    }
}
