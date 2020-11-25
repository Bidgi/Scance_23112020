namespace Scance_23112020
{
    partial class Menu
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
            this.btnVille = new System.Windows.Forms.Button();
            this.btnBox = new System.Windows.Forms.Button();
            this.btnLivereur = new System.Windows.Forms.Button();
            this.btnColis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVille
            // 
            this.btnVille.Location = new System.Drawing.Point(217, 30);
            this.btnVille.Name = "btnVille";
            this.btnVille.Size = new System.Drawing.Size(294, 40);
            this.btnVille.TabIndex = 0;
            this.btnVille.Text = "Ville";
            this.btnVille.UseVisualStyleBackColor = true;
            this.btnVille.Click += new System.EventHandler(this.btnVille_Click);
            // 
            // btnBox
            // 
            this.btnBox.Location = new System.Drawing.Point(217, 76);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(294, 40);
            this.btnBox.TabIndex = 1;
            this.btnBox.Text = "Box";
            this.btnBox.UseVisualStyleBackColor = true;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnLivereur
            // 
            this.btnLivereur.Location = new System.Drawing.Point(217, 122);
            this.btnLivereur.Name = "btnLivereur";
            this.btnLivereur.Size = new System.Drawing.Size(294, 40);
            this.btnLivereur.TabIndex = 2;
            this.btnLivereur.Text = "Livereur";
            this.btnLivereur.UseVisualStyleBackColor = true;
            this.btnLivereur.Click += new System.EventHandler(this.btnLivereur_Click);
            // 
            // btnColis
            // 
            this.btnColis.Location = new System.Drawing.Point(217, 168);
            this.btnColis.Name = "btnColis";
            this.btnColis.Size = new System.Drawing.Size(294, 40);
            this.btnColis.TabIndex = 3;
            this.btnColis.Text = "Colis";
            this.btnColis.UseVisualStyleBackColor = true;
            this.btnColis.Click += new System.EventHandler(this.btnColis_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColis);
            this.Controls.Add(this.btnLivereur);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.btnVille);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVille;
        private System.Windows.Forms.Button btnBox;
        private System.Windows.Forms.Button btnLivereur;
        private System.Windows.Forms.Button btnColis;
    }
}