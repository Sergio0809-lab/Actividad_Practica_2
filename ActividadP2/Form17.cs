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
    public partial class Form17 : Form
    {
        double numero1 = 0;
        double numero2 = 0;
        string operacion = "";
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numero1 = 0;
            numero2 = 0;
            operacion = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            operacion = "+";
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            operacion = "-";
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            operacion = "*";
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            operacion = "/";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBox1.Text);

            switch (operacion)
            {
                case "+":
                    textBox1.Text = (numero1 + numero2).ToString();
                    break;

                case "-":
                    textBox1.Text = (numero1 - numero2).ToString();
                    break;

                case "*":
                    textBox1.Text = (numero1 * numero2).ToString();
                    break;

                case "/":
                    if (numero2 != 0)
                        textBox1.Text = (numero1 / numero2).ToString();
                    else
                        MessageBox.Show("No se puede dividir entre cero");
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                return;

            textBox1.Text += "0";
        }
    }
}
