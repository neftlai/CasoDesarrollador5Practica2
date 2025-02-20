using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTA_DE_PRODUCTO_AL_CONTADO_Y_CREDITOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            frmCredito frmCredito = new frmCredito();
            frmCredito.Show();

        }

        private void btnContado_Click(object sender, EventArgs e)
        {
            frmContado frmContado = new frmContado();
            frmContado.Show();

        }
    }
}
