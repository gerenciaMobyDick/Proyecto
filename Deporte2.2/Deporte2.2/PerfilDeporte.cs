using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Deporte2._2
{
    public partial class PerfilDeporte : Form
    {
        public PerfilDeporte(int Id)
        {
            InitializeComponent();
            Generar Tipo = new Generar();
            Generar.Deporte Deporte = null;
            Deporte = Tipo.SelectDeporte(Id);

            lblSubNom.Text = Deporte.DepSub;
            lblDepNom.Text = Deporte.DepNom;
            lblTypePoint.Text = Deporte.TypePoint;
            lblCountEquipos.Text = "18";
            lblCountDeportistas.Text = Tipo.CountDeportista().ToString();

        }

        private void PerfilDeporte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
