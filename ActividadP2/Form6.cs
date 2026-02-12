using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadP2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Seleccionaste Aceptar";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Seleccionaste Rechazar";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Seleccionaste Error 404";
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opción");
            }
        }
    }
}
