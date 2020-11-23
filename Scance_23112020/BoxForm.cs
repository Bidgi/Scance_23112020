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
    public partial class BoxForm : Form
    {
        public BoxForm()
        {
            InitializeComponent();
        }

        private void Box_Load(object sender, EventArgs e)
        {
            // Bind combobox to dictionary
            Dictionary<Boxs, string> test = new Dictionary<Boxs, string>();

            foreach (Boxs unBox in Boxs.CollClassBox)
            {
                test.Add(unBox, unBox.Id);
            }
            cbbBox.DataSource = new BindingSource(test, null);
            cbbBox.DisplayMember = "Value";
            cbbBox.ValueMember = "Key";

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<Boxs, string>)cbbBox.SelectedItem).Value;
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
