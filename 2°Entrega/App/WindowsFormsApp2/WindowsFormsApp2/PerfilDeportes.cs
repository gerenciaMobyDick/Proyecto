using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Deporte : Form
    {
        public Deporte()
        {
            InitializeComponent();
        }

        public Generar.Deporte Ganso(Generar.Deporte Deporte)
        {
            InitializeComponent();
            lblSunNom.Text = Deporte.DepSub;
            lblDepNom.Text = Deporte.DepNom;
            lblTypePoint.Text = Deporte.TypePoint;
            lblCountEquipo.Text = "17";
            lblCountDeportista.Text = "138";
            return Deporte;
        }

        private void Deporte_Load(object sender, EventArgs e)
        {
            
        }
    }
}
