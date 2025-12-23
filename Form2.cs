using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INTEGRADOR
{
    public partial class Form2 : Form
    {
        private string textBox1;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bienve.Text = "Bienvenido: " + Nombre1.nombreusuario;  //No tocar si lo tocas te macheteo
        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void Interfaz3_Click(object sender, EventArgs e)
        {
            Factores che = new Factores();
            che.Show();
            this.Hide();
        }

        private void Interfaz1_Click(object sender, EventArgs e)
        {
            Form3 chepe2 = new Form3();  //no tocar te macheteo
            chepe2.Show();  //no tocar te macheteo
            this.Hide();    //no tocar te macheteo
        }

        private void Form2_VisibleChanged(object sender, EventArgs e) //esto si vale un poco verga pero no lo toquen
        {
            if (this.Visible)
            {
                // Actualizar por si cambió (aunque sea estático)
                Bienve.Text = "Bienvenido: " + Nombre1.nombreusuario;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 chepe5 = new Form4();
            chepe5.Show();
            this.Hide();
        }

        private void Interfaz2_Click(object sender, EventArgs e)
        {
            Formtratam formtratam = new Formtratam();
            formtratam.Show();
            this.Hide();
        }

        private void Interfaz4_Click(object sender, EventArgs e)
        {
            Form7 chepe7 = new Form7();
            chepe7.Show();
            this.Hide();
        }

        private void Imagenform2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
