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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            numero1 = double.Parse(txtnumero1.Text);
            numero2 = double.Parse(txtnumero2.Text);

            if (numero1 > numero2)
            {
                lblresultado.Text = "El primer número es el mayor";
            }
            else if (numero2 > numero1)
            {
                lblresultado.Text = "El segundo número es el mayor";
            }
            else {
                lblresultado.Text = "Los números son iguales.";
            }

            lblresultado.Visible = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();                
        }
    }
}
