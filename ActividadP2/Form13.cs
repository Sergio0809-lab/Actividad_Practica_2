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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float temperatur_C= float.Parse(textBox1.Text);
            double temperatur_F = (temperatur_C * 1.8) + 32;
            label1.Text = temperatur_F.ToString();

        }
    }
}
