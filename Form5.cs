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
    public partial class Formtratam : Form
    {
        public Formtratam()
        {
            InitializeComponent();
        }

        private void Regresointer2_Click(object sender, EventArgs e)
        {
            Form2 form22 = new Form2();
            form22.Show();
            this.Hide();
        }

        private void Vermas1_Click(object sender, EventArgs e)
        {
            info1 info1 = new info1();
            info1.Show();
        }
    }
}
