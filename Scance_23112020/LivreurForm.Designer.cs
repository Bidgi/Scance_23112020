namespace Scance_23112020
{
    partial class LivreurForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLivreur = new System.Windows.Forms.ComboBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnCree = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rBtnJour = new System.Windows.Forms.RadioButton();
            this.rBtnSemaine = new System.Windows.Forms.RadioButton();
            this.rBtnMois = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Selectionner un Livreur :";
            // 
            // cbbLivreur
            // 
            this.cbbLivreur.FormattingEnabled = true;
            this.cbbLivreur.Location = new System.Drawing.Point(26, 76);
            this.cbbLivreur.Name = "cbbLivreur";
            this.cbbLivreur.Size = new System.Drawing.Size(275, 21);
            this.cbbLivreur.TabIndex = 31;
            this.cbbLivreur.SelectedIndexChanged += new System.EventHandler(this.cbbLivreur_SelectedIndexChanged);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(206, 196);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(95, 23);
            this.btnEffacer.TabIndex = 29;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(116, 196);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(84, 23);
            this.btnModifier.TabIndex = 28;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnCree
            // 
            this.btnCree.Location = new System.Drawing.Point(26, 196);
            this.btnCree.Name = "btnCree";
            this.btnCree.Size = new System.Drawing.Size(84, 23);
            this.btnCree.TabIndex = 27;
            this.btnCree.Text = "Créer";
            this.btnCree.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(26, 160);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(119, 20);
            this.txtNom.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(26, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 20);
            this.txtID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Livreur";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 165);
            this.dataGridView1.TabIndex = 33;
            // 
            // rBtnJour
            // 
            this.rBtnJour.AutoSize = true;
            this.rBtnJour.Location = new System.Drawing.Point(24, 19);
            this.rBtnJour.Name = "rBtnJour";
            this.rBtnJour.Size = new System.Drawing.Size(45, 17);
            this.rBtnJour.TabIndex = 34;
            this.rBtnJour.TabStop = true;
            this.rBtnJour.Text = "Jour";
            this.rBtnJour.UseVisualStyleBackColor = true;
            this.rBtnJour.CheckedChanged += new System.EventHandler(this.rBtnJour_CheckedChanged);
            // 
            // rBtnSemaine
            // 
            this.rBtnSemaine.AutoSize = true;
            this.rBtnSemaine.Location = new System.Drawing.Point(75, 19);
            this.rBtnSemaine.Name = "rBtnSemaine";
            this.rBtnSemaine.Size = new System.Drawing.Size(66, 17);
            this.rBtnSemaine.TabIndex = 35;
            this.rBtnSemaine.TabStop = true;
            this.rBtnSemaine.Text = "Semaine";
            this.rBtnSemaine.UseVisualStyleBackColor = true;
            this.rBtnSemaine.CheckedChanged += new System.EventHandler(this.rBtnSemaine_CheckedChanged);
            // 
            // rBtnMois
            // 
            this.rBtnMois.AutoSize = true;
            this.rBtnMois.Location = new System.Drawing.Point(147, 19);
            this.rBtnMois.Name = "rBtnMois";
            this.rBtnMois.Size = new System.Drawing.Size(47, 17);
            this.rBtnMois.TabIndex = 36;
            this.rBtnMois.TabStop = true;
            this.rBtnMois.Text = "Mois";
            this.rBtnMois.UseVisualStyleBackColor = true;
            this.rBtnMois.CheckedChanged += new System.EventHandler(this.rBtnMois_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTP);
            this.groupBox1.Controls.Add(this.rBtnMois);
            this.groupBox1.Controls.Add(this.rBtnJour);
            this.groupBox1.Controls.Add(this.rBtnSemaine);
            this.groupBox1.Location = new System.Drawing.Point(26, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 42);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectionner";
            // 
            // dTP
            // 
            this.dTP.Location = new System.Drawing.Point(200, 15);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(182, 20);
            this.dTP.TabIndex = 40;
            this.dTP.ValueChanged += new System.EventHandler(this.dTP_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Gains :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 461);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 39;
            // 
            // LivreurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbLivreur);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnCree);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LivreurForm";
            this.Text = "Livreur";
            this.Load += new System.EventHandler(this.LivreurForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbLivreur;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnCree;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rBtnJour;
        private System.Windows.Forms.RadioButton rBtnSemaine;
        private System.Windows.Forms.RadioButton rBtnMois;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}