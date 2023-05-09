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

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var we = "Pizaa doble queso 100RD$";
            Noti.ShowBalloonTip(10000,$"{we} Esteproducto esta por acabar","Restaurante@hotmail.com",ToolTipIcon.Info);
         
        }

        INICIO.ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
          

            SqlCommand comadno = new SqlCommand($"insert into dbo.ProducHechos(Categoria, Producto, CantidadDispo,Notify)values('{Caategoria_text.Text}', '{ProductoBox.Text}', {int.Parse(this.Can.Text)},'{Verific().ToString()}')",CON.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            ejecutar.Read();
            Caategoria_text.Text = "";
            ProductoBox.Text = "";
           
            Can.Text = "0";
            Veri_.Checked = false;



            Lola23we.Controls.Clear();
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand("Select * from ProducHechos", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            while (RED.Read())
            {
                var Produc = RED["Producto"].ToString();
                var Cant = RED["CantidadDispo"].ToString();
                var id = RED["ID"].ToString();
                AñadirActivas(Produc, Cant, id);
            }
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

        //Por ejemplo Critica 






        private void AñadirActivas(string ProducName, string Cant,string id)
        {
           

                Panel p = new Panel();
                p.Size = new Size(271, 49);
            if (int.Parse(Cant) <= 5)
            {
                p.BackColor = Color.DarkRed;
            }
            else {
                p.BackColor = Color.MediumBlue;
            }
                //KLetra
                Label L = new Label();
                L.AutoSize = true;
                L.ForeColor = Color.White;
                L.Location = new Point(3, 16);
                L.Font = new Font("Microsoft Sans Serif", 13);
                L.Text = ProducName;
                p.Controls.Add(L);
                //icanti
                Label L2 = new Label();
                L2.AutoSize = true;
                L2.ForeColor = Color.White;
                L2.Text = $"Cant.{Cant}";
                L2.Location = new Point(137, 16);
                L2.Font = new Font("Microsoft Sans Serif", 13);
                p.Controls.Add(L2);
                //Foto
                PictureBox pic = new PictureBox();
                pic.Size = new Size(34, 41);
                pic.Name = id;
                pic.Image = INICIO.Properties.Resources._5353380;
                pic.Location = new Point(231, 8);
                pic.Click += new EventHandler(BTN_Click);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                p.Controls.Add(pic);
                this.Lola23we.Controls.Add(p);


        }



        private void BTN_Click(object sender, EventArgs e) {

            PictureBox btn = sender as PictureBox;

            EditProduc pr = new EditProduc(int.Parse(btn.Name));
            pr.ShowDialog();


        


             
        }












        private void ProductoListo_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from ProducHechos",CON.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            int i = 0;
            while (RED.Read()) {
                var Notify = RED["Notify"].ToString();

                if (Notify == "Yes")
                {
                    var Cant = int.Parse(RED["CantidadDispo"].ToString());
                    if (Cant <= 5) {
                        i++;
                        CriticasCount.Text = i.ToString();
                    }

                   
                }
               

            };
            Lola23we.Controls.Clear();
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando1 = new SqlCommand("Select * from ProducHechos", CON1.Conexifon());
            SqlDataReader RED1 = comando1.ExecuteReader();
            while (RED1.Read())
            {
                var Produc = RED1["Producto"].ToString();
                var Cant = RED1["CantidadDispo"].ToString();
                var id = RED1["ID"].ToString();
                AñadirActivas(Produc, Cant, id);
            }



            //Añadir Los categorias
            string COMADNO = "SELECT * FROM CateogoriaAlimenticia";
            SqlCommand comandoj = new SqlCommand(COMADNO, CON.Conexifon());
            SqlDataReader Botoens = comandoj.ExecuteReader();
            while (Botoens.Read())
            {
                var von = Botoens["NombreDecategoria"].ToString();
                Caategoria_text.Items.Add(von);
            }












            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lola23we.Controls.Clear();
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand("Select * from ProducHechos where CantidadDispo <= 5", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            while (RED.Read()) {
                var Produc = RED["Producto"].ToString();
                var Cant = RED["CantidadDispo"].ToString();
                var id = RED["ID"].ToString();
                AñadirActivas(Produc, Cant, id);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lola23we.Controls.Clear();
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand("Select * from ProducHechos where CantidadDispo > 5", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            while (RED.Read())
            {
                var Produc = RED["Producto"].ToString();
                var Cant = RED["CantidadDispo"].ToString();
                var id = RED["ID"].ToString();
                AñadirActivas(Produc, Cant, id);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lola23we.Controls.Clear();
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand("Select * from ProducHechos", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            while (RED.Read())
            {
                var Produc = RED["Producto"].ToString();
                var Cant = RED["CantidadDispo"].ToString();
                var id = RED["ID"].ToString();
                AñadirActivas(Produc, Cant, id);
            }
        }
        
        private void Caategoria_text_TextChanged(object sender, EventArgs e)
        {
            
            INICIO.ConexionSQ.Conexion CON1 = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand($"SELECT NombrePlatillo,PrecioProducto,CodigoProducto FROM dbo.Productos where CategoriaPlatillo = '{Caategoria_text.Text}'", CON1.Conexifon());
            SqlDataReader RED = comando.ExecuteReader();
            while (RED.Read())
            {
                var Produc = RED["NombrePlatillo"].ToString();
                ProductoBox.Items.Add(Produc);
              
            }
        }
    }
}
