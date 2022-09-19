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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void frmCultivos_Load(object sender, EventArgs e)

        {
            
        }

        private void cmdCrearCul_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cmdCargarLoc_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            StreamReader srNumeroDeCultivos = new StreamReader("./cultivos.txt");

            while (!srNumeroDeCultivos.EndOfStream)
                
            {
                string auxCodigo = srNumeroDeCultivos.ReadLine();
                if (mskCodigoCultivo.Text == auxCodigo.Substring(0, 5))
                {
                    
                    MessageBox.Show("Este codigo ya se encuentra cargado, intente con otro");
                    bandera = true;

                }
               
            }
            srNumeroDeCultivos.Close();
            if (bandera == false)
            {
                StreamWriter cultivos = new StreamWriter("./cultivos.txt", true);
                cultivos.WriteLine(mskCodigoCultivo.Text + " " + txtCultivos.Text);
                MessageBox.Show("Cargado con exito");
                cultivos.Close();
                txtCultivos.Text = "";
                mskCodigoCultivo.Text = "";
                mskCodigoCultivo.Focus();

            }




        }

        private void txtCultivos_TextChanged(object sender, EventArgs e)
        {
            if (txtCultivos.Text !="")
            {
                mskCodigoCultivo.Enabled = true;
            }
            else
            {
                mskCodigoCultivo.Enabled=false;
            }
        }

        private void mskCodigoCultivo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskCodigoCultivo.Text != "")
            {
                cmdCargarCult.Enabled = true;
            }
            else
            {
                cmdCargarCult.Enabled =false;
            }
        }
    }
}
