using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciocio_de_dos_capas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double Nota_1, Nota_2, Nota_3, promedio;
            string condicion;

            Nota_1 = double.Parse(txtNota1.Text);
            Nota_2 = double.Parse(txtNota2.Text);
            Nota_3= double.Parse(txtNota3.Text);

            promedio = (Nota_1 + Nota_2 + Nota_3) / 3;

            if (promedio <= 29) 
            {
                condicion = "DESAPROVADO";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion.Text = condicion;
            }else if (promedio > 30 && promedio <= 50)
            {
                condicion = "APROVADO";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion.Text = condicion;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtpromedio.Clear();
            txtcondicion.Clear();
            txtNota1.Focus();
        }
    }
}
