using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_INTEGRADOR
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();
            formulario2.Show();
            this.Hide();
        }

        private void Titulo2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Comboboxenfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = Comboboxenfer.SelectedItem.ToString();
            switch (seleccion)
            {
                case "🦠 VIH/SIDA":
                    Titulo2.Text = "\U0001f9a0 VIH/SIDA";
                    Informacionrichtext.Text =
                    "Descripcion: \n \n" +
                    "Como dije es muy contagioso pq a si \n " +
                    "por que a si lo quiso nuestro señor jesucristo";
                    break;
                case "🦠 GONORREA":
                    Titulo2.Text = "\U0001f9a0 GONORREA";
                    Informacionrichtext.Text =
                    "Descripcion: \n \n" +
                    "Como dije es muy contagioso pq a si \n " +
                    "por que a si lo quiso nuestro señor jesucristo \n" +
                    "ademas de que es una enfermedad bacteriana \n" +
                    "Sintomas: \n \n" +
                    "texto de sintomas\n" +
                    "Complicaciones:";
                    break;
                case "🦠 SÍFILIS":
                    Titulo2.Text = "\U0001f9a0 SÍFILIS";
                    Informacionrichtext.Text =
                    "Descripcion: \n \n" +
                    "Como dije es muy contagioso pq a si \n " +
                    "por que a si lo quiso nuestro señor jesucristo \n" +
                    "ademas de que es una enfermedad bacteriana \n" +
                    "y puede causar graves daños al organismo";
                    break;
                case "🦠 HERPES":
                    Titulo2.Text = "\U0001f9a0 HERPES";
                    Informacionrichtext.Text =
                    "Descripcion: \n \n" +
                    "Como dije es muy contagioso pq a si \n " +
                    "por que a si lo quiso nuestro señor jesucristo \n" +
                    "ademas de que es una enfermedad bacteriana \n" +
                    "y puede causar graves daños al organismo" +
                    "chepe";
                    break;
                case "🦠 VPH":
                    Titulo2.Text = "\U0001f9a0 HERPES";
                    Informacionrichtext.Text =
                    "Descripcion: \n \n" +
                    "Como dije es muy contagioso pq a si \n " +
                    "por que a si lo quiso nuestro señor jesucristo \n" +
                    "ademas de que es una enfermedad bacteriana \n" +
                    "y puede causar graves daños al organismo" +
                    "chepe";
                    break;
                default:
                    break;
            }
        }
    }
}
