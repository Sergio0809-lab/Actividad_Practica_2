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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1=int.Parse(textBox1.Text);
            int number2=int.Parse(textBox2.Text);
            int resultado =number1+number2;
            label1.Text = resultado.ToString();

        }
    }
}
