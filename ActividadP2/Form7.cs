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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;

                case "Morado":
                    this.BackColor = Color.Purple;
                    break;

                case "Azul":
                    this.BackColor = Color.Blue;
                    break;
            }
        }
    }
}
