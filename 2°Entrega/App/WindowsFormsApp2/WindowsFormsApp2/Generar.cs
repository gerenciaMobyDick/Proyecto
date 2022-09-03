using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class Generar
    {
        public class Deporte/*Generar deporte en Equipo (IdSub ,DepSub, DepNom, TypePoint, Cant.Part)*/
        {
            public int IdSub { get; set; }
            public string DepSub { get; set; }
            public string DepNom { get; set; }
            public string TypePoint { get; set; }
            public string CantPart { get; set; }

            public Deporte(int IdSub ,string DepSub, string DepNom, string TypePoint, string CantPart)
                {
                if (string.IsNullOrEmpty(CantPart))
                    {
                    CantPart = "1";
                }
                this.DepSub = DepSub;
                this.DepNom = DepNom;
                this.TypePoint = TypePoint;
                this.CantPart = CantPart;
                }
        }

        public class DeporteY /*Generar deporte Solitario (IdSub ,DepSub, DepNom, TypePoint)*/
        {
            public int IdSub { get; set; }
            public string DepSub { get; set; }
            public string DepNom { get; set; }
            public string TypePoint { get; set; }

            public DeporteY(int IdSub, string DepSub, string DepNom, string TypePoint)
            {
                this.DepSub = DepSub;
                this.DepSub = DepSub;
                this.DepNom = DepNom;
                this.TypePoint = TypePoint;
            }
        }

        public class Deportista /*Generar Deportista (IdDeportista, Nom, Apellido, Peso, Altura, AnosEntr)*/
        {
            public int IdDeportista { get; set; }
            public string Nom { get; set; }
            public string Apellido { get; set; }
            public float Peso { get; set; }
            public float Altura { get; set; }
            public int AnosEntr { get; set; }

            public Deportista(int IdDeportista, string Nom, string Apellido, float Peso, float Altura, int AnosEntr)
            {
                this.IdDeportista = IdDeportista;
                this.Nom = Nom;
                this.Apellido = Apellido;
                this.Peso = Peso;
                this.Altura = Altura;
                this.AnosEntr = AnosEntr;
            }


        }

        public class Equipo /*Generar Equipo (IdEq, EqNom, Pais, Region, IdSub)*/
        {
            public int IdEq { get; set; }
            public string EqNom { get; set; }
            public string Pais { get; set; }
            public string Region { get; set; }
            public int IdSub { get; set; }

            public Equipo(int IdEq, string EqNom, string Pais, string Region, int IdSub)
            {
                this.IdEq = IdEq;
                this.EqNom = EqNom;
                this.Pais = Pais;
                this.Region = Region;
                this.IdSub = IdSub;
            }
        }

        public class Competencia /*Generar Competencia (IdComp, Fecha_hora, Ubicacion, IdEvento)*/
        {
            public int IdComp { get; set; }
            public DateTime Fecha_hora { get; set; }
            public string Ubicacion { get; set; }
            public int IdEvento { get; set; }

            public Competencia(int IdComp, DateTime Fecha_hora, string Ubicacion, int IdEvento)
            {
                this.IdComp = IdComp;
                this.Fecha_hora = Fecha_hora;
                this.Ubicacion = Ubicacion;
                this.IdEvento = IdEvento;
            }
        }

        public class Evento /*Generar Evento*/
        {
            public class Nacional /*Generar Evento Nacional*/
            {
                public int IdEvento { get; set; }
                public string NomEvento { get; set; }
                public string Pais { get; set; }

                public Nacional(int IdEvento, string NomEvento, string Pais)
                {
                    this.IdEvento = IdEvento;
                    this.NomEvento = NomEvento;
                    this.Pais = Pais;
                }
            }

            public class Regional /*Generar Evento Regional*/
            {
                public int IdEvento { get; set; }
                public string NomEvento { get; set; }
                public string Region { get; set; }

                public Regional(int IdEvento, string NomEvento, string Region)
                {
                    this.IdEvento = IdEvento;
                    this.NomEvento = NomEvento;
                    this.Region = Region;
                }
            }

            public class Global /*Generar Evento Global*/
            {
                public int IdEvento { get; set; }
                public string NomEvento { get; set; }

                public Global(int IdEvento, string NomEvento)
                {
                    this.IdEvento = IdEvento;
                    this.NomEvento = NomEvento;
                }
            }
        }



        public int RegDep(Generar.Deporte Deporte)
        {
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "INSERT INTO XEquipos (IdSub ,DepSub, DepNom, TypePoint, Cant.Part) VALUES(@IdSub, @DepSub, @DepNom, @TypePoint, @CantPart)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdSub", Deporte.IdSub);
            comando.Parameters.AddWithValue("@DepSub", Deporte.DepSub);
            comando.Parameters.AddWithValue("@Depnom", Deporte.DepNom);
            comando.Parameters.AddWithValue("@TypePoint", Deporte.TypePoint);
            comando.Parameters.AddWithValue("@CantPart", Deporte.CantPart);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public int RegDepY(Generar.Deporte Deporte)
        {
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "INSERT INTO Solitario (IdSub ,DepSub, DepNom, TypePoint) VALUES(@IdSub, @DepSub, @DepNom, @TypePoint)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdSub", Deporte.IdSub);
            comando.Parameters.AddWithValue("@DepSub", Deporte.DepSub);
            comando.Parameters.AddWithValue("@Depnom", Deporte.DepNom);
            comando.Parameters.AddWithValue("@TypePoint", Deporte.TypePoint);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public int RegDeportista(Generar.Deportista Deportista)
        {
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "INSERT INTO Deportista (IdDeportista, Nom, Apellido, Peso, Altura, AnosEntr) VALUES(@IdDeportista, @Nom, @Apellido, @Peso, @Altura, @AnosEntr)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdDeportista", Deportista.IdDeportista);
            comando.Parameters.AddWithValue("@Nom", Deportista.Nom);
            comando.Parameters.AddWithValue("@Apellido", Deportista.Apellido);
            comando.Parameters.AddWithValue("@Peso", Deportista.Peso);
            comando.Parameters.AddWithValue("@Altura", Deportista.Altura);
            comando.Parameters.AddWithValue("@AnosEntr", Deportista.AnosEntr);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public int RegEquipo(Generar.Equipo Equipo)
        {
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "INSERT INTO Equipo (IdEq, EqNom, Pais, Region, IdSub) VALUES(@IdEq, @EqNom, @Pais, @Region, @IdSub)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdEq", Equipo.IdEq);
            comando.Parameters.AddWithValue("@EqNom", Equipo.EqNom);
            comando.Parameters.AddWithValue("@Pais", Equipo.Pais);
            comando.Parameters.AddWithValue("@Region", Equipo.Region);
            comando.Parameters.AddWithValue("@IdSub", Equipo.IdSub);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public int RegComp(Generar.Competencia Competencia)
        {
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "INSERT INTO Competencia (IdComp, Fecha_hora, Ubicacion, IdEvento) VALUES(@IdComp, @Fecha_hora, @Ubicacion, @IdEvento)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdComp", Competencia.IdComp);
            comando.Parameters.AddWithValue("@Fecha_hora", Competencia.Fecha_hora);
            comando.Parameters.AddWithValue("@Ubicacion", Competencia.Ubicacion);
            comando.Parameters.AddWithValue("@IdEvento", Competencia.IdEvento);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public class RegEvento
        {
            public int RegNacional(Generar.Evento.Nacional Evento)
            {
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "INSERT INTO Equipo (IdEvento, NomEvento, Pais) VALUES(@IdEvento, @NomEvento, @Pais)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEvento", Evento.IdEvento);
                comando.Parameters.AddWithValue("@NomEvento", Evento.NomEvento);
                comando.Parameters.AddWithValue("@Pais", Evento.Pais);

                int resultado = comando.ExecuteNonQuery();

                return resultado;
            }

            public int RegRegional(Generar.Evento.Regional Evento)
            {
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "INSERT INTO Equipo (IdEvento, NomEvento, Region) VALUES(@IdEvento, @NomEvento, @Region)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEvento", Evento.IdEvento);
                comando.Parameters.AddWithValue("@NomEvento", Evento.NomEvento);
                comando.Parameters.AddWithValue("@Region", Evento.Region);

                int resultado = comando.ExecuteNonQuery();

                return resultado;
            }

            public int RegGlobal(Generar.Evento.Global Evento)
            {
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "INSERT INTO Equipo (IdEvento, NomEvento) VALUES(@IdEvento, @NomEvento)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEvento", Evento.IdEvento);
                comando.Parameters.AddWithValue("@NomEvento", Evento.NomEvento);

                int resultado = comando.ExecuteNonQuery();

                return resultado;
            }
        }



        public bool ExisteDeporteX(Generar.Deporte Deporte)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdSub FROM XEquipos WHERE usuario LIKE @IdSub";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdSub", Deporte.IdSub);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExisteDeporte(Generar.Deporte Deporte)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdSub FROM Solitario WHERE usuario LIKE @IdSub";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdSub", Deporte.IdSub);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExisteDeportista(Generar.Deportista Deportista)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdDeportista FROM Deportista WHERE usuario LIKE @IdSub";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdSub", Deportista.IdDeportista);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExisteEquipo(Generar.Equipo Equipo)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdEq FROM Equipo WHERE usuario LIKE @IdEq";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdEq", Equipo.IdEq);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExisteCompetencia(Generar.Competencia Competencia)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdComp FROM Competencia WHERE usuario LIKE @IdComp";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdComp", Competencia.IdComp);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class ExisteEvento
        {
            public bool Nacional(Generar.Evento.Nacional Evento)
            {
                MySqlDataReader reader;
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "SELECT IdEvento FROM Nacional WHERE usuario LIKE @IdEvento";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEq", Evento.IdEvento);

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Regional(Generar.Evento.Regional Evento)
            {
                MySqlDataReader reader;
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "SELECT IdEvento FROM Regional WHERE usuario LIKE @IdEvento";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEq", Evento.IdEvento);

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Global(Generar.Evento.Global Evento)
            {
                MySqlDataReader reader;
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "SELECT IdEvento FROM Global WHERE usuario LIKE @IdEvento";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEq", Evento.IdEvento);

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }



        public Deporte SelectDeporteX(int IdSub)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdSub ,DepSub, DepNom, TypePoint, Cant.Part FROM SubDeporte WHERE IdSub LIKE @IdSub";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdSub", IdSub);

            reader = comando.ExecuteReader();

            Deporte Deporte = null;

            while (reader.Read())
            {
                int Id = int.Parse(reader["IdSub"].ToString());
                string SubNom = reader["DepSub"].ToString();
                string NomDep = reader["DepNom"].ToString();
                string TypePoint = reader["TypePoint"].ToString();
                string CantPart = reader["Cant.Part"].ToString();
                Deporte = new Deporte(Id, SubNom, NomDep, TypePoint, CantPart);
            }
            return Deporte;
        }

        public Deporte SelectDeporte(int IdSub)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdSub ,DepSub, DepNom, TypePoint FROM SubDeporte WHERE IdSub LIKE @IdSub";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdSub", IdSub);

            reader = comando.ExecuteReader();

            Deporte Deporte = null;

            while (reader.Read())
            {
                int Id = int.Parse(reader["IdSub"].ToString());
                string SubNom = reader["DepSub"].ToString();
                string NomDep = reader["DepNom"].ToString();
                string TypePoint = reader["TypePoint"].ToString();
                Deporte = new Deporte(Id, SubNom, NomDep, TypePoint, null);
            }
            return Deporte;
        }

        public Deportista SelectDeportista(int IdDeportista)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdDeportista, Nom, Apellido, Peso, Altura, AnosEntr FROM Deportista WHERE IdDeportista LIKE @IdDeportista";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdDeportista", IdDeportista);

            reader = comando.ExecuteReader();

            Deportista Deportista = null;

            while (reader.Read())
            {
                int Id = int.Parse(reader["IdDeportista"].ToString());
                string Nom = reader["Nom"].ToString();
                string Apellido = reader["Apellido"].ToString();
                float Peso = float.Parse(reader["Peso"].ToString());
                float Altura = float.Parse(reader["Altura"].ToString());
                int AnosEntr = int.Parse(reader["AnosEntr"].ToString());
                Deportista = new Deportista(Id, Nom, Apellido, Peso, Altura, AnosEntr);
            }
            return Deportista;
        }

        public Equipo SelectEquipo(int IdEq)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT IdEq, EqNom, Pais, Region, IdSub FROM XEquipos WHERE IdEq LIKE @IdEq";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdEq", IdEq);

            reader = comando.ExecuteReader();

            Equipo Equipo = null;

            while (reader.Read())
            {
                int Id = int.Parse(reader["IdEq"].ToString());
                string EqNom = reader["EqNom"].ToString();
                string Pais = reader["Pais"].ToString();
                string Region = reader["Region"].ToString();
                int IdSub = int.Parse(reader["IdSub"].ToString());
                Equipo = new Equipo(Id, EqNom, Pais, Region, IdSub);
            }
            return Equipo;
        }


        public MySqlDataAdapter SelectComp_Equipo(int IdEvento)
        {
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT NomEquipo, Puntuacion.* Fecha_hora, Ubicacion, Competencia.IdComp FROM Competencia " +
                         "JOIN ParticipaII ON Competencia.IdComp = ParticipaII.IdComp " +
                         "Join Equipo on ParticipaII.IdEq = Equipo.IdEq " +
                         "Join Puntuacion on ParticipaII.IdPoint = Puntuacion.IdPoint " +
                         "and Competencia.IdEvento = @IdEvento";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdEvento", IdEvento);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);

            return data;
        }

        public class SelectEvento
        {
            public Evento.Nacional Nacional(int IdEvento)
            {
                MySqlDataReader reader;
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "SELECT IdEvento, NomEvento, Pais FROM Nacional WHERE IdEvento LIKE @IdEvento";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEvento", IdEvento);

                reader = comando.ExecuteReader();

                Evento.Nacional Evento = null;

                while (reader.Read())
                {
                    int Id = int.Parse(reader["IdEvento"].ToString());
                    string NomEvento = reader["NomEvento"].ToString();
                    string Pais = reader["Pais"].ToString();
                    Evento = new Evento.Nacional(Id, NomEvento, Pais);
                }
                return Evento;
            }

            public Evento.Regional Regional(int IdEvento)
            {
                MySqlDataReader reader;
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "SELECT IdEvento, NomEvento, Pais FROM Regional WHERE IdEvento LIKE @IdEvento";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEvento", IdEvento);

                reader = comando.ExecuteReader();

                Evento.Regional Evento = null;

                while (reader.Read())
                {
                    int Id = int.Parse(reader["IdEvento"].ToString());
                    string NomEvento = reader["NomEvento"].ToString();
                    string Region = reader["Region"].ToString();
                    Evento = new Evento.Regional(Id, NomEvento, Region);
                }
                return Evento;
            }

            public Evento.Global Global(int IdEvento)
            {
                MySqlDataReader reader;
                MySqlConnection conexion = Server.getConexion();
                conexion.Open();

                string sql = "SELECT IdEvento, NomEvento FROM Global WHERE IdEvento LIKE @IdEvento";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@IdEvento", IdEvento);

                reader = comando.ExecuteReader();

                Evento.Global Evento = null;

                while (reader.Read())
                {
                    int Id = int.Parse(reader["IdEvento"].ToString());
                    string NomEvento = reader["NomEvento"].ToString();
                    Evento = new Evento.Global(Id, NomEvento);
                }
                return Evento;
            }

        }

        public int CountDep()
        {
            int cant = 0;
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM SubDeporte";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cant++;
            }
            return cant;
        }

        public int CountDepX()
        {
            int cant = 0;
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM Solitario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cant++;
            }
            return cant;
        }

        public int CountDeportista()
        {
            int cant = 0;
            MySqlDataReader reader;
            MySqlConnection conexion = Server.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM Deportista";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cant++;
            }
            return cant;
        }






        




    }
}
