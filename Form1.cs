using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_INTEGRADOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botoninicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox11.Text.Trim()))
            {
                MessageBox.Show("No haz ingresado tu nombre ingresalo.");
                return;
            }
            Nombre1.nombreusuario = textBox11.Text;
            Form2 chepe = new Form2();
            chepe.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textointro_Click(object sender, EventArgs e)
        {

        }
    }
}