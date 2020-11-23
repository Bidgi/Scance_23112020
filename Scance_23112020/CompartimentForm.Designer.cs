namespace Scance_23112020
{
    partial class CompartimentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTauxRemplissage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreColis = new System.Windows.Forms.TextBox();
            this.txtNombreGrosColis = new System.Windows.Forms.TextBox();
            this.txtNombrePetitColis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbColis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.txtVilleClient = new System.Windows.Forms.TextBox();
            this.txtAdresseClient = new System.Windows.Forms.TextBox();
            this.txtIdColis = new System.Windows.Forms.TextBox();
            this.txtVolumeColis = new System.Windows.Forms.TextBox();
            this.txtEtatColis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTauxRemplissage
            // 
            this.txtTauxRemplissage.Location = new System.Drawing.Point(128, 73);
            this.txtTauxRemplissage.Name = "txtTauxRemplissage";
            this.txtTauxRemplissage.Size = new System.Drawing.Size(57, 20);
            this.txtTauxRemplissage.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Compartiment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Taux de remplissage :";
            // 
            // txtNombreColis
            // 
            this.txtNombreColis.Location = new System.Drawing.Point(128, 99);
            this.txtNombreColis.Name = "txtNombreColis";
            this.txtNombreColis.Size = new System.Drawing.Size(100, 20);
            this.txtNombreColis.TabIndex = 32;
            // 
            // txtNombreGrosColis
            // 
            this.txtNombreGrosColis.Location = new System.Drawing.Point(128, 125);
            this.txtNombreGrosColis.Name = "txtNombreGrosColis";
            this.txtNombreGrosColis.Size = new System.Drawing.Size(100, 20);
            this.txtNombreGrosColis.TabIndex = 33;
            // 
            // txtNombrePetitColis
            // 
            this.txtNombrePetitColis.Location = new System.Drawing.Point(128, 151);
            this.txtNombrePetitColis.Name = "txtNombrePetitColis";
            this.txtNombrePetitColis.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePetitColis.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombre colis :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombre Gros colis :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nombre petit colis :";
            // 
            // cbbColis
            // 
            this.cbbColis.FormattingEnabled = true;
            this.cbbColis.Location = new System.Drawing.Point(15, 221);
            this.cbbColis.Name = "cbbColis";
            this.cbbColis.Size = new System.Drawing.Size(151, 21);
            this.cbbColis.TabIndex = 38;
            this.cbbColis.SelectedIndexChanged += new System.EventHandler(this.cbbColis_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Selectionner un colis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "ID colis :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Volume :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Etat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Info colis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(325, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "Info client";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Nom :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Prenom :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Ville :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(320, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Adresse :";
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(377, 99);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(76, 20);
            this.txtNomClient.TabIndex = 49;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.Location = new System.Drawing.Point(377, 125);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(76, 20);
            this.txtPrenomClient.TabIndex = 50;
            // 
            // txtVilleClient
            // 
            this.txtVilleClient.Location = new System.Drawing.Point(377, 151);
            this.txtVilleClient.Name = "txtVilleClient";
            this.txtVilleClient.Size = new System.Drawing.Size(76, 20);
            this.txtVilleClient.TabIndex = 51;
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Location = new System.Drawing.Point(377, 177);
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.Size = new System.Drawing.Size(76, 20);
            this.txtAdresseClient.TabIndex = 52;
            // 
            // txtIdColis
            // 
            this.txtIdColis.Location = new System.Drawing.Point(128, 270);
            this.txtIdColis.Name = "txtIdColis";
            this.txtIdColis.Size = new System.Drawing.Size(76, 20);
            this.txtIdColis.TabIndex = 53;
            // 
            // txtVolumeColis
            // 
            this.txtVolumeColis.Location = new System.Drawing.Point(128, 296);
            this.txtVolumeColis.Name = "txtVolumeColis";
            this.txtVolumeColis.Size = new System.Drawing.Size(76, 20);
            this.txtVolumeColis.TabIndex = 54;
            // 
            // txtEtatColis
            // 
            this.txtEtatColis.Location = new System.Drawing.Point(128, 322);
            this.txtEtatColis.Name = "txtEtatColis";
            this.txtEtatColis.Size = new System.Drawing.Size(76, 20);
            this.txtEtatColis.TabIndex = 55;
            // 
            // CompartimentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEtatColis);
            this.Controls.Add(this.txtVolumeColis);
            this.Controls.Add(this.txtIdColis);
            this.Controls.Add(this.txtAdresseClient);
            this.Controls.Add(this.txtVilleClient);
            this.Controls.Add(this.txtPrenomClient);
            this.Controls.Add(this.txtNomClient);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbColis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombrePetitColis);
            this.Controls.Add(this.txtNombreGrosColis);
            this.Controls.Add(this.txtNombreColis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTauxRemplissage);
            this.Controls.Add(this.label1);
            this.Name = "CompartimentForm";
            this.Text = "Compartiment";
            this.Load += new System.EventHandler(this.Compartiment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTauxRemplissage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreColis;
        private System.Windows.Forms.TextBox txtNombreGrosColis;
        private System.Windows.Forms.TextBox txtNombrePetitColis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbColis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox txtPrenomClient;
        private System.Windows.Forms.TextBox txtVilleClient;
        private System.Windows.Forms.TextBox txtAdresseClient;
        private System.Windows.Forms.TextBox txtIdColis;
        private System.Windows.Forms.TextBox txtVolumeColis;
        private System.Windows.Forms.TextBox txtEtatColis;
    }
}