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

namespace pryMatiasSP1
{
    public partial class frmProducion : Form
    {
        public frmProducion()
        {
            InitializeComponent();
            StreamReader swLocalidad = new StreamReader("./FormularioLocalidad.txt");
            StreamReader swCultivo = new StreamReader("./FormularioCultivo.txt");
            char separador = Convert.ToChar(" ");

            while (!swLocalidad.EndOfStream)
            {
                string[] informacion = swLocalidad.ReadLine().Split(separador);
                cbLocalidad.Items.Add(informacion[0]);
            }
            while (!swCultivo.EndOfStream)
            {
                string[] informacion = swCultivo.ReadLine().Split(separador);
                cbCultivo.Items.Add(informacion[0]);
            }
            swCultivo.Close();
            swLocalidad.Close();
        }

        private void frmProducion_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter swProduccion = new StreamWriter("./Produccion.txt", true);
            swProduccion.WriteLine(mtbFecha.Text + " " + cbLocalidad.Text + " " + cbCultivo.Text + " " + txtCantidad.Text);
            swProduccion.Close();
        }
    }
}
