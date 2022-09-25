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
    public partial class frmConsultaLocalidades : Form
    {
        public frmConsultaLocalidades()
        {
            InitializeComponent();
        }

        private void frmConsultaLocalidades_Load(object sender, EventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader srConsultaLocalidad = new StreamReader("./localidades.txt");
            while (!srConsultaLocalidad.EndOfStream)
            {
                string localidadesDatos = srConsultaLocalidad.ReadLine();
                string[] VecLocalidades = localidadesDatos.Split(',');
                grillaLocalidad.Rows.Add(VecLocalidades[0], VecLocalidades[1]);
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            grillaLocalidad.Rows.Clear();
        }

        private void grillaLocalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
