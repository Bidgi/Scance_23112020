namespace Scance_23112020
{
    partial class Compartiment
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
            this.cbbCompartiment = new System.Windows.Forms.ComboBox();
            this.txtTauxRemplissage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbCompartiment
            // 
            this.cbbCompartiment.FormattingEnabled = true;
            this.cbbCompartiment.Location = new System.Drawing.Point(14, 78);
            this.cbbCompartiment.Name = "cbbCompartiment";
            this.cbbCompartiment.Size = new System.Drawing.Size(275, 21);
            this.cbbCompartiment.TabIndex = 30;
            this.cbbCompartiment.SelectedIndexChanged += new System.EventHandler(this.cbbCompartiment_SelectedIndexChanged);
            // 
            // txtTauxRemplissage
            // 
            this.txtTauxRemplissage.Location = new System.Drawing.Point(128, 110);
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
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Taux de remplissage :";
            // 
            // Compartiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCompartiment);
            this.Controls.Add(this.txtTauxRemplissage);
            this.Controls.Add(this.label1);
            this.Name = "Compartiment";
            this.Text = "Compartiment";
            this.Load += new System.EventHandler(this.Compartiment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCompartiment;
        private System.Windows.Forms.TextBox txtTauxRemplissage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}