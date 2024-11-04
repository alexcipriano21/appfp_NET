using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appfp_NET.condicionales
{
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            if (numero > 0) txtSigno.Text = "Positivo";
            else if (numero < 0) txtSigno.Text = "Negativo";
            else txtSigno.Text = "Cero";

            txtSigno.Text = numero > 0 ? "Positivo" : numero < 0 ? "Negativo" : "Cero";
        }
    }
}
