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

        private void Vermas2_Click(object sender, EventArgs e)
        {
            info2 info2 = new info2();
            info2.Show();
        }

        private void Vermas3_Click(object sender, EventArgs e)
        {
            info3 info3 = new info3();
            info3.Show();
        }

        private void Vermas4_Click(object sender, EventArgs e)
        {
            info4 info4 = new info4();
            info4.Show();
        }

        private void Vermas5_Click(object sender, EventArgs e)
        {
            info5 info5 = new info5();
            info5.Show();
        }
    }
}
