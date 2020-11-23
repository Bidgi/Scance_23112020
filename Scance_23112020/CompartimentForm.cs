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
    public partial class CompartimentForm : Form // raoul 
    {
        public CompartimentForm()
        {
            InitializeComponent();
        }
        private void Compartiment_Load(object sender, EventArgs e)
        {
            txtNombreColis.Text = BoxForm.leCompartiment.LesColis.Count.ToString();
            int grosColis = 0, petitColis = 0, tauxRemplissage = 0;
            foreach (Colis unColis in BoxForm.leCompartiment.LesColis)
            {
                cbbColis.Items.Add(unColis.Id);
                if (unColis.Volume == "gros")
                {
                    tauxRemplissage += 50;
                    grosColis += 1;
                }
                else 
                {
                    tauxRemplissage += 25;
                    petitColis += 1; 
                }
            }
            txtTauxRemplissage.Text = tauxRemplissage.ToString();
            txtNombreGrosColis.Text = grosColis.ToString();
            txtNombrePetitColis.Text = petitColis.ToString();
            txtNomClient.Text = BoxForm.leCompartiment.LesColis.ElementAt(0).LeClient.Nom;
            txtPrenomClient.Text = BoxForm.leCompartiment.LesColis.ElementAt(0).LeClient.Prenom;
            txtVilleClient.Text = BoxForm.leCompartiment.LesColis.ElementAt(0).LeClient.Ville.Nom;
            txtAdresseClient.Text = BoxForm.leCompartiment.LesColis.ElementAt(0).LeClient.Adresse;
            cbbColis.SelectedIndex = 0;
        }

        private void cbbColis_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Colis unColis in BoxForm.leCompartiment.LesColis)
            {
                if (unColis.Id == cbbColis.SelectedItem.ToString())
                {
                    txtPrenomClient.Text = unColis.Id;
                    txtVilleClient.Text = unColis.Volume;
                    txtAdresseClient.Text = unColis.Etat;
                }
            }
        }
    }
}
