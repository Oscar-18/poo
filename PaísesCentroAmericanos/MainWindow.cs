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

namespace PaísesCentroAmericanos
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            txtPaises.Enabled = false;
            
        }

        private void BtnTitulo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnGuatemala_Click(object sender, EventArgs e)
        {
            Guatemala CambioF = new Guatemala();
            CambioF.Show();
            btnHonduras.Enabled = false;
            btnGuatemala.Enabled = false;
            btnBelice.Enabled = false; 
        }

        private void BtnBelice_Click(object sender, EventArgs e)
        {
            Belice CambioF = new Belice();
            CambioF.Show();
        }

        private void BtnHonduras_Click(object sender, EventArgs e)
        {
            Honduras CambioF = new Honduras();
            CambioF.Show();
        }
    }
}
