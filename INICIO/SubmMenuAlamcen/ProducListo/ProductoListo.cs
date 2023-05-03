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

namespace INICIO.SubmMenuAlamcen.ProducListo
{
    public partial class ProductoListo : Form
    {
        private NotifyIcon Noti;
        public ProductoListo()
        {
            InitializeComponent();
            Noti = new NotifyIcon();
            Noti.Visible = true;
            Noti.Icon = new Icon("C:\\Users\\Admin\\Downloads\\419660.ico");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            EditProduc pr = new EditProduc();
            pr.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var we = "Pizaa doble queso 100RD$";
            Noti.ShowBalloonTip(10000,$"{we} Esteproducto esta por acabar","Restaurante@hotmail.com",ToolTipIcon.Info);
         
        }

        INICIO.ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand comadno = new SqlCommand($"insert into dbo.ProducHechos(Categoria, Producto, Receta, CantidadDispo,Notify)values('{Caategoria_text.Text}', '{ProductoBox.Text}', '{RecetaBox.Text}', {int.Parse(this.Can.Text)},'{Verific().ToString()}')",CON.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            ejecutar.Read();
            Caategoria_text.Text = "";
            ProductoBox.Text = "";
            RecetaBox.Text = "";
            Can.Text = "0";
            Veri_.Checked = false;
            MessageBox.Show("Se agrego");
        }

        private string Verific() {

            if (Veri_.Checked == true)
            {
                return "Yes";
            }
            else {
                return "No";
            }
        
        }

        private int i;
        private void Min()
        {
            i = int.Parse(Can.Text);
            if (i == 0)
            {
                Can.Text = 0.ToString();
                i = 0;
            }
            i--;
            Can.Text = i.ToString();
        }
        private void Max()
        {
            i = int.Parse(Can.Text);
            i++;
            Can.Text = i.ToString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Max();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Min();
        }
    }
}
