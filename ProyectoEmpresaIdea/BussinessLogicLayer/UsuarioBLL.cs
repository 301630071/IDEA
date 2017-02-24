#region Librerias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace BussinessLogicLayer
{
    public class UsuarioBLL
    {
        #region iniciarSesion
        public static string iniciarSesion(int matricula, string pwd)
        {
            //Validación 1. 
            //Verificar si el metodo viene con datos

            if (string.IsNullOrEmpty(pwd))
            {
                return "Falta ingresar la contraseña";
            }
            else
            {

                //Validación 2.
                //Verificar conexión con el Servidor
                string msg;

                msg = DataAcessLayer.ConnectionMySQL.iniciarConexion();

                if (string.IsNullOrEmpty(msg))
                {
                    bool IsLogIn;


                    //Conecto DataAccessLayer con BussinessLogicLayer
                    IsLogIn = DataAcessLayer.UsuarioDAL.iniciarSesion(matricula, pwd);


                    //Validación 3. 
                    //Verificar si el usuario existe en la base de datos
                    if (IsLogIn)
                    {
                        return "";
                    }
                    else
                    {
                        return "Favor de intentar nuevamente, credenciales incorrectas";
                    }

                }
                else
                {
                    return msg;
                }
            }

        }
        #endregion
      public static string Registrar (int mat, string nom, string ap1, string ap2, string car, string gra, string  pwd1, string pwd2, string cor)
        {
            //Validación 1. 
            //Verificar si el metodo viene con datos
            string msg1 = "Usuario Registrado";
            
            if (string.IsNullOrEmpty(nom))
            {
                return "Falta ingresar el Nombre";
            }
            if (string.IsNullOrEmpty(ap1))
            {
                return "Falta ingresar el Apellido Paterno";
            }
            if (string.IsNullOrEmpty(ap2))
            {
                return "Falta ingresar el Apellido Materno";
            }
            if (string.IsNullOrEmpty(car))
            {
                return "Falta seleccionar la carrera a la que perteneces";
            }
            if (string.IsNullOrEmpty(gra))
            {
                return "Falta seleccionar tu grado";
            }
            if (string.IsNullOrEmpty(pwd1))
            {
                return "Falta ingresar la contraseña";
            }
            if (string.IsNullOrEmpty(pwd2))
            {
                return "Falta reingresar la contraseña";
            }
            if (string.IsNullOrEmpty(cor))
            {
                return "Falta ingresar el Correo electronico";
            }
            else
            {
                return "msg1";
            }
        }
    }
}
