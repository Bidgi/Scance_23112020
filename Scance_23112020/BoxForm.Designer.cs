﻿namespace Scance_23112020
{
    partial class BoxForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressBox = new System.Windows.Forms.TextBox();
            this.txtCodePostalBox = new System.Windows.Forms.TextBox();
            this.cbbVilleBox = new System.Windows.Forms.ComboBox();
            this.btnCreeBox = new System.Windows.Forms.Button();
            this.btnModifierBox = new System.Windows.Forms.Button();
            this.btnEffacerBox = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDBox = new System.Windows.Forms.TextBox();
            this.btnEffacerCompartiment = new System.Windows.Forms.Button();
            this.btnModifierCompartiment = new System.Windows.Forms.Button();
            this.btnCreeCompartiment = new System.Windows.Forms.Button();
            this.btnDetailCompartiment = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code postal :";
            // 
            // txtAddressBox
            // 
            this.txtAddressBox.Location = new System.Drawing.Point(118, 59);
            this.txtAddressBox.Name = "txtAddressBox";
            this.txtAddressBox.Size = new System.Drawing.Size(169, 20);
            this.txtAddressBox.TabIndex = 6;
            // 
            // txtCodePostalBox
            // 
            this.txtCodePostalBox.Location = new System.Drawing.Point(187, 99);
            this.txtCodePostalBox.Name = "txtCodePostalBox";
            this.txtCodePostalBox.Size = new System.Drawing.Size(100, 20);
            this.txtCodePostalBox.TabIndex = 7;
            // 
            // cbbVilleBox
            // 
            this.cbbVilleBox.FormattingEnabled = true;
            this.cbbVilleBox.Location = new System.Drawing.Point(12, 98);
            this.cbbVilleBox.Name = "cbbVilleBox";
            this.cbbVilleBox.Size = new System.Drawing.Size(169, 21);
            this.cbbVilleBox.TabIndex = 8;
            this.cbbVilleBox.SelectedIndexChanged += new System.EventHandler(this.cbbVilleBox_SelectedIndexChanged);
            // 
            // btnCreeBox
            // 
            this.btnCreeBox.Location = new System.Drawing.Point(12, 125);
            this.btnCreeBox.Name = "btnCreeBox";
            this.btnCreeBox.Size = new System.Drawing.Size(84, 23);
            this.btnCreeBox.TabIndex = 9;
            this.btnCreeBox.Text = "Créer";
            this.btnCreeBox.UseVisualStyleBackColor = true;
            // 
            // btnModifierBox
            // 
            this.btnModifierBox.Location = new System.Drawing.Point(102, 125);
            this.btnModifierBox.Name = "btnModifierBox";
            this.btnModifierBox.Size = new System.Drawing.Size(84, 23);
            this.btnModifierBox.TabIndex = 10;
            this.btnModifierBox.Text = "Modifier";
            this.btnModifierBox.UseVisualStyleBackColor = true;
            // 
            // btnEffacerBox
            // 
            this.btnEffacerBox.Location = new System.Drawing.Point(192, 125);
            this.btnEffacerBox.Name = "btnEffacerBox";
            this.btnEffacerBox.Size = new System.Drawing.Size(95, 23);
            this.btnEffacerBox.TabIndex = 11;
            this.btnEffacerBox.Text = "Effacer";
            this.btnEffacerBox.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(275, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cbbBox
            // 
            this.cbbBox.FormattingEnabled = true;
            this.cbbBox.Location = new System.Drawing.Point(396, 41);
            this.cbbBox.Name = "cbbBox";
            this.cbbBox.Size = new System.Drawing.Size(275, 21);
            this.cbbBox.TabIndex = 13;
            this.cbbBox.SelectedIndexChanged += new System.EventHandler(this.cbbBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Selectionner un box :";
            // 
            // txtIDBox
            // 
            this.txtIDBox.Location = new System.Drawing.Point(12, 59);
            this.txtIDBox.Name = "txtIDBox";
            this.txtIDBox.Size = new System.Drawing.Size(100, 20);
            this.txtIDBox.TabIndex = 5;
            // 
            // btnEffacerCompartiment
            // 
            this.btnEffacerCompartiment.Location = new System.Drawing.Point(670, 224);
            this.btnEffacerCompartiment.Name = "btnEffacerCompartiment";
            this.btnEffacerCompartiment.Size = new System.Drawing.Size(95, 23);
            this.btnEffacerCompartiment.TabIndex = 17;
            this.btnEffacerCompartiment.Text = "Effacer";
            this.btnEffacerCompartiment.UseVisualStyleBackColor = true;
            this.btnEffacerCompartiment.Click += new System.EventHandler(this.btnEffacerCompartiment_Click);
            // 
            // btnModifierCompartiment
            // 
            this.btnModifierCompartiment.Location = new System.Drawing.Point(580, 224);
            this.btnModifierCompartiment.Name = "btnModifierCompartiment";
            this.btnModifierCompartiment.Size = new System.Drawing.Size(84, 23);
            this.btnModifierCompartiment.TabIndex = 16;
            this.btnModifierCompartiment.Text = "Modifier";
            this.btnModifierCompartiment.UseVisualStyleBackColor = true;
            this.btnModifierCompartiment.Click += new System.EventHandler(this.btnModifierCompartiment_Click);
            // 
            // btnCreeCompartiment
            // 
            this.btnCreeCompartiment.Location = new System.Drawing.Point(490, 224);
            this.btnCreeCompartiment.Name = "btnCreeCompartiment";
            this.btnCreeCompartiment.Size = new System.Drawing.Size(84, 23);
            this.btnCreeCompartiment.TabIndex = 15;
            this.btnCreeCompartiment.Text = "Créer";
            this.btnCreeCompartiment.UseVisualStyleBackColor = true;
            this.btnCreeCompartiment.Click += new System.EventHandler(this.btnCreeCompartiment_Click);
            // 
            // btnDetailCompartiment
            // 
            this.btnDetailCompartiment.Location = new System.Drawing.Point(400, 224);
            this.btnDetailCompartiment.Name = "btnDetailCompartiment";
            this.btnDetailCompartiment.Size = new System.Drawing.Size(84, 23);
            this.btnDetailCompartiment.TabIndex = 18;
            this.btnDetailCompartiment.Text = "Détaille";
            this.btnDetailCompartiment.UseVisualStyleBackColor = true;
            this.btnDetailCompartiment.Click += new System.EventHandler(this.btnDetailCompartiment_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(564, 356);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(187, 27);
            this.btnRetour.TabIndex = 19;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // BoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnDetailCompartiment);
            this.Controls.Add(this.btnEffacerCompartiment);
            this.Controls.Add(this.btnModifierCompartiment);
            this.Controls.Add(this.btnCreeCompartiment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEffacerBox);
            this.Controls.Add(this.btnModifierBox);
            this.Controls.Add(this.btnCreeBox);
            this.Controls.Add(this.cbbVilleBox);
            this.Controls.Add(this.txtCodePostalBox);
            this.Controls.Add(this.txtAddressBox);
            this.Controls.Add(this.txtIDBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BoxForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Box_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressBox;
        private System.Windows.Forms.TextBox txtCodePostalBox;
        private System.Windows.Forms.ComboBox cbbVilleBox;
        private System.Windows.Forms.Button btnCreeBox;
        private System.Windows.Forms.Button btnModifierBox;
        private System.Windows.Forms.Button btnEffacerBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDBox;
        private System.Windows.Forms.Button btnEffacerCompartiment;
        private System.Windows.Forms.Button btnModifierCompartiment;
        private System.Windows.Forms.Button btnCreeCompartiment;
        private System.Windows.Forms.Button btnDetailCompartiment;
        private System.Windows.Forms.Button btnRetour;
    }
}

