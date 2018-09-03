using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipoLogistica
{
    public partial class listaDocInvetario : Form
    {
        public listaDocInvetario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 detalle = new Form1();
            detalle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            docInventario dcInv = new docInventario();
            dcInv.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Dispose();
        }
    }
}
