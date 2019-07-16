using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Conexion
{
    public class Conexion
    {
        private SqlConnection _Sql_Connection;
        private string linea_de_conexion;

        public Conexion()
        {
            linea_de_conexion = "Server=(local);DataBase=FerreteriaBD;Integrated Security = true";
        }

        public SqlConnection GetConnection()
        {
            if (_Sql_Connection != null)
                return _Sql_Connection;

            try
            {
                _Sql_Connection = new SqlConnection(linea_de_conexion);
                return _Sql_Connection;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public SqlConnection OpenConnection()
        {
            if (_Sql_Connection.State == ConnectionState.Closed)
                _Sql_Connection.Open();

            return _Sql_Connection;
        }

        public SqlConnection CloseConnection()
        {
            if (_Sql_Connection.State == ConnectionState.Open)
                _Sql_Connection.Close();

            return _Sql_Connection;
        }

    }
}
