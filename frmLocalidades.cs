using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySerafiniGiorgi_SP1
{
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void cmdCrearCultivo_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdCargarLoc_Click(object sender, EventArgs e)
        {
            StreamWriter localidades = new StreamWriter("./localidades.txt", true);
            localidades.WriteLine(mskCodigoLocalidad.Text + " " + txtLocalidad.Text);

            MessageBox.Show("Usted cargo la localidad y el codigo");

            localidades.Close();

            txtLocalidad.Text = "";

            mskCodigoLocalidad.Text = ""; 

            
        }

        private void frmLocalidades_Load(object sender, EventArgs e)
        {
           
        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (txtLocalidad.Text != "")
            {
                mskCodigoLocalidad.Enabled = true;

            }
            else
            {
                mskCodigoLocalidad.Enabled = false;
            }
        }

        private void mskCodigoLocalidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskCodigoLocalidad.Text != "")
            {
                cmdCargarLoc.Enabled = true;
            }
            else
            {
                cmdCargarLoc.Enabled = false;
            }

        }
    }
}
