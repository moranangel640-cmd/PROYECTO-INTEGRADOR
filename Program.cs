using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INTEGRADOR
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public static class directorios
    {
        private const string datos = "Datos";
        private const string configs = "Configuraciones";
        private const string logs = "Logs";
        public static string datosBase { get; private set; }
        public static string subDatos { get; private set; }
        public static string datosConfig { get; private set; }
        public static string logsError { get; private set; }
        static directorios()
        {
            IniciaDirectorio();
        }
        private static void IniciaDirectorio()
        {
            try
            {
                //Directorio del .txt
                datosBase = Application.StartupPath;
                //crea estructura de subcarpetas con los nombres
                subDatos = Path.Combine(datosBase, datos);
                datosConfig = Path.Combine(subDatos, configs);
                logsError = Path.Combine(datosConfig, logs);

                //crea las carpetas
                CrearCarpetas();
                //crea config inicial si no la hay
                CrearConfig();
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Error creando las carpetas {ex.Message}");
            }
        }
        private static void CrearCarpetas()
        {
            //crea carpetas necesarias
            string[] carpetas = {subDatos, datosConfig};
            foreach (string carpeta in carpetas)
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
            }
        }
        private static void CrearConfig()
        {
            string archConfig = Path.Combine(datosConfig, "config.ini");

            if (!File.Exists(archConfig))
            {
                string contenido = $"[Configuracion]\n" +
                    $"FechaCreacion={DateTime.Now:yyyy-MM-dd HH:mm:ss}\n" +
                    $"Version=1.0\n" +
                    $"ContadorInicial=0\n" +
                    $"DirectorioBase={datosBase}\n";
                File.WriteAllText(archConfig, contenido );
            }
        }
        //crea carpetas especificas si no las hay
        public static string hallarRuta(string archivo, string subCarpeta = "")
        {
            string carpeta = string.IsNullOrEmpty(subCarpeta)
                ? datosBase
                : Path.Combine(datosBase, subCarpeta);
            if(!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
            return Path.Combine(carpeta, archivo);
        }
    }
}
