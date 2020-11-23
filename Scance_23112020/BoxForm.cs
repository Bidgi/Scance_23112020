using Scance_23112020.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scance_23112020
{
    public partial class BoxForm : Form
    {
        public BoxForm()
        {
            InitializeComponent();
        }
        private void Box_Load(object sender, EventArgs e)
        {
            cbbBox.DataSource = new BindingSource(Boxs.DictionnaireBoxs, null);
            cbbBox.DisplayMember = "Value";
            cbbBox.ValueMember = "Key";
        }
        private void cbbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Position X", typeof(string));
            dt.Columns.Add("Position Y", typeof(string));
            dt.Columns.Add("Nb colis", typeof(string));
            dataGridView1.Refresh();
            foreach (Compartiments unCompartiment in ((KeyValuePair<Boxs, string>)cbbBox.SelectedItem).Key.LesCompartiment)
                dt.Rows.Add(new string[] { unCompartiment.PositionX, unCompartiment.PositionY, unCompartiment.LesColis.Count().ToString() });
            dataGridView1.DataSource = dt;
        }
        private void cbbVilleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreeBox_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierBox_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacerBox_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////

    }
}
