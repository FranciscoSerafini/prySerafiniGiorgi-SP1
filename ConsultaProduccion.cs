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
    public partial class frmConsultaProduccion : Form
    {
        public frmConsultaProduccion()
        {
            InitializeComponent();
        }

        private void cmdListarProduciones_Click(object sender, EventArgs e)
        {
            StreamReader srConsultaProduciones = new StreamReader("./producciones.txt");
            while (!srConsultaProduciones.EndOfStream)
            {
                string datosProducciones = srConsultaProduciones.ReadLine();
                string [] vecDatosProducciones = datosProducciones.Split(',');
                grillaProduccion.Rows.Add(vecDatosProducciones[0],vecDatosProducciones[1],vecDatosProducciones[2],vecDatosProducciones[3]);

            }

        }
    }
}
