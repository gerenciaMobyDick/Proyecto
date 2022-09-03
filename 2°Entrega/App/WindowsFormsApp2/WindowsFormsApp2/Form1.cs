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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        string tipoDGV;

        MySqlConnection connection = Server.getConexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataGridView.Visible = false;
            String query = "Select * from SubDeporte";
            MySqlCommand comando = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataGridView.DataSource = tabla;
            tipoDGV = "SubDeporte";
        }

        
        






        /*____________________________________________________________*/

        private void smiDeportes_Click(object sender, EventArgs e)
        {
            DataGridView.Visible = true;
            String query = "Select * from SubDeporte";
            MySqlCommand comando = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataGridView.DataSource = tabla;
            tipoDGV = "SubDeporte";
        }

        private void smiNacional_Click(object sender, EventArgs e)
        {
            DataGridView.Visible = true;
            String query = "Select * from Nacional";
            MySqlCommand comando = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataGridView.DataSource = tabla;
            tipoDGV = "Nacional";
        }

        private void smiRegional_Click(object sender, EventArgs e)
        {
            DataGridView.Visible = true;
            String query = "Select * from Regional";
            MySqlCommand comando = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataGridView.DataSource = tabla;
            tipoDGV = "Regional";
        }

        private void smiGlobal_Click(object sender, EventArgs e)
        {
            DataGridView.Visible = true;
            String query = "Select * from Global";
            MySqlCommand comando = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataGridView.DataSource = tabla;
            tipoDGV = "Global";
        }

        private void smiEvento_Click(object sender, EventArgs e)
        {
            DataGridView.Visible = true;
            String query = "Select * from Evento";
            MySqlCommand comando = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataGridView.DataSource = tabla;
            tipoDGV = "Evento";
        }

        private void smiEquipos_Click(object sender, EventArgs e)
        {
            DataGridView.Visible = true;
            String query = "Select * from Equipos";
            MySqlCommand comando = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataGridView.DataSource = tabla;
            tipoDGV = "Equipos";
        }

        private void smiDeportista_Click(object sender, EventArgs e)
        {
            DataGridView.Visible = true;
            String query = "Select * from Deportistas";
            MySqlCommand comando = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DataGridView.DataSource = tabla;
            tipoDGV = "Deportista";
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Generar Tipo = new Generar();
                Generar.SelectEvento Evento = new Generar.SelectEvento();
                int Id = Convert.ToInt32(this.DataGridView.SelectedRows[0].Cells[0].Value);
                
                {
                if (tipoDGV == "SubDeportes")
                {
                        PerfilDeporte Perfil = new PerfilDeporte(Id);
                }

                if (tipoDGV == "Nacional")
                {
                        PerfilEvento Perfil = new PerfilEvento(Id, tipoDGV); 
                }

                if (tipoDGV == "Regional")
                {
                        PerfilEvento Perfil = new PerfilEvento(Id, tipoDGV);
                    }

                if (tipoDGV == "Global")
                {
                        PerfilEvento Perfil = new PerfilEvento(Id, tipoDGV);
                    }

                if (tipoDGV == "Equipos")
                {
                    Generar.Equipo Equipo = null;
                    Equipo = Tipo.SelectEquipo(Id);

                    MessageBox.Show("<b>" + "COMING SOON" + "</b>");
                    }

                if (tipoDGV == "Deportista")
                {
                    Generar.Deportista Deportista = null;
                    Deportista = Tipo.SelectDeportista(Id);

                    MessageBox.Show("<b>" + "COMING SOON" + "</b>");
                }
                }/*Select Item*/


            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
