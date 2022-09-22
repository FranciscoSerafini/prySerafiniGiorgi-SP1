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
            if (File.Exists("./cultivos.txt"))
            {
                StreamReader lectorCultivos = new StreamReader("./cultivos.txt");
                while (!lectorCultivos.EndOfStream) //recorrer el archivo
                {
                    string AuxCultivos = lectorCultivos.ReadLine();
                    string [] VecCultivos = AuxCultivos.Split(',');
                    if (mskCodigoCultivo.Text == VecCultivos[0]) //comparacion de codigos para que no se repitan
                    {
                        MessageBox.Show("Tu codigo se repite, intente con otro");
                        mskCodigoCultivo.Text = "";
                        mskCodigoCultivo.Focus();
                        bandera = true;
                    }
                }
                lectorCultivos.Close();
            }
            if (bandera == false)
            {
                StreamWriter cargaCultivos = new StreamWriter("./cultivos.txt");
                cargaCultivos.WriteLine(mskCodigoCultivo.Text + "," + txtCultivos.Text);
                MessageBox.Show("Tu codigo fue cargado con exito");
                cargaCultivos.Close();
                txtCultivos.Text = "";
                mskCodigoCultivo.Text = "";

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
                cmdCargarCultivo.Enabled = true;
            }
            else
            {
                cmdCargarCultivo.Enabled =false;
            }
        }
    }
}
