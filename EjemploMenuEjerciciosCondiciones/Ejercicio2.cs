using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMenuEjerciciosCondiciones
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            double numero;
            numero = double.Parse(txtnumero.Text);

            if (numero > 0)
            {
                lblrespuesta.Text = "POSITIVO";
            }
            else if (numero < 0)
            {
                lblrespuesta.Text = "NEGATIVO";
            }
            else {
                lblrespuesta.Text = "NEUTRO - 0";
            }

            lblrespuesta.Visible = true;

        }

        private void pbsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }
    }
}
