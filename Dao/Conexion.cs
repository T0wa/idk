using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    public class Conexion
    {
        private readonly string ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=loging;Integrated Security=True";


        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable obtenerTabla(string consulta)
        {
            SqlConnection cn = ObtenerConexion();
            SqlDataAdapter adp = new SqlDataAdapter(consulta, cn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Tabla");
            cn.Close();

            return ds.Tables["Tabla"];
        }

        public bool insertarUsuario(string consulta)
        {
            try
            {
                SqlConnection cn = ObtenerConexion();
                SqlCommand cmd = new SqlCommand(consulta, cn);
                int i = cmd.ExecuteNonQuery();

                cn.Close();
                if (i > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {

            }


            return false;
        }


        public bool updatePP(string consulta)
        {
            SqlConnection cn = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, cn);
            int i = cmd.ExecuteNonQuery();

            cn.Close();
            if (i > 0)
            {
                return true;
            }

            return false;
        }

    }
}
