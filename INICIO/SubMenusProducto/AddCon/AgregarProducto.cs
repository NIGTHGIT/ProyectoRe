using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using INICIO.ConexionSQ;

namespace INICIO.SubMenusProducto.AddCon
{
    public class AgregarProducto
    {

        private string Codigo;
        private string NombrePl;
        private string Categoria;
        private string Clasificacion;
        private string Descripcion;
        private string Fecha;
        private decimal PesoNeto;
        private decimal precioProducto;

        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string NombrePl1 { get => NombrePl; set => NombrePl = value; }
        public string Categoria1 { get => Categoria; set => Categoria = value; }
        public string Clasificacion1 { get => Clasificacion; set => Clasificacion = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public decimal PesoNeto1 { get => PesoNeto; set => PesoNeto = value; }
        public decimal PrecioProducto { get => precioProducto; set => precioProducto = value; }

        public void Add()
        {
            Conexion CON = new Conexion();
          
           
            var Conex = CON.Conexifon();
            string comadnoinert = $"INSERT INTO dbo.Productos (CodigoProducto,NombrePlatillo,CategoriaPlatillo,ClasificacionPlantillo,PesoNeto,PrecioProducto,FechaAdd,DescripcionProducto)VALUES('{Codigo}', '{NombrePl}', '{Categoria}', '{Clasificacion}', {PesoNeto},{PrecioProducto}, '{Fecha}', '{Descripcion}')";

            SqlCommand comando = new SqlCommand(comadnoinert,Conex);
            SqlDataReader HY = comando.ExecuteReader();
            HY.Read();






            CON.Close();



        }

           
            
        




    }
}
