using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace INICIO.SubmMenuAlamcen.MenufILTRO
{
    public partial class AgregarAHeramientas : Form
    {
        public AgregarAHeramientas(string ara)
        {
            InitializeComponent();
            this.CenterToParent();
            area__ = ara;
        }
        static string area__;

        INICIO.ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
        private void AgregarAHeramientas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int i = int.Parse(PrecioxuNID.Text);
            decimal a = Cantidad1.Value;
            decimal r = i * a;
            ptotal.Text = r.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = Nameherra.Text;
                var precXunidad = int.Parse(PrecioxuNID.Text);
                var Area = area__;
                var precioTotal = int.Parse(ptotal.Text);
                decimal cantidad__ = Convert.ToDecimal(Cantidad1.Value);
                var descrip = Descrip.Text;

                SqlCommand comado = new SqlCommand($"INSERT INTO dbo.Heramientas(HerramnientaName,CanDispo,PrecioxUnidad,PrecioTOTAL,Descripcion,Area)values('{nombre}',{cantidad__},{precXunidad},{precioTotal},'{descrip}','{area__}')", CON.Conexifon());
                SqlDataReader RED = comado.ExecuteReader();
                RED.Read();
                MessageBox.Show("Se agrego con exito!!", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Nameherra.Clear();

            }
            catch (Exception kp)
            {
                MessageBox.Show(kp.ToString());
                throw;
            }

        }
    }
}
