using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerafiniGiorgi_SP1
{
    public partial class frmAgricultura : Form
    {
        public frmAgricultura()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmLocalidades frmLocalidades = new frmLocalidades();
            frmLocalidades.ShowDialog();
           
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos frmCultivos = new frmCultivos();
            frmCultivos.ShowDialog();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmProduccion = new frmProduccion();
            frmProduccion.ShowDialog();
        }
        public struct agricultura
        {
           
        }
        

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta frmConsulta = new frmConsulta();
            frmConsulta.ShowDialog();
        }
    }
}
