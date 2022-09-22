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
            bool bandera = false;
            if (File.Exists("./localidades.txt"))
            {
                StreamReader lectorLocalides = new StreamReader("./localidades.txt");
                while (!lectorLocalides.EndOfStream) //leemos el archivo
                {
                    string auxlocalides = lectorLocalides.ReadLine();
                    string [] vecLocalidades = auxlocalides.Split(',');
                    if (mskCodigoLocalidad.Text == vecLocalidades[0]) //verifiacion que el codigo no se repita
                    {
                        MessageBox.Show("El codigo ingresado se repite, intente nuevamente");
                        mskCodigoLocalidad.Text = "";
                        mskCodigoLocalidad.Focus();
                        bandera = true;
                    }
                }
                lectorLocalides.Close();
            }
            if (bandera == false)
            {
                StreamWriter cargaClientes = new StreamWriter("./localidades.txt",true); //el true crea el archivo si no esta creado
                cargaClientes.WriteLine(mskCodigoLocalidad.Text + "," + txtLocalidad.Text);
                MessageBox.Show("Codigo ingresado con exito");
                txtLocalidad.Text = "";
                mskCodigoLocalidad.Text = "";
                txtLocalidad.Focus();
                cargaClientes.Close();
            }
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
