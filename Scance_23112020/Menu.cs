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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            #region NewVille
            Villes lannion = new Villes("1", "Lannion", 22300);
            Villes rennes = new Villes("2", "Renne", 35000);
            Villes brest = new Villes("3", "Brest", 29200);
            Villes stBrieux = new Villes("4", "StBrieux", 22000);
            Villes paris = new Villes("5", "Paris", 75000);
            #endregion

            #region NewBoxs
            Boxs lannionboxs1 = new Boxs("1", "non renseigner", new GeoCoordinate());
            Boxs lannionboxs2 = new Boxs("2", "non renseigner", new GeoCoordinate());
            Boxs rennesboxs1 = new Boxs("3", "non renseigner", new GeoCoordinate());
            Boxs rennesboxs2 = new Boxs("4", "non renseigner", new GeoCoordinate());
            Boxs brestboxs1 = new Boxs("5", "non renseigner", new GeoCoordinate());
            Boxs brestboxs2 = new Boxs("6", "non renseigner", new GeoCoordinate());
            Boxs stBrieuxboxs1 = new Boxs("7", "non renseigner", new GeoCoordinate());
            Boxs stBrieuxboxs2 = new Boxs("8", "non renseigner", new GeoCoordinate());
            Boxs parisboxs1 = new Boxs("9", "non renseigner", new GeoCoordinate());
            Boxs parisboxs2 = new Boxs("10", "non renseigner", new GeoCoordinate());
            #endregion

            #region AddBox
            lannion.AddBox(lannionboxs1);
            lannion.AddBox(lannionboxs2);
            rennes.AddBox(rennesboxs1);
            rennes.AddBox(rennesboxs2);
            brest.AddBox(brestboxs1);
            brest.AddBox(brestboxs2);
            stBrieux.AddBox(stBrieuxboxs1);
            stBrieux.AddBox(stBrieuxboxs2);
            paris.AddBox(parisboxs1);
            paris.AddBox(parisboxs2);
            #endregion

            #region NewCompartiment
            Compartiments lannionBoxs1Compartimen1 = new Compartiments("1","2");
            Compartiments lannionBoxs1Compartimen2 = new Compartiments("2", "2");
            Compartiments lannionBoxs2Compartimen1 = new Compartiments("1", "2");
            Compartiments lannionBoxs2Compartimen2 = new Compartiments("2", "2");

            Compartiments rennesBoxs1Compartimen1 = new Compartiments("1", "2");
            Compartiments rennesBoxs1Compartimen2 = new Compartiments("2", "2");
            Compartiments rennesBoxs2Compartimen1 = new Compartiments("1", "2");
            Compartiments rennesBoxs2Compartimen2 = new Compartiments("2", "2");

            Compartiments brestBoxs1Compartimen1 = new Compartiments("1", "2");
            Compartiments brestBoxs1Compartimen2 = new Compartiments("2", "2");
            Compartiments brestBoxs2Compartimen1 = new Compartiments("1", "2");
            Compartiments brestBoxs2Compartimen2 = new Compartiments("2", "2");

            Compartiments stBrieuxBoxs1Compartimen1 = new Compartiments("1", "2");
            Compartiments stBrieuxBoxs1Compartimen2 = new Compartiments("2", "2");
            Compartiments stBrieuxBoxs2Compartimen1 = new Compartiments("1", "2");
            Compartiments stBrieuxBoxs2Compartimen2 = new Compartiments("2", "2");

            Compartiments parisBoxs1Compartimen1 = new Compartiments("1", "2");
            Compartiments parisBoxs1Compartimen2 = new Compartiments("2", "2");
            Compartiments parisBoxs2Compartimen1 = new Compartiments("1", "2");
            Compartiments parisBoxs2Compartimen2 = new Compartiments("2", "2");
            #endregion

            #region AddCompartiment
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen1);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen2);
            lannionboxs2.AddCompartiment(lannionBoxs2Compartimen1);
            lannionboxs2.AddCompartiment(lannionBoxs2Compartimen2);

            rennesboxs1.AddCompartiment(rennesBoxs1Compartimen1);
            rennesboxs1.AddCompartiment(rennesBoxs1Compartimen2);
            rennesboxs2.AddCompartiment(rennesBoxs2Compartimen1);
            rennesboxs2.AddCompartiment(rennesBoxs2Compartimen2);

            brestboxs1.AddCompartiment(brestBoxs1Compartimen1);
            brestboxs1.AddCompartiment(brestBoxs1Compartimen2);
            brestboxs2.AddCompartiment(brestBoxs2Compartimen1);
            brestboxs2.AddCompartiment(brestBoxs2Compartimen2);

            stBrieuxboxs1.AddCompartiment(stBrieuxBoxs1Compartimen1);
            stBrieuxboxs1.AddCompartiment(stBrieuxBoxs1Compartimen2);
            stBrieuxboxs2.AddCompartiment(stBrieuxBoxs2Compartimen1);
            stBrieuxboxs2.AddCompartiment(stBrieuxBoxs2Compartimen2);

            parisboxs1.AddCompartiment(parisBoxs1Compartimen1);
            parisboxs1.AddCompartiment(parisBoxs1Compartimen2);
            parisboxs2.AddCompartiment(parisBoxs2Compartimen1);
            parisboxs2.AddCompartiment(parisBoxs2Compartimen2);
            #endregion
        }
        private void btnVille_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            BoxForm boxForm = new BoxForm();
            boxForm.Show();
            this.Visible = false;
        }

        private void btnLivereur_Click(object sender, EventArgs e)
        {
            LivreurForm livreurForm = new LivreurForm();
            livreurForm.Show();
            this.Visible = false;
        }

        private void btnColis_Click(object sender, EventArgs e)
        {
            ColisForm colisForm = new ColisForm();
            colisForm.Show();
            this.Visible = false;
        }

    }
}
