using Scance_23112020.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Boxs boxs = compartiments.GetBoxs();
            txtbPX.Text = compartiments.PositionX;
            txtbPY.Text = compartiments.PositionY;
            string position = compartiments.PositionX + "" + compartiments.PositionY;
            foreach (Compartiments unCompartiment in boxs.LesCompartiment)
            {
                int gros = 0, petit = 0;
                foreach (Colis unColis in unCompartiment.LesColis)
                {
                    if(unColis.Volume == "gros") gros++;
                    else petit++;
                }
                string[] current = Directory.GetCurrentDirectory().Split(new string[] { "bin" }, StringSplitOptions.None);
                string path = current.ElementAt(0) + "image\\" + gros + "Gros " + petit + "Petit.png";
                Image image = Image.FromFile(path);
                string positionXY = unCompartiment.PositionX + "" + unCompartiment.PositionY;
                if (positionXY == position) 
                {
                    Bitmap bitmap = (Bitmap)Image.FromFile(path);
                    for (int i = 0; i < bitmap.Width; i++) bitmap.SetPixel(i, 0, Color.Red);
                    for (int i = 0; i < bitmap.Width; i++) bitmap.SetPixel(i, 20, Color.Red);
                    for (int i = 0; i < bitmap.Height; i++) bitmap.SetPixel(0, i, Color.Red);
                    for (int i = 0; i < bitmap.Height; i++) bitmap.SetPixel(20, i, Color.Red);
                    image = bitmap;
                }
                switch (positionXY)
                {
                    case "11": pb11.Image = image; break;
                    case "12": pb12.Image = image; break;
                    case "13": pb13.Image = image; break;
                    case "14": pb14.Image = image; break;
                    case "21": pb21.Image = image; break;
                    case "22": pb22.Image = image; break;
                    case "23": pb23.Image = image; break;
                    case "24": pb24.Image = image; break;
                    case "31": pb31.Image = image; break;
                    case "32": pb32.Image = image; break;
                    case "33": pb33.Image = image; break;
                    case "34": pb34.Image = image; break;
                    case "41": pb41.Image = image; break;
                    case "42": pb42.Image = image; break;
                    case "43": pb43.Image = image; break;
                    case "44": pb44.Image = image; break;
                }
            }

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
                txtVilleClient.Text = compartiments.LesColis.ElementAt(0).LeClient.Adresse.LaVille.Nom;
                txtAdresseClient.Text = compartiments.LesColis.ElementAt(0).LeClient.Adresse.Adresse;
                lbColis.SelectedIndex = 0;
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
        /// <summary>
        /// Permet d'affiche les informatique du colis selection dans la liste
        /// </summary>
        private void lbColis_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Colis unColis in compartiments.LesColis)
            {
                if(unColis.Id.ToString() == lbColis.SelectedItem.ToString())
                {
                    txtIdColis.Text = unColis.Id.ToString();
                    txtEtatColis.Text = unColis.Etat;
                    txtVolumeColis.Text = unColis.Volume;
                    break;
                }
            }
        }
        /// <summary>
        /// Permet de retourner a la page d'avant
        /// </summary>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
