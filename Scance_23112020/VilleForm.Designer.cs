﻿namespace Scance_23112020
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDVille
            // 
            this.labelIDVille.AutoSize = true;
            this.labelIDVille.Location = new System.Drawing.Point(66, 99);
            this.labelIDVille.Name = "labelIDVille";
            this.labelIDVille.Size = new System.Drawing.Size(18, 13);
            this.labelIDVille.TabIndex = 0;
            this.labelIDVille.Text = "ID";
            // 
            // labelNomVille
            // 
            this.labelNomVille.AutoSize = true;
            this.labelNomVille.Location = new System.Drawing.Point(201, 100);
            this.labelNomVille.Name = "labelNomVille";
            this.labelNomVille.Size = new System.Drawing.Size(26, 13);
            this.labelNomVille.TabIndex = 1;
            this.labelNomVille.Text = "Ville";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(69, 116);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(204, 116);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxVille.TabIndex = 3;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(69, 193);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(75, 23);
            this.buttonCreer.TabIndex = 4;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.ButtonCreer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(218, 193);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 5;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(359, 193);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 6;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dataGridViewBoxs
            // 
            this.dataGridViewBoxs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoxs.Location = new System.Drawing.Point(69, 243);
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
            this.textBoxCP.Location = new System.Drawing.Point(334, 116);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(100, 20);
            this.textBoxCP.TabIndex = 9;
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(331, 99);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(64, 13);
            this.labelCodePostal.TabIndex = 10;
            this.labelCodePostal.Text = "Code Postal";
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(69, 174);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(155, 13);
            this.labelErreur.TabIndex = 11;
            this.labelErreur.Text = "Une ville possède déjà cette ID";
            this.labelErreur.Visible = false;
            // 
            // VilleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 419);
            this.Controls.Add(this.labelErreur);
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
    }
}