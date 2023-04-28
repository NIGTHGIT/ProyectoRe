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
using INICIO.SubMenusFactura.SubMenuEnvios;

namespace INICIO.SubMenusFactura
{
    public partial class Envio : Form
    {
        public Envio(string NO)
        {
            InitializeComponent();
            this.Owner = Factura.ActiveForm;
            CO = NO;
            this.panelM.Enabled = false;
            this.panelLL.Enabled = false;
            this.panelEn.Enabled = false;
        }
        private string CO;

        private void button5_Click(object sender, EventArgs e)
        {
            if(Mesa.Checked == true)
            {
                this.panelM.Enabled = true;
                this.panelLL.Enabled = false;
                this.panelEn.Enabled = false;


                ConexionSQ.Conexion con = new ConexionSQ.Conexion();
                //agregarArea
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Areas", con.Conexifon());
                SqlDataReader redi2 = comando2.ExecuteReader();

                while (redi2.Read())
                {
                    var Areas = redi2["NombredErea"].ToString();

                    
                    Area.Items.Add(Areas);
                }
            }


            else if(Envi.Checked == true)
            {
                MessageBox.Show("No disponible, hasta un nuevo aviso");
                this.panelM.Enabled = false;
                this.panelLL.Enabled = false;
                this.panelEn.Enabled = false;
            }
            else if (this.LevarAc.Checked == true)
            {
                this.panelM.Enabled = false;
                this.panelLL.Enabled = true;
                this.panelEn.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //Aqui se modifica Las mesas

            ConexionSQ.Conexion con = new ConexionSQ.Conexion();
            string conma = $"update Mesa set CapacidadOcupada =  {int.Parse(this.Personas.Text) }  where NombreMesa = '{ this.NombreM.Text}' and Area = '{ this.Area.Text}'";
            SqlCommand comando = new SqlCommand(conma,con.Conexifon());
            SqlDataReader redi = comando.ExecuteReader();
            redi.Read();
            //
            //Este auegura que este ocupada por orden
            string conma9 = $"update Mesa set NumOderOcupado = '{CO}' where NombreMesa = '{ this.NombreM.Text}' and Area = '{ this.Area.Text}'";
            SqlCommand comando9 = new SqlCommand(conma9, con.Conexifon());
            SqlDataReader redi9 = comando9.ExecuteReader();
            redi9.Read();


            //Agregar A base de datos

            string consultaver = $"iNSERT INTO FacturaMesa (NumeroOrden,NombreMesa,Area,CantidadPersona)VALUES('{ CO}','{this.NombreM.Text}','{ this.Area.Text}',{int.Parse(this.Personas.Text)})";
            SqlCommand comando2 = new SqlCommand(consultaver, con.Conexifon());
            SqlDataReader redi2 = comando2.ExecuteReader();
            redi2.Read();

            string consultaver1 = $"UPDATE Factura set  MesaValid = 'true' where NumeroDeOrden = '{CO}'";
            SqlCommand comando21 = new SqlCommand(consultaver1, con.Conexifon());
            SqlDataReader redi21 = comando21.ExecuteReader();
            redi21.Read();
            MessageBox.Show("Se le asigno una mesa!!!");
            SudmenudeFacturarFin.Elegir elegir = new SudmenudeFacturarFin.Elegir(CO);
            


            this.Close();
            elegir.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQ.Conexion con = new ConexionSQ.Conexion();

                string a = $"SELECT * FROM dbo.Factura where NumeroDeOrden = '{ this.CO}'";
                SqlCommand comando = new SqlCommand(a, con.Conexifon());
                SqlDataReader re = comando.ExecuteReader();
                re.Read();

                var a1 = re["NombreCliente"].ToString();
                var a2 = re["ApellidoCliente"].ToString();


                string consula = $"insert into dbo.LLevar (NumeroDeOrden,NombreDelCliente,ApellidoDELCliente)values('{ this.CO}','{a1 }','{a2 }')";
                SqlCommand con1 = new SqlCommand(consula, con.Conexifon());
                SqlDataReader red2 = con1.ExecuteReader();
                red2.Read();
                string consultaver1 = $"UPDATE Factura set  LlevarValid = 'true' where NumeroDeOrden = '{CO}'";
                SqlCommand comando21 = new SqlCommand(consultaver1, con.Conexifon());
                SqlDataReader redi21 = comando21.ExecuteReader();
                redi21.Read();
                MessageBox.Show("Ok, Pedido para llevar","llEVAR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                SudmenudeFacturarFin.Elegir ele = new SudmenudeFacturarFin.Elegir(CO);
                this.Close();
                ele.Show();
                

            }
            catch (Exception)
            {
                MessageBox.Show("Porfavor registre un producto!!");
               
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ViewMesa z = new ViewMesa();
            z.Show();
        }

        private void NombreM_TextChanged(object sender, EventArgs e)
        {
            ConexionSQ.Conexion con = new ConexionSQ.Conexion();


            string a = $"SELECT * FROM Mesa  where NombreMesa = '{ this.NombreM.Text}' and Area = '{this.Area.Text}'";
            SqlCommand comando = new SqlCommand(a, con.Conexifon());
            SqlDataReader re = comando.ExecuteReader();
            re.Read();
            Personas.Items.Clear();
            try
            {
                var o = re["capacidadMaxima"].ToString();
                int p = int.Parse(o);

                for (int i = 1; i <= p; i++)
                {

                    Personas.Items.Add(i);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Area no encontrada");

            }

        }

        private void Area_TextChanged(object sender, EventArgs e)
        {


            ConexionSQ.Conexion con = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand($"SELECT * FROM Mesa where Area = '{this.Area.Text}' and CapacidadOcupada = 0 ", con.Conexifon());
            SqlDataReader redi = comando.ExecuteReader();

            while (redi.Read())
            {
                var mesas = redi["NombreMesa"].ToString();

                NombreM.Items.Add(mesas);


            }




        }

        private void Area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
