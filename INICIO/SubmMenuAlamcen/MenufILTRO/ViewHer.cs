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

namespace INICIO.SubmMenuAlamcen.MenufILTRO
{
    public partial class ViewHer : Form
    {
        public ViewHer(string id)
        {
            InitializeComponent();
            ID = id;
            this.CenterToParent();
        }
        static string ID;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        INICIO.ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
        private void ViewHer_Load(object sender, EventArgs e)
        {
            
            try
            {

                int idQ = int.Parse(ID);
                SqlCommand ciomado = new SqlCommand($"SELECT * FROM dbo.Heramientas where ID = {idQ}", CON.Conexifon());
                SqlDataReader RED = ciomado.ExecuteReader();
                RED.Read();

                CantidadDispo.Text = RED["CanDispo"].ToString();
                Name1.Text = RED["HerramnientaName"].ToString();
                Precio.Text = RED["PrecioTOTAL"].ToString();
                PreicoXunidad.Text = RED["PrecioxUnidad"].ToString();
                Descrip.Text = RED["Descripcion"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(ID);
                throw;
            }
           


        }

        static int i;
        static int iTotal;

        private void nes_Click(object sender, EventArgs e)
        {
            iTotal = int.Parse(PreicoXunidad.Text);
            i = int.Parse(CantidadDispo.Text);
            if (i == 0)
            {
                MessageBox.Show("Ya se acabaron");
            }
            else {

                i--;
                iTotal = iTotal * i;
            }
            Precio.Text = iTotal.ToString();
            CantidadDispo.Text = i.ToString();

        }

        private void px_Click(object sender, EventArgs e)
        {

            iTotal = int.Parse(PreicoXunidad.Text);
            i = int.Parse(CantidadDispo.Text);
           

                i++;
                iTotal = iTotal * i;
            
            Precio.Text = iTotal.ToString();
            CantidadDispo.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand ciomado = new SqlCommand($"UPDATE Heramientas SET CanDispo = {i}, PrecioTOTAL = {int.Parse(Precio.Text)}, Descripcion = '{Descrip.Text}',PrecioxUnidad = {int.Parse(PreicoXunidad.Text)} where ID = {ID} ", CON.Conexifon());
            SqlDataReader RED = ciomado.ExecuteReader();
            RED.Read();
            MessageBox.Show("Se modifico correctamente");
        }

        private void PreicoXunidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
