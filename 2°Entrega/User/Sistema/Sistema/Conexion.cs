﻿using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class Conexion
    {
        public static SqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "1234";
            string bd = "sistema_usuarios";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password="+password + "; database="+bd;

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            return conexion;

        }
    }
}
