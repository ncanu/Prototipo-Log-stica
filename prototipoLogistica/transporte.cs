﻿using System;
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
    public partial class transporte : Form
    {
        public transporte()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dateTimePicker1.Font = new Font("Arial", 16, FontStyle.Regular);
        }
    }
}
