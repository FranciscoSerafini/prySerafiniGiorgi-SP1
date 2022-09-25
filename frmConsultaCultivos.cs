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
    public partial class frmConsultaCultivos : Form
    {
        public frmConsultaCultivos()
        {
            InitializeComponent();
        }

        private void cmdListarCultivos_Click(object sender, EventArgs e)
        {
            StreamReader srConsultaCultivos = new StreamReader("./cultivos.txt");
            while (!srConsultaCultivos.EndOfStream)
            {
                string cultivosDatos = srConsultaCultivos.ReadLine();
                string [] vecCultivosDatos = cultivosDatos.Split(',');
                grillaCultivos.Rows.Add(vecCultivosDatos[0], vecCultivosDatos[1]);
            }
        }

        private void cmdLimpiarCultivos_Click(object sender, EventArgs e)
        {
            grillaCultivos.Rows.Clear();
        }
    }
}
