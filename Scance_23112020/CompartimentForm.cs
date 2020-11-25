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
        public static Compartiments compartiments;
        public CompartimentForm()
        {
            InitializeComponent();
        }
        private void Compartiment_Load(object sender, EventArgs e)
        {
            compartiments = BoxForm.leCompartiment;
            pBRemplissage.Value = 0;
            if (compartiments.LesColis.Count > 0)
            {
                txtNombreColis.Text = compartiments.LesColis.Count.ToString();
                int grosColis = 0, petitColis = 0, tauxRemplissage = 0;
                foreach (Colis unColis in compartiments.LesColis)
                {
                    lbColis.Items.Add(unColis.Id);
                    if (unColis.Volume == "gros")
                    {
                        pBRemplissage.Value += 50;
                        tauxRemplissage += 50;
                        grosColis += 1;
                    }
                    else
                    {
                        pBRemplissage.Value += 25;
                        tauxRemplissage += 25;
                        petitColis += 1;
                    }
                }
                txtTauxRemplissage.Text = tauxRemplissage + "%";
                txtNombreGrosColis.Text = grosColis.ToString();
                txtNombrePetitColis.Text = petitColis.ToString();
                txtNomClient.Text = compartiments.LesColis.ElementAt(0).LeClient.Nom;
                txtPrenomClient.Text = compartiments.LesColis.ElementAt(0).LeClient.Prenom;
                txtVilleClient.Text = compartiments.LesColis.ElementAt(0).LeClient.Ville.Nom;
                txtAdresseClient.Text = compartiments.LesColis.ElementAt(0).LeClient.Adresse;
                lbColis.SelectedItem = 0;
            }
            else
            {
                txtNombreColis.Text = "0";
                txtTauxRemplissage.Text = "0%";
                txtNombreGrosColis.Text = "0";
                txtNombrePetitColis.Text = "0";
                txtNomClient.Text = "libre";
                txtPrenomClient.Text = "libre";
                txtVilleClient.Text = "libre";
                txtAdresseClient.Text = "libre";
            }
        }

        private void lbColis_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Colis unColis in compartiments.LesColis)
            {
                if(unColis.Id == lbColis.SelectedItem.ToString())
                {
                    txtIdColis.Text = unColis.Id;
                    txtEtatColis.Text = unColis.Etat;
                    txtVolumeColis.Text = unColis.Volume;
                    break;
                }
            }
        }
    }
}
