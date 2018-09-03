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
    public partial class docInventario : Form
    {
        public docInventario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchCentro sc = new searchCentro();
            sc.Show();
        
        }
    }
}
