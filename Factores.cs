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
    public partial class Factores : Form
    {
        public Factores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Factor1_Click(object sender, EventArgs e)
        {
            lbl_infoRiesgo.Text = "La falta de uso correcto del condón es uno de los principales factores de riesgo, ya que permite la transmisión directa de bacterias y virus durante las relaciones sexuales. Situaciones como presión de la pareja o beneficios económicos aumentan las prácticas sin protección.";
        }

        private void lbl_Factor2_Click(object sender, EventArgs e)
        {
            lbl_infoRiesgo.Text = "Mantener múltiples parejas sexuales incrementa la exposición a infecciones y dificulta el control del contagio. A mayor número de parejas, mayor es el riesgo de adquirir o transmitir una ITS, especialmente sin medidas de protección constantes.";

        }

        private void lbl_Factor3_Click(object sender, EventArgs e)
        {
            lbl_infoRiesgo.Text = "El consumo de alcohol y drogas reduce la capacidad de tomar decisiones seguras, favoreciendo conductas sexuales de riesgo como el no uso del preservativo o el aumento de parejas sexuales.";

        }

        private void lbl_Factor4_Click(object sender, EventArgs e)
        {
            lbl_infoRiesgo.Text = "Haber tenido una ITS anteriormente aumenta la probabilidad de nuevas infecciones, debido a daños en las mucosas y a la posible continuidad de comportamientos sexuales de riesgo.";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 dos = new Form2();
            dos.Show();
            this.Close();
        }
    }
}
