using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        private string nombre = "paco";

        private string contraseña = "contraseña";

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == nombre) && (textBox2.Text == nombre))
            {
                MessageBox.Show("Conexion establecida");

            }
            else
            {
                MessageBox.Show("No son iguales, error");

            }

        }
    }
}
