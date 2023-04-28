using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INICIO.SubMenusFactura.SudmenudeFacturarFin.MenuEliminarFac
{
    public partial class EliminarUna : Form
    {
        public EliminarUna()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codi = Norden.Text;
            if (Aceptar.Checked == true)
            {
                try
                {
                    //INICIO.ConexionSQ.Conexion con = new INICIO.ConexionSQ.Conexion();
                    INICIO.ConexionSQ.Conexion C = new ConexionSQ.Conexion();

                    SqlCommand COMADNO = new SqlCommand($"DELETE LLevar WHERE  NumeroDeOrden = '{codi}'", C.Conexifon());
                    SqlDataReader red = COMADNO.ExecuteReader();
                    red.Read();
                    SqlCommand COMADNO1 = new SqlCommand($"DELETE FacturaMesa WHERE  NumeroOrden = '{codi}'", C.Conexifon());
                    SqlDataReader red1 = COMADNO1.ExecuteReader();
                    red1.Read();
                    SqlCommand COMADNO2 = new SqlCommand($"DELETE Factura WHERE  NumeroDeOrden= '{codi}'", C.Conexifon());
                    SqlDataReader red2 = COMADNO2.ExecuteReader();
                    red2.Read();
                    SqlCommand COMADNO3 = new SqlCommand($"DELETE FactuarTotal WHERE  NumeroDeOrden = '{codi}'", C.Conexifon());
                    SqlDataReader red3 = COMADNO3.ExecuteReader();
                    red3.Read();
                    SqlCommand COMADNO4 = new SqlCommand($"DELETE FacturaPendiente WHERE  NumeroOrdern = '{codi}'", C.Conexifon());
                    SqlDataReader red4 = COMADNO4.ExecuteReader();
                    red4.Read();
                    MessageBox.Show("Se elimino factura correctamente","Elimnar",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("No se puedo eliminar");
                }
            }
            else
            {
                MessageBox.Show("Por favor acepta las condiciones!!","Aceptar",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
