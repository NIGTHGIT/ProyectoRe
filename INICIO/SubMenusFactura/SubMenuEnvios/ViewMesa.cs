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
using INICIO.ConexionSQ;
namespace INICIO.SubMenusFactura.SubMenuEnvios
{
    public partial class ViewMesa : Form
    {
        public ViewMesa()
        {
            InitializeComponent();
        }

        private void ViewMesa_Load(object sender, EventArgs e)
        {
            Conexion CON = new Conexion();
            SqlCommand COMADO = new SqlCommand("SELECT * FROM Mesa",CON.Conexifon());
            SqlDataReader red = COMADO.ExecuteReader();
            while (red.Read())
            {



                int vERIFIC = int.Parse(red["CapacidadOcupada"].ToString());
                
                Panel P = new Panel();
                P.Size = new Size(186, 123);
                if (vERIFIC > 0) {
                    P.BackColor = Color.DarkRed;
                }
                else
                {

                    P.BackColor = Color.DarkBlue;
                }


                //DENTRO DEL Panel

                //Nombre de la mesa
                Label L = new Label();
                L.AutoSize = true;
                L.Location = new Point(62,37);
                L.Font = new Font("Microsoft Sans Serif", 13);
                L.Text = red["NombreMesa"].ToString();
                L.ForeColor = Color.White;
                P.Controls.Add(L);
                //Capacidad 
                Label L2 = new Label();
                L2.AutoSize = true;
                L2.Location = new Point(12, 87);
                L2.Font = new Font("Microsoft Sans Serif", 10);
                L2.Text = "Capacidad " + red["CapacidadOcupada"].ToString() + "/" + red["capacidadMaxima"].ToString();
                L2.ForeColor = Color.White;
                P.Controls.Add(L2);
                //Area
                Label L3 = new Label();
                L3.AutoSize = true;
                L3.Location = new Point(111, 87);
                L3.Font = new Font("Microsoft Sans Serif", 10);
                L3.Text = red["Area"].ToString();
                L3.ForeColor = Color.White;
                P.Controls.Add(L3);

                //Añadimos el panel a nuetra diseño
                PanelMadre.Controls.Add(P);



            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
