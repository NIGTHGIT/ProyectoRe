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
    public partial class ViewHerramienta : Form
    {
        public ViewHerramienta(string area)
        {
            InitializeComponent();
            area1 = area;
            area3.Text = area;
        }
        static string area1;

        INICIO.ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AgregarAHeramientas HR = new AgregarAHeramientas(area1);
            HR.Show();
        }

        private void ViewHerramienta_Load(object sender, EventArgs e)
        {


            SqlDataAdapter adaptador = new SqlDataAdapter($"SELECT * FROM dbo.Heramientas where Area = '{area1}'", CON.Conexifon());
            SqlCommandBuilder bul = new SqlCommandBuilder(adaptador);
            DataSet data = new DataSet();
            adaptador.Fill(data);
           
            
            this.DataView.ReadOnly = true;
            DataView.BackgroundColor = Color.White;
            DataView.BorderStyle = BorderStyle.None;
            DataView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            DataView.EnableHeadersVisualStyles = false;
            DataView.DefaultCellStyle.Font = new Font("Arial", 9);
            DataView.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            DataView.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
            DataView.GridColor = Color.FromArgb(200, 200, 200);
            this.DataView.DataSource = data.Tables[0];





        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) {

                DataGridViewRow row = DataView.Rows[e.RowIndex];
                var ID = row.Cells["ID"].Value.ToString();

                var YES = MessageBox.Show("Quieres ver esta herramienta?","Herrameinta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(YES  == DialogResult.OK)
                {
                    ViewHer ver_Herramienta = new ViewHer(ID);
                    ver_Herramienta.Show();
                }

            }
        }
    }
            
}
