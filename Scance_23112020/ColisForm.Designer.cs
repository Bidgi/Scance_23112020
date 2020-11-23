namespace Scance_23112020
{
    partial class ColisForm
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
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonLivre = new System.Windows.Forms.Button();
            this.buttonAffecter = new System.Windows.Forms.Button();
            this.buttonNAffecter = new System.Windows.Forms.Button();
            this.dataGriedViewColis = new System.Windows.Forms.DataGridView();
            this.labelBox = new System.Windows.Forms.Label();
            this.labelCompartiment = new System.Windows.Forms.Label();
            this.labelLivreur = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonGene = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedViewColis)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(29, 602);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(101, 39);
            this.buttonRetour.TabIndex = 0;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            // 
            // buttonLivre
            // 
            this.buttonLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLivre.Location = new System.Drawing.Point(61, 41);
            this.buttonLivre.Name = "buttonLivre";
            this.buttonLivre.Size = new System.Drawing.Size(112, 34);
            this.buttonLivre.TabIndex = 1;
            this.buttonLivre.Text = "Livrés";
            this.buttonLivre.UseVisualStyleBackColor = true;
            this.buttonLivre.Click += new System.EventHandler(this.buttonLivre_Click);
            // 
            // buttonAffecter
            // 
            this.buttonAffecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAffecter.Location = new System.Drawing.Point(254, 40);
            this.buttonAffecter.Name = "buttonAffecter";
            this.buttonAffecter.Size = new System.Drawing.Size(112, 35);
            this.buttonAffecter.TabIndex = 2;
            this.buttonAffecter.Text = "Affecter";
            this.buttonAffecter.UseVisualStyleBackColor = true;
            this.buttonAffecter.Click += new System.EventHandler(this.buttonAffecter_Click);
            // 
            // buttonNAffecter
            // 
            this.buttonNAffecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNAffecter.Location = new System.Drawing.Point(427, 40);
            this.buttonNAffecter.Name = "buttonNAffecter";
            this.buttonNAffecter.Size = new System.Drawing.Size(112, 34);
            this.buttonNAffecter.TabIndex = 3;
            this.buttonNAffecter.Text = "Non Affecter";
            this.buttonNAffecter.UseVisualStyleBackColor = true;
            this.buttonNAffecter.Click += new System.EventHandler(this.buttonNAffecter_Click);
            // 
            // dataGriedViewColis
            // 
            this.dataGriedViewColis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriedViewColis.Location = new System.Drawing.Point(61, 115);
            this.dataGriedViewColis.Name = "dataGriedViewColis";
            this.dataGriedViewColis.Size = new System.Drawing.Size(478, 209);
            this.dataGriedViewColis.TabIndex = 4;
            this.dataGriedViewColis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriedViewColis_CellContentClick);
            // 
            // labelBox
            // 
            this.labelBox.AutoSize = true;
            this.labelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBox.Location = new System.Drawing.Point(55, 395);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(68, 31);
            this.labelBox.TabIndex = 5;
            this.labelBox.Text = "Box:";
            // 
            // labelCompartiment
            // 
            this.labelCompartiment.AutoSize = true;
            this.labelCompartiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompartiment.Location = new System.Drawing.Point(55, 458);
            this.labelCompartiment.Name = "labelCompartiment";
            this.labelCompartiment.Size = new System.Drawing.Size(192, 31);
            this.labelCompartiment.TabIndex = 6;
            this.labelCompartiment.Text = "Compartiment:";
            // 
            // labelLivreur
            // 
            this.labelLivreur.AutoSize = true;
            this.labelLivreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivreur.Location = new System.Drawing.Point(55, 521);
            this.labelLivreur.Name = "labelLivreur";
            this.labelLivreur.Size = new System.Drawing.Size(113, 33);
            this.labelLivreur.TabIndex = 7;
            this.labelLivreur.Text = "Livreur:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(274, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 38);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(274, 455);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 38);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(274, 519);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 38);
            this.textBox3.TabIndex = 10;
            // 
            // buttonGene
            // 
            this.buttonGene.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGene.Location = new System.Drawing.Point(439, 330);
            this.buttonGene.Name = "buttonGene";
            this.buttonGene.Size = new System.Drawing.Size(100, 40);
            this.buttonGene.TabIndex = 11;
            this.buttonGene.Text = "Affecter";
            this.buttonGene.UseVisualStyleBackColor = true;
            this.buttonGene.Click += new System.EventHandler(this.buttonGene_Click);
            // 
            // ColisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 667);
            this.Controls.Add(this.buttonGene);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelLivreur);
            this.Controls.Add(this.labelCompartiment);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.dataGriedViewColis);
            this.Controls.Add(this.buttonNAffecter);
            this.Controls.Add(this.buttonAffecter);
            this.Controls.Add(this.buttonLivre);
            this.Controls.Add(this.buttonRetour);
            this.Name = "ColisForm";
            this.Text = "Colis";
            this.Load += new System.EventHandler(this.ColisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedViewColis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonLivre;
        private System.Windows.Forms.Button buttonAffecter;
        private System.Windows.Forms.Button buttonNAffecter;
        private System.Windows.Forms.DataGridView dataGriedViewColis;
        private System.Windows.Forms.Label labelBox;
        private System.Windows.Forms.Label labelCompartiment;
        private System.Windows.Forms.Label labelLivreur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonGene;
    }
}