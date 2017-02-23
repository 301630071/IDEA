using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class UsuarioDAL
    {
        // Clase contexto que enlaza la Base de Datos por entity framework
        private static IdeaContext db = new IdeaContext();
        public static string CONNECTIONSTRING = "server=localhost;user id=root;pwd=melapelas5225.;persistsecurityinfo=True;database=idea";

        public static bool iniciarSesion(int user, string pwd)
        {
            //SELECT COUNT (*) FROM Usuario WHERE Matricula = usuario AND Password1 = pass
            //return db.Usuarios.Where(u => u.Matricula == user && u.Password1 == pass).Count() > 0;
            try
            {
                //1. Creamos objeto conexion y le pasamos la cadena de conexión
                //ubicada en el archivo App.Config
                MySqlConnection sqlConn = new MySqlConnection(CONNECTIONSTRING);


                //2. Abrir la conexion
                sqlConn.Open();

                //3. Crear el query que utilizaras
                string query = "SELECT * FROM Usuario WHERE Matricula = @username AND Password1 = @password";

                //4° - Crear el objeto comando al cual le pasas el query
                //y la conexion para ejecutar el query antes mencionado
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);

                //5° - Agregar los parametros necesarios
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pwd);

                //6° - Ejecutar el query y guardar el resultado
                MySqlDataReader dr = cmd.ExecuteReader();

                //7° - Validar si contiene registros
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}


