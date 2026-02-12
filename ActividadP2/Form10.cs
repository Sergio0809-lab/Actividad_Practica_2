using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadP2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double numero))
            {
                label1.Text = "Es un número válido: " + numero;
            }
            else
            {
                MessageBox.Show("Error: Debe ingresar un número válido");
                textBox1.Clear();
            }
        }
    }
}
