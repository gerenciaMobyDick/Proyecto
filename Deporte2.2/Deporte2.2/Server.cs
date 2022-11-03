using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Deporte2._2
{
    class Server
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "";
            string usuario = "root";
            string password = "";
            string bd = "Proyecto_MobyDick";

            string cadenaConexion = "server=localhost; database=MobyDick; uid=root";

            MySqlConnection connection = new MySqlConnection(cadenaConexion);

            return connection;

        }
    }
}

