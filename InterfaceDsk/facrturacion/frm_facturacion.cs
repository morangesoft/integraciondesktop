using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.facrturacion
{
    public partial class frm_facturacion : Form
    {
        public frm_facturacion()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (frm_facturacion_edicion f = new frm_facturacion_edicion())
            {
                f.Es_Nuevo = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //Lista();
                }
            }
        }
    }
}
