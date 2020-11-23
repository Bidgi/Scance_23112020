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
    public partial class BoxForm : Form // raoul
    {
        internal static Compartiments leCompartiment;
        public BoxForm()
        {
            InitializeComponent();
        }
        private void Box_Load(object sender, EventArgs e)
        {
            Boxs b1 = new Boxs("1", " 4rue ", new GeoCoordinate(), new List<Compartiments>() {new Compartiments("5","9"), new Compartiments("4","8") });
            Boxs b2 = new Boxs("2", " 6rue ", new GeoCoordinate(), new List<Compartiments>() { });
            Colis c1 = new Colis("de", "gros", new Client(1, "girardin", "raoul", "4 rue de l'argoat", new Villes("1", "pléhédel", 22290, new List<Boxs>() { b1, b2 }), 22290, new GeoCoordinate()));
            b1.LesCompartiment.ElementAt(0).AddColis(c1);
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
        private void btnCreeCompartiment_Click(object sender, EventArgs e)
        {

        }
        private void btnModifierCompartiment_Click(object sender, EventArgs e)
        {

        }
        private void btnEffacerCompartiment_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // marche pas
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) dataGridView1.SelectedRows[i].DefaultCellStyle.BackColor = Color.Empty;
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) dataGridView1.SelectedRows[i].DefaultCellStyle.BackColor = Color.Red;
            }
            catch { }
        }

        private void btnDetailCompartiment_Click(object sender, EventArgs e)
        {
            foreach (Boxs Boxs in Boxs.CollClassBox)
                foreach (Compartiments unCompartiment in Boxs.LesCompartiment)
                    if(unCompartiment.PositionX == dataGridView1.SelectedRows[0].Cells[0].Value.ToString() && unCompartiment.PositionY == dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
                        leCompartiment = unCompartiment;
            CompartimentForm compartimentForm = new CompartimentForm();
            compartimentForm.Show();
        }
    }
}
