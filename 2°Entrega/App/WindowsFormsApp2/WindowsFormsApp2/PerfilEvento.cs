using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PerfilEvento : Form
    {
        public PerfilEvento(int Id, string tipo)
        {
            InitializeComponent();
            Generar Tipo = new Generar();
            Generar.SelectEvento Evento = new Generar.SelectEvento();
            if (tipo == "Nacional")
            {
                Generar.Evento.Nacional Nacional = null;
                Nacional = Evento.Nacional(Id);

                MySqlDataAdapter Comp = Tipo.SelectComp_Equipo(Id);

                DataTable tabla = new DataTable();
                Comp.Fill(tabla);
                dgvResultados.DataSource = tabla;

                /*while (Comp.Read())
                {
                    string Nom = Comp["NomEquipo"].ToString();
                    float Point = float.Parse(Comp["Puntuacion"].ToString());
                    DateTime Time = DateTime.Parse(Comp["Fecha/hora"].ToString());
                    string Place = Comp["Ubicacion"].ToString();
                    int Id = int.Parse(Comp["IdComp"].ToString());
                }*/

                lblTitulo.Text = Nacional.NomEvento;
                lblDatos.Text = "Situado en " + Nacional.Pais;
            }

            if (tipo == "Regional")
            {
                Generar.Evento.Regional Regional = null;
                Regional = Evento.Regional(Id);

                MySqlDataAdapter Comp = Tipo.SelectComp_Equipo(Id);

                DataTable tabla = new DataTable();
                Comp.Fill(tabla);
                dgvResultados.DataSource = tabla;

                lblTitulo.Text = Regional.NomEvento;
                lblDatos.Text = "En la Region de " + Regional.Region;
            }

            if (tipo == "Global")
            {
                Generar.Evento.Global Global = null;
                Global = Evento.Global(Id);

                MySqlDataAdapter Comp = Tipo.SelectComp_Equipo(Id);

                DataTable tabla = new DataTable();
                Comp.Fill(tabla);
                dgvResultados.DataSource = tabla;

                lblTitulo.Text = Global.NomEvento;
                lblDatos.Text = "Evento Mundial";
            }
        }  

        private void Evento_Load(object sender, EventArgs e)
        {

        }
    }
}
