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
        private static string nombre = "paco";

        private static string contraseña = "contraseña";

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
            if ((textBox1.Text == nombre) && (textBox2.Text == contraseña))
            {
                MessageBox.Show("Conexión establecida");

                Form2 form2 = new Form2();

                form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("No son iguales, error");
            }

        }

        public static string GetNombre()
        {
            return nombre;
        }

        public static string GetContraseña()
        {
            return contraseña;
        }
    }
}
