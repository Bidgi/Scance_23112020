using Scance_23112020.Model;
using System;
using System.Windows.Forms;

namespace Scance_23112020
{
    static class Program
    {
        internal static Menu menu;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region NewVille
            Villes lannion = new Villes("Lannion", 22300, "France");
            Villes rennes = new Villes("Renne", 35000, "France");
            Villes brest = new Villes("Brest", 29200, "France");
            Villes stBrieux = new Villes("StBrieux", 22000, "France");
            Villes paris = new Villes("Paris", 75000, "France");
            Villes pléhédel = new Villes("pléhédel", 22290, "France");
            #endregion

            #region NewBoxs
            Boxs lannionboxs1 = new Boxs( new Adresses(lannion, "non renseigner"));
            Boxs lannionboxs2 = new Boxs( new Adresses(lannion, "non renseigner"));
            Boxs rennesboxs1 = new Boxs( new Adresses(lannion, "non renseigner"));
            Boxs rennesboxs2 = new Boxs( new Adresses(lannion, "non renseigner"));
            Boxs brestboxs1 = new Boxs( new Adresses(lannion, "non renseigner"));
            Boxs brestboxs2 = new Boxs(new Adresses(lannion, "non renseigner"));
            Boxs stBrieuxboxs1 = new Boxs(new Adresses(lannion, "non renseigner"));
            Boxs stBrieuxboxs2 = new Boxs( new Adresses(lannion, "non renseigner"));
            Boxs parisboxs1 = new Boxs( new Adresses(lannion, "non renseigner"));
            Boxs parisboxs2 = new Boxs(new Adresses(lannion, "non renseigner"));
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
            Compartiments lannionBoxs1Compartimen1 = new Compartiments("1", "1");
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
            Client_Pro client_Pro = new Client_Pro(1, "girardin", "raoul", new Adresses(pléhédel, "4 rue de l'argoat"), 0, 0);
            Client_Indi client_Indi = new Client_Indi(2, "jezequel", "ewen", new Adresses(lannion, "37 Rue des Cordiers"), 0);
            #endregion

            #region NewColis
            Colis petitColisPro1 = new Colis( "petit", client_Pro);
            Colis petitColisPro2 = new Colis( "petit", client_Pro);
            Colis petitColisPro3 = new Colis( "petit", client_Pro);
            Colis petitColisPro4 = new Colis( "petit", client_Pro);

            Colis petitColisIndi1 = new Colis( "petit", client_Indi);
            Colis petitColisIndi2 = new Colis( "petit", client_Indi);
            Colis petitColisIndi3 = new Colis( "petit", client_Indi);
            Colis petitColisIndi4 = new Colis( "petit", client_Indi);

            Colis grosColisPro1 = new Colis( "gros", client_Pro);
            Colis grosColisPro2 = new Colis( "gros", client_Pro);

            Colis grosColisIndi1 = new Colis( "gros", client_Indi);
            Colis grosColisIndi2 = new Colis( "gros", client_Indi);
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

            #region NewLivreur
            Livreurs l1 = new Livreurs("Malo");
            Livreurs l2 = new Livreurs( "Galaad");
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            menu = new Menu();
            Application.Run(menu);
        }
    }
}
