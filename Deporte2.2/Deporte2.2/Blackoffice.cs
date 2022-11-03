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
    public partial class Blackoffice : Form
    {
        string TipoObjeto = "";
        int Cod = 0;
        MySqlConnection connection = Server.getConexion();


        public Blackoffice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlTipoEvento.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = true;
            TipoObjeto = "Equipos";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = true;
            TipoObjeto = "Deportistas";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = true;
            TipoObjeto = "SubDeporte";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = true;
            TipoObjeto = "Nacional";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = true;
            TipoObjeto = "Regional";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = true;
            TipoObjeto = "Global";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = true;
            pnlOpciones.Visible = false;
            pnlTipoEvento.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = true;
            pnlOpciones.Visible = false;
            pnlTipoEvento.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dgvSelect.Visible = true;
            String query = "Select * from @TipoObjeto";
            MySqlCommand comando = new MySqlCommand(query, connection);
            comando.Parameters.AddWithValue("@TipoObjeto", TipoObjeto);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgvSelect.DataSource = tabla;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = false;
            pnlTipoEvento.Visible = false;
            pnlSelect.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = false;
            pnlTipoEvento.Visible = true;
            pnlSelect.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Generar Tipo = new Generar();
            Generar.SelectEvento Evento = new Generar.SelectEvento();
            int Id = Convert.ToInt32(this.dgvSelect.SelectedRows[0].Cells[0].Value);
            Cod = Convert.ToInt32(tbxSelect.Text);
            {
                if (TipoObjeto == "SubDeportes")
                {
                    dgvSelect.Visible = true;
                    String query = "Select * from @TipoObjeto WHERE IdSub like @Id";
                    MySqlCommand comando = new MySqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@TipoObjeto", TipoObjeto);
                    comando.Parameters.AddWithValue("@Id", Cod);
                    MySqlDataAdapter data = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvSelect.DataSource = tabla;
                }

                if (TipoObjeto == "Nacional")
                {
                    dgvSelect.Visible = true;
                    String query = "Select * from @TipoObjeto WHERE IdEvento like @Id";
                    MySqlCommand comando = new MySqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@TipoObjeto", TipoObjeto);
                    comando.Parameters.AddWithValue("@Id", Cod);
                    MySqlDataAdapter data = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvSelect.DataSource = tabla;
                }

                if (TipoObjeto == "Regional")
                {
                    dgvSelect.Visible = true;
                    String query = "Select * from @TipoObjeto WHERE IdEvento like @Id";
                    MySqlCommand comando = new MySqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@TipoObjeto", TipoObjeto);
                    comando.Parameters.AddWithValue("@Id", Cod);
                    MySqlDataAdapter data = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvSelect.DataSource = tabla;
                }

                if (TipoObjeto == "Global")
                {
                    dgvSelect.Visible = true;
                    String query = "Select * from @TipoObjeto WHERE IdEvento like @Id";
                    MySqlCommand comando = new MySqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@TipoObjeto", TipoObjeto);
                    comando.Parameters.AddWithValue("@Id", Cod);
                    MySqlDataAdapter data = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvSelect.DataSource = tabla;
                }

                if (TipoObjeto == "Equipo")
                {
                    dgvSelect.Visible = true;
                    String query = "Select * from @TipoObjeto WHERE IdEq like @Id";
                    MySqlCommand comando = new MySqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@TipoObjeto", TipoObjeto);
                    comando.Parameters.AddWithValue("@Id", Cod);
                    MySqlDataAdapter data = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvSelect.DataSource = tabla;
                }

                if (TipoObjeto == "Deportista")
                {
                    dgvSelect.Visible = true;
                    String query = "Select * from @TipoObjeto WHERE IdDeportista like @Id";
                    MySqlCommand comando = new MySqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@TipoObjeto", TipoObjeto);
                    comando.Parameters.AddWithValue("@Id", Cod);
                    MySqlDataAdapter data = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvSelect.DataSource = tabla;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<b>" + "COMING SOON" + "</b>");
        }

        private void Blackoffice_Load(object sender, EventArgs e)
        {
            MessageBox.Show("<b>" + "COMING SOON" + "</b>");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = true;
            pnlOpciones.Visible = false;
            pnlTipoEvento.Visible = false;
            pnlSelect.Visible = false;
            pnlInsert.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;
            pnlOpciones.Visible = false;
            pnlTipoEvento.Visible = false;
            pnlSelect.Visible = false;
            pnlInsert.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Generar Tipo = new Generar();
            Generar.RegEvento Evento = new Generar.RegEvento();
            {
                if (TipoObjeto == "SubDeportes")
                {
                    Generar.Deporte Insert = new Generar.Deporte(Convert.ToInt32(tbx1.Text), tbx2.Text,tbx3.Text, tbx4.Text, tbx5.Text);
                    Boolean existe = Tipo.ExisteDeporte(Insert);
                    if (existe == false){ 
                        Tipo.RegDep(Insert);
                    }else MessageBox.Show("Perfil ya existente");

                }

                    if (TipoObjeto == "Nacional")
                {
                    Generar.Evento.Nacional Insert = new Generar.Evento.Nacional(Convert.ToInt32(tbx1.Text), tbx2.Text, tbx3.Text);
                    Evento.RegNacional(Insert);
                }

                if (TipoObjeto == "Regional")
                {
                    Generar.Evento.Regional Insert = new Generar.Evento.Regional(Convert.ToInt32(tbx1.Text), tbx2.Text, tbx3.Text);
                    Evento.RegRegional(Insert);
                }

                if (TipoObjeto == "Global")
                {
                    Generar.Evento.Global Insert = new Generar.Evento.Global(Convert.ToInt32(tbx1.Text), tbx2.Text);
                    Evento.RegGlobal(Insert);
                }

                if (TipoObjeto == "Equipo")
                {
                    Generar.Equipo Insert = new Generar.Equipo(Convert.ToInt32(tbx1.Text), tbx2.Text, tbx3.Text, tbx4.Text, Convert.ToInt32(tbx5.Text));
                    Tipo.RegEquipo(Insert);
                }

                if (TipoObjeto == "Deportista")
                {
                    Generar.Deportista Insert = new Generar.Deportista(Convert.ToInt32(tbx1.Text), tbx2.Text,tbx6.Text, Convert.ToDouble(tbx3.Text), Convert.ToDouble(tbx4.Text), Convert.ToInt32(tbx5.Text));
                    Tipo.RegDeportista(Insert);
                }
            }
        }
    }
}
