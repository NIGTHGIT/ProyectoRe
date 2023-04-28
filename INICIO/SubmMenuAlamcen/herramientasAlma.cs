using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO.SubmMenuAlamcen
{
    public partial class herramientasAlma : Form
    {
        public herramientasAlma()
        {
            InitializeComponent();
        }
        INICIO.ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
        public void AbrirMenu(object hija)
        {
            if (this.PanedlMadre.Controls.Count > 0)
            {
                PanedlMadre.Controls.RemoveAt(0);
            }

            Form hijo = hija as Form;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            this.PanedlMadre.Controls.Add(hijo);
            this.PanedlMadre.Tag = hijo;
            hijo.Show();



        }
        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirMenu(new MenufILTRO.AreasHerramienta());
        }

        private void herramientasAlma_Load(object sender, EventArgs e)
        {
            SqlCommand comand = new SqlCommand("SELECT * FROM dbo.HeramientasArea", CON.Conexifon());
            SqlDataReader re = comand.ExecuteReader();
            flow.Controls.Clear();
            while (re.Read())
            {
              
                
                int y = 5;

                Button btn = new Button();
                btn.Name = re["AreaTITLE"].ToString();
                btn.Text = re["AreaTITLE"].ToString();
                btn.Size = new Size(140, 38);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.Click += new EventHandler(btn_Click);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Location = new Point(40, y);
              

                flow.Controls.Add(btn);

            }

        }

        private void btn_Click(object sender, EventArgs e) {

            Button btn = sender as Button;
            AbrirMenu(new MenufILTRO.ViewHerramienta(btn.Name));
        }



    }
}
