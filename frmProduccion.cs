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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            //creamos los lectores para recorrer los archivos
            StreamReader lectorLocalidad = new StreamReader("./localidades.txt");
            StreamReader lectorCultivo = new StreamReader("./cultivos.txt");

            //recorremos el archivo para luego cargarlo
            while (!lectorLocalidad.EndOfStream)
            {
                string informacionLocalidad = lectorLocalidad.ReadLine();

                lstLocalidad.Items.Add(informacionLocalidad.Substring(5));

            }
            lectorLocalidad.Close();

            while (!lectorCultivo.EndOfStream)
            {
                string informacionCultivos = lectorCultivo.ReadLine();
                lstCultivos.Items.Add(informacionCultivos.Substring(5));

            }
            lectorCultivo.Close();
        }

        private void cmdCargarLoc_Click(object sender, EventArgs e)
        {
            StreamWriter producciones = new StreamWriter("./producciones.txt", true);
            producciones.WriteLine(dtpFechaProdu.Text + "," +lstLocalidad.Text + " " +  lstCultivos.Text +  txtToneladas.Text );
           
            MessageBox.Show("Usted cargo los datos correctamente");
            //ceramos el archivo
            producciones.Close();
            //vaciamos las cajas de texto 
            txtToneladas.Text = "";
            txtToneladas.Focus();
            lstLocalidad.Text = "";
            lstCultivos.Text = "";
            dtpFechaProdu.Text = "";

            
            

        }

        private void lstLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLocalidad.SelectedIndex != -1)
            {
                lstCultivos.Enabled = true;
            }
            else
            {
                lstCultivos.Enabled =false;
            }
        }

        private void lstCultivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCultivos.SelectedIndex != -1)
            {
                txtToneladas.Enabled = true;
            }
            else
            {
                txtToneladas.Enabled = false;
            }
        }

        private void txtToneladas_TextChanged(object sender, EventArgs e)
        {
            if (txtToneladas.Text != "")
            {
                cmdCargarProduccion.Enabled = true;
            }
            else
            {
                cmdCargarProduccion.Enabled =false;
            }
        }
    }
}
