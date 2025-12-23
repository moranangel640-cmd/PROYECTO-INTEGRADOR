using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INTEGRADOR
{
    public partial class Form7 : Form
    {
        
        /*
        private Timer timer;
        private Control pane;
        private Point inicio;
        private Point fin;
        private int mov = 0;
        private int movTiempo = 50;*/
        public Form7()
        {
            InitializeComponent();
            // setupTimer();
        }
        /*
        private void setupTimer()
        {
            timer = new Timer();
            timer.Interval = 20; 
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine($"Paso actual: {movTiempo}");
            if (mov >= movTiempo)
            {
                timer.Stop();
                pane.Location = fin;
                return;
            }

            float progreso = (float)mov / movTiempo;

            int newX = inicio.X + (int)((fin.X - inicio.X) * progreso);
            int newY = inicio.Y + (int)((fin.Y - inicio.Y) * progreso);

            pane.Location = new Point(newX, newY);

            movTiempo++;

        }*/
        private void pBmouseEnter(object sender, EventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
           // pb1.BorderStyle = BorderStyle.Fixed3D;
            pb1.Size = new Size(pb1.Width + 6, pb1.Height + 6);
            pb1.Location = new Point(pb1.Location.X - 2, pb1.Location.Y - 2);
        }
        private void pBmouseLeave(object sender, EventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
           // pb1.BorderStyle = BorderStyle.None;
            pb1.Size = new Size(pb1.Width - 6, pb1.Height - 6);
            pb1.Location = new Point(pb1.Location.X + 2, pb1.Location.Y + 2);
        }

        private void amaz_Click(object sender, EventArgs e)
        {
            /*
            pane = button1;
            inicio = button1.Location;
            fin = new Point(inicio.X + 300, inicio.Y);
            mov = 0;
            timer.Start();*/
            panelAmaz.Visible = true;
            if (panelSierra.Visible == true || panelCosta.Visible == true)
            {
                panelSierra.Visible = false;
                panelCosta.Visible = false;
            }
        }

        private void sierra_Click(object sender, EventArgs e)
        {
            panelSierra.Visible = true;
            if (panelAmaz.Visible == true || panelCosta.Visible == true)
            {
                panelAmaz.Visible = false;
                panelCosta.Visible = false;
            }
        }

        private void costa_Click(object sender, EventArgs e)
        {
            panelCosta.Visible = true;
            if (panelAmaz.Visible == true || panelSierra.Visible == true)
            {
                panelAmaz.Visible = false;
                panelSierra.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 chape = new Form2();
            chape.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
