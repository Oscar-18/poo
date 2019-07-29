using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

/*	Elaborar un programa educativo que sirva para conocer: Símbolos nacionales
 * de los países Centroamericanos: Bandera, Flor Nacional, Pájaro Nacional,
 * Himno Nacional, Monedas, Billetes, a lo largo de su historia con sus períodos,
 * Próceres de su Independencia, Población Actual, Departamentos y Municipios.
 * Comidas Típicas, Lugares Turísticos.
*/
namespace PaísesCentroAmericanos
{
    public partial class Form1 : Form
    {
        /**/
        public Form1()
        {
            InitializeComponent();
            //Bloquea el textbox
            Introduccion.Enabled = false;
            //Código de la fecha en pantalla
            labelFecha.Text = DateTime.Now.ToString("G");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Botón de iniciar el programa
        private void IniciarPrograma_Click(object sender, EventArgs e)
        {
            //Inicializa el menú de países
            
            MainWindow CambioF = new MainWindow();
            CambioF.Show();
                    }
        //Salir del programa
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            //Lleva a los creditos del programa
            Creditos CambioF = new Creditos();
            CambioF.Show();
        }
    }
}
