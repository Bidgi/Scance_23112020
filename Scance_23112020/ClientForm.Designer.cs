namespace Scance_23112020
{
    partial class ClientForm
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
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCréer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.labelCoupon = new System.Windows.Forms.Label();
            this.textBoxCoupon = new System.Windows.Forms.TextBox();
            this.labelErreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Items.AddRange(new object[] {
            "Nouveau client"});
            this.comboBoxClient.Location = new System.Drawing.Point(371, 34);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 0;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(65, 78);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID:";
            this.labelID.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(65, 110);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 13);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom:";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(65, 150);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 5;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(320, 192);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(24, 13);
            this.labelCP.TabIndex = 6;
            this.labelCP.Text = "CP:";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(65, 189);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(29, 13);
            this.labelVille.TabIndex = 7;
            this.labelVille.Text = "Ville:";
            this.labelVille.Click += new System.EventHandler(this.Label7_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(320, 106);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 8;
            this.labelPrenom.Text = "Prénom";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(115, 75);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(115, 107);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 10;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(115, 147);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(354, 20);
            this.textBoxAdresse.TabIndex = 13;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(369, 189);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(100, 20);
            this.textBoxCP.TabIndex = 14;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(369, 103);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 15;
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(115, 186);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVille.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 122);
            this.dataGridView1.TabIndex = 17;
            // 
            // buttonCréer
            // 
            this.buttonCréer.Location = new System.Drawing.Point(255, 232);
            this.buttonCréer.Name = "buttonCréer";
            this.buttonCréer.Size = new System.Drawing.Size(75, 23);
            this.buttonCréer.TabIndex = 18;
            this.buttonCréer.Text = "Créer";
            this.buttonCréer.UseVisualStyleBackColor = true;
            this.buttonCréer.Click += new System.EventHandler(this.ButtonCréer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(336, 232);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 19;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.ButtonModifier_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(417, 232);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 20;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            // 
            // labelCoupon
            // 
            this.labelCoupon.AutoSize = true;
            this.labelCoupon.Location = new System.Drawing.Point(65, 237);
            this.labelCoupon.Name = "labelCoupon";
            this.labelCoupon.Size = new System.Drawing.Size(47, 13);
            this.labelCoupon.TabIndex = 21;
            this.labelCoupon.Text = "Coupon:";
            // 
            // textBoxCoupon
            // 
            this.textBoxCoupon.Location = new System.Drawing.Point(118, 232);
            this.textBoxCoupon.Name = "textBoxCoupon";
            this.textBoxCoupon.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoupon.TabIndex = 22;
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(65, 266);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(35, 13);
            this.labelErreur.TabIndex = 23;
            this.labelErreur.Text = "label1";
            this.labelErreur.Visible = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 406);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.textBoxCoupon);
            this.Controls.Add(this.labelCoupon);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonCréer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.comboBoxClient);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCréer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.Label labelCoupon;
        private System.Windows.Forms.TextBox textBoxCoupon;
        private System.Windows.Forms.Label labelErreur;
    }
}