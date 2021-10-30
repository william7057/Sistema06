using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
   public class entidadCN
    {
       
            //Defi nición GLOBAL
            Conexion objCon = new Conexion();
            SqlConnection cn = new SqlConnection();
            //Método que lista los contratistas
            public DataSet listaUsuarios()
            {
                cn = objCon.getConecta();//
                SqlDataAdapter da = new SqlDataAdapter("select * from users", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Users");
                return ds;
            }
        }
}
