using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejertcicio3_Sueldo_neto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_AFP.Enabled = false;
            txt_descuentos.Enabled = false;
            txt_neto.Enabled = false;
            txt_SFS.Enabled = false;
            txt_Sueldo.Enabled = false;
            

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double afp, sfs, p_h, total_descuento, sueldo_neto, sueldo_bruto;

            int h_t;

            p_h = double.Parse(txt_Pago.Text);
            h_t = int.Parse(txt_Horas.Text);

            sueldo_bruto = p_h * h_t;

            afp = (sueldo_bruto * 2.87) / 100;
            sfs = (sueldo_bruto * 3.04) / 100;

            total_descuento = afp + sfs;
            sueldo_neto = sueldo_bruto - total_descuento;

            txt_AFP.Text = afp.ToString();
            txt_SFS.Text = sfs.ToString();
            txt_Sueldo.Text = sueldo_bruto.ToString();
            txt_descuentos.Text = total_descuento.ToString();
            txt_neto.Text = sueldo_neto.ToString();

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_Horas.Clear();
            txt_Pago.Clear();
            txt_AFP.Clear();
            txt_SFS.Clear();
            txt_neto.Clear();
            txt_Sueldo.Clear();
            txt_descuentos.Clear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
