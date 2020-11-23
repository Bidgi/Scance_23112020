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
    public partial class LivreurForm : Form
    {
        public LivreurForm()
        {
            InitializeComponent();
        }

        private void rBtnJour_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnJour.Checked)
            {
                rBtnMois.Checked = false;
                rBtnSemaine.Checked = false;
            }
        }

        private void rBtnSemaine_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnJour.Checked)
            {
                rBtnJour.Checked = false;
                rBtnMois.Checked = false;
            }
        }

        private void rBtnMois_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMois.Checked)
            {
                rBtnJour.Checked = false;
                rBtnSemaine.Checked = false;
            }
        }

        private void LivreurForm_Load(object sender, EventArgs e)
        {

        }
    }
}
