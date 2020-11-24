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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewBoxs = new System.Windows.Forms.DataGridView();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(69, 193);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(75, 23);
            this.buttonCreer.TabIndex = 4;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Effacer";
            this.button3.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(334, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
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
            // VilleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 419);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.dataGridViewBoxs);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNomVille);
            this.Controls.Add(this.labelIDVille);
            this.Name = "VilleForm";
            this.Text = "VilleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDVille;
        private System.Windows.Forms.Label labelNomVille;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewBoxs;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelCodePostal;
    }
}