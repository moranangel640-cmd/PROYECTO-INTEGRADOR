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
            Form1 chepe2 = new Form1();
            chepe2.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void Bienve_Click(object sender, EventArgs e)
        {

        }
    }
}
