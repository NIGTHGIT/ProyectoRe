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
    public partial class AreasHerramienta : Form
    {
        public AreasHerramienta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {



        }
        INICIO.ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            SqlCommand coma = new SqlCommand($"INSERT INTO dbo.HeramientasArea (AreaTITLE)values('{Areaname.Text}')", CON.Conexifon());
            SqlDataReader red = coma.ExecuteReader();
            red.Read();
            MessageBox.Show("Se agrego!!, por favor refresque programma", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Areaname.Clear();
            ListaAreas();







        }


        private void ListaAreas()
        {
            SqlCommand comand = new SqlCommand("SELECT * FROM dbo.HeramientasArea", CON.Conexifon());
            SqlDataReader re = comand.ExecuteReader();
            pANEL111.Controls.Clear();
            while (re.Read()) {
                Panel P = new Panel();
                P.Size = new Size(330, 39);
                P.BackColor = Color.MidnightBlue;
               

                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = "C:\\Users\\Admin\\Downloads\\Delete-Icon-PNG-HD-Quality.png";
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(38, 40);
                pictureBox.Name = re["AreaTITLE"].ToString();
                pictureBox.Click += new  EventHandler(Eliminar_Click);
                pictureBox.Location = new Point(289, 0);
                P.Controls.Add(pictureBox);


                Label l = new Label();
                l.Font = new Font("Microsoft Sans Serif", 10);
                l.AutoSize = true;
                l.Text = re["AreaTITLE"].ToString();
                l.Name = re["AreaTITLE"].ToString();
                l.Location = new Point(9, 12);
                l.ForeColor = Color.White;
                P.Controls.Add(l);
                pANEL111.Controls.Add(P);

            }




        }

        private void Eliminar_Click(object sender, EventArgs e) {

            PictureBox btn = sender as PictureBox;
            SqlCommand comand = new SqlCommand($"delete dbo.HeramientasArea where AreaTITLE = '{btn.Name}'", CON.Conexifon());
            SqlDataReader re = comand.ExecuteReader();
            re.Read();

            MessageBox.Show("Se elimino con exito");

            ListaAreas();
        }

        private void AreasHerramienta_Load(object sender, EventArgs e)
        {
            ListaAreas();
        }
    }
}
