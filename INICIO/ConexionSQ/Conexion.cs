using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace INICIO.ConexionSQ
{
   public class Conexion
    {


        static private string conec = "DATA SOURCE = .\\SQLEXPRESS ; DATABASE = RestaHurante ; integrated security = true ";
       private SqlConnection con;
        public SqlConnection Conexifon()
        {

            con = new SqlConnection(conec);
            con.Open();
            return con;
                 

        }
       

       

        public void Close()
        {
            con.Close();
        }

    }
       
}
