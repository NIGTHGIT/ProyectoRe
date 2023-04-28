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
    public partial class EliminarTodas : Form
    {
        public EliminarTodas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Aceptar.Checked == true)
            {
                INICIO.ConexionSQ.Conexion C = new ConexionSQ.Conexion();

                SqlCommand COMADNO = new SqlCommand($"DELETE LLevar", C.Conexifon());
                SqlDataReader red = COMADNO.ExecuteReader();
                red.Read();
                SqlCommand COMADNO1 = new SqlCommand($"DELETE FacturaMesa", C.Conexifon());
                SqlDataReader red1 = COMADNO1.ExecuteReader();
                red1.Read();
                SqlCommand COMADNO2 = new SqlCommand($"DELETE Factura", C.Conexifon());
                SqlDataReader red2 = COMADNO2.ExecuteReader();
                red2.Read();
                SqlCommand COMADNO3 = new SqlCommand($"DELETE FactuarTotal", C.Conexifon());
                SqlDataReader red3 = COMADNO3.ExecuteReader();
                red3.Read();
                SqlCommand COMADNO4 = new SqlCommand($"DELETE FacturaPendiente", C.Conexifon());
                SqlDataReader red4 = COMADNO4.ExecuteReader();
                red4.Read();
                MessageBox.Show("Se elimino factura correctamente", "Elimnar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("ACEPTA LOS TERMINOS DE CONDICION ");
            }
        }
    }
}
