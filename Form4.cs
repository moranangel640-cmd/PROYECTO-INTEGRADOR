using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace PROYECTO_INTEGRADOR
{
    public partial class Form4 : Form
    {
        private int contador = 0;
        private string archivoContador;
        private string archivoLog;
        private RichTextBox txtHistorial;
        public Form4()
        {
            archivoContador = directorios.hallarRuta("contador.txt");
            archivoLog = directorios.hallarRuta("historial.log", "Log");
            InitializeComponent();
            CargarContador();
        }
        
        private void CargarContador()
        {
            try
            {
                if (File.Exists(archivoContador))
                {
                    string contenido = File.ReadAllText(archivoContador);
                    if (int.TryParse(contenido, out int valorGuardado))
                    {
                        contador = valorGuardado;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error al cargar contador: {ex.Message}");
            }
        }
        private void btnSube_Click(object sender, EventArgs e)
        {
            contador++;
            Actualizar();
            GuardarContador();
            RegistrarLog("Aumenta");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            contador--;
            Actualizar();
            GuardarContador();
            RegistrarLog("Disminuye");
        }

        private void verLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(archivoLog))
                {
                    string contenido = File.ReadAllText(archivoLog);
                    MessageBox.Show(contenido, "Historial",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hubo cambios", "Información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer logs {ex.Message}");
            }
        }
        private void Actualizar()
        {
            lblContador.Text = $"Contador: {contador}";
            lblContador.ForeColor = contador >= 0 ? Color.Blue : Color.Red;
        }
        private void GuardarContador()
        {
            try
            {
                File.WriteAllText(archivoContador, contador.ToString());
                //guardar en respaldo tambien
                string respaldo = directorios.hallarRuta(
                    $"respaldo_{DateTime.Now:yyyyMMdd}.txt",
                    "Backups");
                File.AppendAllText(respaldo,
                    $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{contador}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar {ex.Message}");
            }
        }
        private void RegistrarLog(string accion)
        {
            try
            {
                string mensaje = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {accion} -> {contador}\n";
                File.AppendAllText(archivoLog, mensaje);
            }
            catch (Exception ex)
            {
                // Error no crítico, solo mostrar en consola
                Console.WriteLine($"Error en log: {ex.Message}");
            }
        }
    }
}
