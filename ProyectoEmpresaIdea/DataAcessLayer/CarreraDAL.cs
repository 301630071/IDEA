#region Librerias
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace DataAcessLayer
{
    
    public class CarreraDAL
    {
        #region Agregar conexión a BD por LINQ y MySQL.
        private static IdeaContext db = new IdeaContext();

        public static string CONNECTIONSTRING = "server=localhost;user id=root;pwd=melapelas5225.;persistsecurityinfo=True;database=idea";
        #endregion

        #region Agregar Carrera
        public static bool AgregarCarrera(string nombre)
        {
            //SELECT COUNT (*) FROM Usuario WHERE Matricula = usuario AND Password1 = pass
            return db.Carreras.Where(ca => ca.Nombre == nombre).Count() > 0;

            try
            {
                //1. Creamos objeto conexion y le pasamos la cadena de conexión
                //ubicada en el archivo App.Config
                MySqlConnection sqlConn = new MySqlConnection(CONNECTIONSTRING);


                //2. Abrir la Conexión
                sqlConn.Open();

                //3. Cerrar la Conexión
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion
    }

}

