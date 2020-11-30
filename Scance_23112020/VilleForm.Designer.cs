namespace Scance_23112020
{
    partial class VilleForm
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
            this.labelIDVille = new System.Windows.Forms.Label();
            this.labelNomVille = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.dataGridViewBoxs = new System.Windows.Forms.DataGridView();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnDétailBox = new System.Windows.Forms.Button();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDVille
            // 
            this.labelIDVille.AutoSize = true;
            this.labelIDVille.Location = new System.Drawing.Point(66, 75);
            this.labelIDVille.Name = "labelIDVille";
            this.labelIDVille.Size = new System.Drawing.Size(18, 13);
            this.labelIDVille.TabIndex = 0;
            this.labelIDVille.Text = "ID";
            // 
            // labelNomVille
            // 
            this.labelNomVille.AutoSize = true;
            this.labelNomVille.Location = new System.Drawing.Point(66, 121);
            this.labelNomVille.Name = "labelNomVille";
            this.labelNomVille.Size = new System.Drawing.Size(26, 13);
            this.labelNomVille.TabIndex = 1;
            this.labelNomVille.Text = "Ville";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(69, 92);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 2;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(69, 137);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(259, 20);
            this.textBoxVille.TabIndex = 3;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(69, 242);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(75, 23);
            this.buttonCreer.TabIndex = 4;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.ButtonCreer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(218, 242);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 5;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(359, 242);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 6;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBoxs
            // 
            this.dataGridViewBoxs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoxs.Location = new System.Drawing.Point(69, 292);
            this.dataGridViewBoxs.Name = "dataGridViewBoxs";
            this.dataGridViewBoxs.Size = new System.Drawing.Size(365, 150);
            this.dataGridViewBoxs.TabIndex = 7;
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Items.AddRange(new object[] {
            "Nouvelles Villes"});
            this.comboBoxVille.Location = new System.Drawing.Point(69, 37);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(365, 21);
            this.comboBoxVille.TabIndex = 8;
            this.comboBoxVille.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(334, 137);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(100, 20);
            this.textBoxCP.TabIndex = 9;
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(331, 120);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(64, 13);
            this.labelCodePostal.TabIndex = 10;
            this.labelCodePostal.Text = "Code Postal";
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(69, 223);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(155, 13);
            this.labelErreur.TabIndex = 11;
            this.labelErreur.Text = "Une ville possède déjà cette ID";
            this.labelErreur.Visible = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(247, 448);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(187, 27);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnDétailBox
            // 
            this.btnDétailBox.Location = new System.Drawing.Point(69, 448);
            this.btnDétailBox.Name = "btnDétailBox";
            this.btnDétailBox.Size = new System.Drawing.Size(75, 23);
            this.btnDétailBox.TabIndex = 12;
            this.btnDétailBox.Text = "Détail box";
            this.btnDétailBox.UseVisualStyleBackColor = true;
            this.btnDétailBox.Click += new System.EventHandler(this.btnDétailBox_Click);
            // 
            // txtPays
            // 
            this.txtPays.Enabled = false;
            this.txtPays.Location = new System.Drawing.Point(175, 92);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(259, 20);
            this.txtPays.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pays";
            // 
            // VilleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.btnDétailBox);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.dataGridViewBoxs);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelNomVille);
            this.Controls.Add(this.labelIDVille);
            this.Name = "VilleForm";
            this.Text = "VilleForm";
            this.Load += new System.EventHandler(this.VilleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDVille;
        private System.Windows.Forms.Label labelNomVille;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.DataGridView dataGridViewBoxs;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnDétailBox;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label label1;
    }
}