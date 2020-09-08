﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.alertas
{
    public partial class frm_advertencia : Form
    {
        public frm_advertencia()
        {
            InitializeComponent();
        }

        public string Valor;

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Valor = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
