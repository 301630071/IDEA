using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class ConnectionMySQL
    {
        public static MySqlConnection MySqlConn = new MySqlConnection();
        public static string ConnectionString = "server=localhost;user id=root;pwd=melapelas5225.;persistsecurityinfo=True;database=idea";

        //Metodo que sirve para iniciar la conexión con MySQL

        public static string iniciarConexion()
        {
            try
            {
                MySqlConn.ConnectionString = ConnectionString;
                MySqlConn.Open();
                return "";
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }
    }
}
