using Scance_23112020.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scance_23112020
{
    public partial class VilleForm : Form
    {
        public VilleForm()
        {
            InitializeComponent();
            foreach (Villes uneVille in Villes.CollClassVille)
            {
                comboBoxVille.Items.Add(uneVille.Id + "-" + uneVille.Nom);
            }
        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
