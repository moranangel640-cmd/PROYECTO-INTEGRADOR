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
                    "DESCRIPCION \n " +
                    "Virus de inmunodeficiencia humana (VIH), Retrovirus que infecta \n" +
                    "celulas CD4+, principalmente linfocitos T causando inmunodeficiencia. \n" +
                    "progresiva. SIDA es la fase mas tardia y avanzada \n \n" +
                    "SINTOMAS POR FASES: \n " +
                    "Infeccion aguda: Sindrome similar a mononucleosis con fiebre, exantema \n" +
                    "(erupcion) y adenomegalias múltiples (ganglios inflamados) \n " +
                    "Fase latente/clínica temprana: Puede ser asintomática \n " +
                    "Fase SIDA: Se define por CD4 <200 células/mm³ y presencia de \n " +
                    "infecciones oportunistas o neoplasias \n \n " +
                    "COMPLICACIONES: \n " +
                    "Infecciones oportunistas: \n" +
                    "Tuberculosis (pulmonar/extrapulmonar) \n" +
                    "Candidiasis (tubo digestivo)\n" +
                    "Criptococosis meningea \n" +
                    "Histoplasmosis \n" +
                    "Neumonía por Pneumocystis carinii \n" +
                    "Toxoplasmosis cerebral \n" +
                    "Infecciones por bacterias encapsuladas (H. influenzae, S. pneumoniae)";

                    break;
                case "🦠 GONORREA":
                    Titulo2.Text = "\U0001f9a0 GONORREA";
                    Informacionrichtext.Text =
                    "Descripcion: \n " +
                    "Infección bacteriana por Neisseria gonorrhoeae (diplococo gramnegativo).\n" +
                    "Afecta mucosas: uretra, cérvix, conjuntiva. Puede ser asintomática o causar \n" +
                    "inflamación severa. \n \n " +
                    "SINTOMAS: \n  " +
                    "Hombres: Uretritis aguda con disuria y exudado uretral purulento (75% casos) \n" +
                    "Mujeres: Exudado cervicovaginal, disuria, dolor abdominal/pélvico, \n " +
                    "sangrado anormal \n" +
                    "Asintomáticos: Hasta 4% hombres, mayoría mujeres inicialmente \n" +
                    "Rectal/Orofaringe: Proctitis con secreción, dolor; orofaringe generalmente \n " +
                    "asintomática \n \n " +
                    "COMPLICACIONES \n " +
                    "Hombres: Epididimitis, prostatitis, abscesos periuretrales, estenosis uretral \n" +
                    "Mujeres: Enfermedad Pélvica Inflamatoria (EPI) 10-20%, salpingitis, \n " +
                    "infertilidad 20-40%, embarazo ectópico \n " +
                    "Sistémicas: Infección Gonocócica Diseminada (0.5-3%): fiebre, \n " +
                    "lesiones cutáneas, artritis, tenosinovitis, endocarditis, meningitis \n " +
                    "Oftálmicas: Oftalmía neonatorum (ceguera en recién nacidos), conjuntivitis \n " +
                    "en adultos \n " +
                    "Embarazo: Aborto, parto pretérmino, infección intraamniótica";

                    break;
                case "🦠 SÍFILIS":
                    Titulo2.Text = "\U0001f9a0 SÍFILIS";
                    Informacionrichtext.Text =
                    "Descripcion: \n " +
                    "Infección bacteriana sistémica causada por Treponema pallidum, espiroqueta \n" +
                    "que infecta exclusivamente humanos. Enfermedad crónica con etapas progresivas.\n \n " +
                    "SINTOMAS POR ETAPA \n " +
                    "Primaria (3-90 días): Chancro (úlcera indolora) en sitio de inoculación \n " +
                    "Secundaria (6 semanas-6 meses): Erupción cutánea (incluye palmas/plantas), lesiones \n " +
                    "mucosas, alopecia, adenopatías \n " +
                    "Latente: Asintomática (temprana <4 años, tardía >4 años) \n " +
                    "Terciaria (años después): Gomas (lesiones granulomatosas), neurosífilis, cardiovascular \n  \n " +
                    "COMPLICACIONES \n" +
                    "Cardiovascular: Aortitis, aneurismas \n " +
                    "Neurológica: Neurosífilis (tabes dorsal, parálisis general progresiva) \n " +
                    "Congénita: Transmisión fetal → muerte fetal, malformaciones, sífilis congénita \n " +
                    "Oculares: Uveítis, queratitis \n " +
                    "Óseas: Osteítis, periostitis ";

                    break;
                case "🦠 HERPES":
                    Titulo2.Text = "\U0001f9a0 HERPES";
                    Informacionrichtext.Text =
                    "Descripcion: \n " +
                    "Infección viral crónica y recurrente causada por Virus del Herpes Simple (HSV). \n " +
                    "Principalmente HSV-2 (genital) y HSV-1 (oral-genital por sexo oral). Infección de \n " +
                    "por vida con periodos de latencia y reactivación. \n \n " +
                    "SINTOMAS: \n " +
                    "Primoinfección (2-20 días post-contagio): Vesículas dolorosas agrupadas en racimos, \n" +
                    "úlceras superficiales, adenopatía inguinal, fiebre, malestar general \n " +
                    "Recurrencias: Lesiones menos severas, duración 7 días promedio, sin síntomas generales \n \n " +
                    "LOCALIZACION \n \n " +
                    "Hombres: Glande, pene, escroto, perineo, ano \n " +
                    "Mujeres: Vulva, vagina, cérvix (80% casos), perineo, área anorrectal \n " +
                    "Características lesiones: Vesículas → úlceras → costras, cura sin cicatriz \n \n " +
                    "COMPLICACIONES \n " +
                    "Neonatal: Infección neonatal grave (mortalidad 60% sin tratamiento) \n " +
                    "Embarazo: Aborto, parto pretérmino, restricción crecimiento intrauterino \n " +
                    "Sistémicas: Meningitis herpética, hepatitis, infección diseminada (inmunodeprimidos) \n " +
                    "Locales: Retención urinaria, proctitis, cervicitis necrotizante \n " +
                    "Psicosocial: Angustia, depresión, estigma, afectación relaciones sexuales";

                    break;
                case "🦠 VPH":
                    Titulo2.Text = "\U0001f9a0 HERPES";
                    Informacionrichtext.Text =
                    "Descripcion: \n " +
                    "Virus DNA más común entre ITS. Más de 200 tipos, 40 afectan área genital. Clasificación \n" +
                    "por riesgo oncogénico: alto riesgo (cáncer) y bajo riesgo (verrugas).\n \n" +
                    "SINTOMAS: \n " +
                    "Mayoría: Asintomático (5-40% mujeres en edad productiva) \n" +
                    "Verrugas genitales: Lesiones exofíticas, papilomatosas, en vulva, pene, periné, ano \n" +
                    "Subclínico: Detectado por citología (cambios coilocíticos) \n " +
                    "Cáncer avanzado: Sangrado postcoital, dolor pélvico, secreción fétida \n \n " +
                    "COMPLICACIONES \n " +
                    "Cáncer cervicouterino: Principal por VPH-16 (50%) y VPH-18 (12%)\n" +
                    "Otros cánceres: Anal, pene, vaginal, vulvar, orofaríngeo \n" +
                    "Verrugas genitales recurrentes: VPH-6 y VPH-11 (90% casos) \n" +
                    "Papilomatosis respiratoria juvenil: En niños por transmisión vertical \n" +
                    "Neoplasia intraepitelial cervical (NIC): Lesiones premalignas \n " +
                    "Impacto psicosocial: Ansiedad, estigma, afectación sexual";
                    break;
                default:
                    break;
            }
        }

        private void Titulo1_Click(object sender, EventArgs e)
        {

        }
    }
}
