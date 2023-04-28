using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace INICIO.ConexionSQ
{
  public  class conexionj
    {
        static public SqlConnection Conexion = new SqlConnection("DATA SOURCE =D19B1998\\SQLEXPRESS ; DATABASE = RestaHurante ; integrated security = true ");
    }
}
