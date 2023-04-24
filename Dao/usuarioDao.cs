using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;


namespace Dao
{
    public class usuarioDao
    {

        Conexion con = new Conexion();
        public bool existeUsuario(usuario user)
        {

            string consulta = "select * from users where userName ='" + user.NombreUsuario + "' AND password = '" + user.Contraseña + "'";


            if (con.obtenerTabla(consulta).Rows.Count > 0)
            {
                return true;
            }

            return false;
        }


        public bool insertarUsuario(usuario user)
        {
            string consulta = "insert into users (userName,password,email) VALUES('" + user.NombreUsuario + "' , '" + user.Contraseña + "' , '" + user.Mail + "')";

            return con.insertarUsuario(consulta);
        }

        public usuario cargarSession(usuario user)
        {
            DataTable tablaUsuairos = new DataTable();
            string consulta = "select * from users where userName ='" + user.NombreUsuario + "' AND password = '" + user.Contraseña + "'";

            tablaUsuairos = con.obtenerTabla(consulta);

            user.NombreUsuario = tablaUsuairos.Rows[0][0].ToString();
            user.Contraseña = tablaUsuairos.Rows[0][1].ToString();
            user.Mail = tablaUsuairos.Rows[0][2].ToString();
            user.Estado = tablaUsuairos.Rows[0][3].ToString();
            user.Pp = tablaUsuairos.Rows[0][4].ToString();

            return user;
        }

        public bool cargarPP(string pp, usuario user)
        {
            string consulta = "update users set pp = '" + pp + "' where userName = '"+ user.NombreUsuario + "' ";

            return con.updatePP(consulta);
        }


    }
}
