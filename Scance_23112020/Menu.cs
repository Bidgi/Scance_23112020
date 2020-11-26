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
            Villes lannion = new Villes(1, "Lannion", 22300);
            Villes rennes = new Villes(2, "Renne", 35000);
            Villes brest = new Villes(3, "Brest", 29200);
            Villes stBrieux = new Villes(4, "StBrieux", 22000);
            Villes paris = new Villes(5, "Paris", 75000);
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
            Compartiments lannionBoxs1Compartimen1 = new Compartiments("1","1");
            Compartiments lannionBoxs1Compartimen2 = new Compartiments("1", "2");
            Compartiments lannionBoxs1Compartimen3 = new Compartiments("1", "3");
            Compartiments lannionBoxs1Compartimen4 = new Compartiments("1", "4");
            Compartiments lannionBoxs1Compartimen5 = new Compartiments("2", "1");
            Compartiments lannionBoxs1Compartimen6 = new Compartiments("2", "2");
            Compartiments lannionBoxs1Compartimen7 = new Compartiments("2", "3");
            Compartiments lannionBoxs1Compartimen8 = new Compartiments("2", "4");
            Compartiments lannionBoxs1Compartimen9 = new Compartiments("3", "1");
            Compartiments lannionBoxs1Compartimen10 = new Compartiments("3", "2");
            Compartiments lannionBoxs1Compartimen11 = new Compartiments("3", "3");
            Compartiments lannionBoxs1Compartimen12 = new Compartiments("3", "4");
            Compartiments lannionBoxs1Compartimen13 = new Compartiments("4", "1");
            Compartiments lannionBoxs1Compartimen14 = new Compartiments("4", "2");
            Compartiments lannionBoxs1Compartimen15 = new Compartiments("4", "3");
            Compartiments lannionBoxs1Compartimen16 = new Compartiments("4", "4");

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
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen3);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen4);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen5);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen6);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen7);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen8);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen9);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen10);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen11);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen12);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen13);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen14);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen15);
            lannionboxs1.AddCompartiment(lannionBoxs1Compartimen16);

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

            #region NewClient
            Client_Pro client_Pro = new Client_Pro(1, "girardin", "raoul", "4 rue de l'argoat", lannion, new GeoCoordinate(),0,0);
            Client_Indi client_Indi = new Client_Indi(2, "jezequel", "ewen", "1 rue de l'argoat", lannion, new GeoCoordinate(), 0);
            #endregion

            #region NewColis
            Colis petitColisPro1 = new Colis("1", "petit", client_Pro);
            Colis petitColisPro2 = new Colis("2", "petit", client_Pro);
            Colis petitColisPro3 = new Colis("3", "petit", client_Pro);
            Colis petitColisPro4 = new Colis("4", "petit", client_Pro);

            Colis petitColisIndi1 = new Colis("5", "petit", client_Indi);
            Colis petitColisIndi2 = new Colis("6", "petit", client_Indi);
            Colis petitColisIndi3 = new Colis("7", "petit", client_Indi);
            Colis petitColisIndi4 = new Colis("8", "petit", client_Indi);

            Colis grosColisPro1 = new Colis("9", "gros", client_Pro);
            Colis grosColisPro2 = new Colis("10", "gros", client_Pro);

            Colis grosColisIndi1 = new Colis("11", "gros", client_Indi);
            Colis grosColisIndi2 = new Colis("12", "gros", client_Indi);
            #endregion

            #region AddColis
            lannionBoxs1Compartimen1.AddColis(petitColisPro1);
            lannionBoxs1Compartimen1.AddColis(petitColisPro2);
            lannionBoxs1Compartimen1.AddColis(grosColisPro1);

            lannionBoxs1Compartimen4.AddColis(petitColisPro3);
            lannionBoxs1Compartimen4.AddColis(petitColisPro4);

            lannionBoxs1Compartimen5.AddColis(grosColisPro2);

            lannionBoxs1Compartimen9.AddColis(petitColisIndi4);
            lannionBoxs1Compartimen9.AddColis(petitColisIndi3);
            lannionBoxs1Compartimen9.AddColis(petitColisIndi2);

            lannionBoxs1Compartimen12.AddColis(petitColisIndi1);

            lannionBoxs1Compartimen16.AddColis(grosColisIndi1);
            lannionBoxs1Compartimen16.AddColis(grosColisIndi2);
            #endregion
        }
        private void btnVille_Click(object sender, EventArgs e)
        {
            VilleForm villeForm = new VilleForm();
            villeForm.Show();
            this.Visible = false;
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
