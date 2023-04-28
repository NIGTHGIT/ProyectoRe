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
using INICIO.SubMenusFactura.SubMenuEnvios;

namespace INICIO.SubMenusFactura.SudmenudeFacturarFin
{
    public partial class FacturaPendding : Form
    {
        public FacturaPendding()
        {
            InitializeComponent();
        }

        private void FacturaPendding_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string consulta = $"select * from FacturaPendiente where Estado = 'Pendiente'";
            SqlCommand comadno = new SqlCommand(consulta, con.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            PanelMadre.Controls.Clear();
            while (ejecutar.Read())
            {
                var orden = ejecutar["NumeroOrdern"].ToString();
                var estado = ejecutar["Estado"].ToString();
                var fecha = ejecutar["fechadeFact"].ToString();

                Elemento(orden,estado,fecha);

            }
            //Agrega Area

            ConexionSQ.Conexion con1 = new ConexionSQ.Conexion();
            //agregarArea
            SqlCommand comando2 = new SqlCommand("SELECT * FROM Areas", con1.Conexifon());
            SqlDataReader redi2 = comando2.ExecuteReader();

            while (redi2.Read())
            {
                var Areas = redi2["NombredErea"].ToString();


                Area.Items.Add(Areas);
            }


            //Ver informe


            string consulta2 = $"select * from FacturaPendiente";
            SqlCommand comadno2 = new SqlCommand(consulta2, con.Conexifon());
            SqlDataReader ejecutar2 = comadno2.ExecuteReader();
            pendiente = 0;
            facturado = 0;
            general = 0;
            while (ejecutar2.Read())
            {
                
                var estado = ejecutar2["Estado"].ToString();
               

                if (estado == "Pendiente") {
                    pendiente++;
                }

                else if (estado == "Facturado")
                {
                    facturado++;
                }
                general++;
            }

            Facturada.Text = facturado.ToString();
            General.Text = general.ToString();
            Pendiente.Text = pendiente.ToString();



        }
        private int facturado;
        private int general;
        private int pendiente;
        private void Elemento(string numeroorden, string estado,string fecha) {
            Panel p = new Panel();
            p.Size = new Size(549, 64);
            p.BorderStyle = BorderStyle.FixedSingle;
            //LetraqueIndiqca El numero de orden
            Label L = new Label();
            L.ForeColor = Color.White;
            L.Font = new Font("Microsoft Sans Serif", 10);
            L.Location = new Point(3, 10);
            L.Text = "Numero de orden";
            p.Controls.Add(L);
            //Muestra location
            Label L2 = new Label();
            L2.ForeColor = Color.White;
            L2.Font = new Font("Microsoft Sans Serif", 10);
            L2.Location = new Point(145, 10);
            L2.Text = "Estado";
            p.Controls.Add(L2);
            //Fecha indicacion
            Label L3 = new Label();
            L3.ForeColor = Color.White;
            L3.Font = new Font("Microsoft Sans Serif", 10);
            L3.Location = new Point(241, 10);
            L3.Text = "Fecha";
            p.Controls.Add(L3);


            //Eso es el Resultado de esos campos



            //nUMEROPDE ORDEN
            string CodigoOrden = numeroorden;
            Label L1a = new Label();
            L1a.ForeColor = Color.Cyan;
            L1a.AutoSize = true;
            L1a.Font = new Font("Microsoft Sans Serif", 10);
            L1a.Location = new Point(3, 35);
            L1a.Text = CodigoOrden;
            p.Controls.Add(L1a);
            //Estado
            string Estado = estado;
            Label L2a = new Label();
            if (Estado == "Pendiente")
            {
                L2a.ForeColor = Color.Brown;
            }
            else
            {
                L2a.ForeColor = Color.DarkGreen;
            }
            L2a.Font = new Font("Microsoft Sans Serif", 10);
            L2a.Location = new Point(145, 35);
            L2a.AutoSize = true;
            L2a.Text = Estado;
            p.Controls.Add(L2a);
            //FECHA 

            string Fecha = fecha;
            Label L3a = new Label();
            L3a.AutoSize = true;
            L3a.ForeColor = Color.Cyan;
            L3a.Font = new Font("Microsoft Sans Serif", 10);
            L3a.Location = new Point(240, 35);
            L3a.Text = Fecha;
            p.Controls.Add(L3a);
            //Button 

            Button btn = new Button();
            btn.Size = new Size(77, 35);
            btn.Location = new Point(447, 17);
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Microsoft Sans Serif", 11);
            btn.Name = CodigoOrden;
            if (Estado == "Pendiente")
            {
                btn.Text = "Facturar";
            }
            else
            {
                btn.Text = "Ver...";
            }
            btn.Click += new EventHandler(btn_Click);
            p.Controls.Add(btn);
            //Button Eliminar
            //
            //Button btn1 = new Button();
            //btn1.Size = new Size(50, 24);
            //btn1.Location = new Point(380, 25);
            //btn1.FlatStyle = FlatStyle.Flat;
            //btn1.ForeColor = Color.White;
            //btn1.Font = new Font("Microsoft Sans Serif", 10);
            //btn1.Text = "Eliminar";
            //p.Controls.Add(btn1);

           
             
            

            PanelMadre.Controls.Add(p);


        }



        private void btn_Click(object sender, EventArgs e) {

            Button btn = sender as Button;
            ViewFactura viw = new ViewFactura(btn.Name,btn.Text);
            if (btn.Text == "Facturar")
            {
                
                viw.ShowDialog();
            }
            else
            {
                viw.ShowDialog();

            }



        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string consulta = $"select * from FacturaPendiente where NumeroOrdern = '{this.NumerodeConsulta.Text}'";
                SqlCommand comadno = new SqlCommand(consulta, con.Conexifon());
                SqlDataReader ejecutar = comadno.ExecuteReader();
                PanelMadre.Controls.Clear();
                while (ejecutar.Read())
                {
                    var orden = ejecutar["NumeroOrdern"].ToString();
                    var estado = ejecutar["Estado"].ToString();
                    var fecha = ejecutar["fechadeFact"].ToString();

                    Elemento(orden, estado, fecha);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("No pudimos escontrar esta factura","Encontrar",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Conexion con = new Conexion();
            string consulta = $"select * from FacturaPendiente where Estado = 'Pendiente'";
            SqlCommand comadno = new SqlCommand(consulta, con.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            PanelMadre.Controls.Clear();
            while (ejecutar.Read())
            {
                var orden = ejecutar["NumeroOrdern"].ToString();
                var estado = ejecutar["Estado"].ToString();
                var fecha = ejecutar["fechadeFact"].ToString();

                Elemento(orden, estado, fecha);

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Conexion con = new Conexion();
            string consulta = $"select * from FacturaPendiente where Estado = 'Facturado'";
            SqlCommand comadno = new SqlCommand(consulta, con.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            PanelMadre.Controls.Clear();
            while (ejecutar.Read())
            {
                var orden = ejecutar["NumeroOrdern"].ToString();
                var estado = ejecutar["Estado"].ToString();
                var fecha = ejecutar["fechadeFact"].ToString();

                Elemento(orden, estado, fecha);

            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Conexion con = new Conexion();
            string consulta = $"select * from FacturaPendiente";
            SqlCommand comadno = new SqlCommand(consulta, con.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            PanelMadre.Controls.Clear();
            while (ejecutar.Read())
            {
                var orden = ejecutar["NumeroOrdern"].ToString();
                var estado = ejecutar["Estado"].ToString();
                var fecha = ejecutar["fechadeFact"].ToString();

                Elemento(orden, estado, fecha);

            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuEliminarFac.EliminarFactura fa = new MenuEliminarFac.EliminarFactura();
            fa.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ViewMesa mesa = new ViewMesa();
            mesa.Show(); 
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ConexionSQ.Conexion con = new ConexionSQ.Conexion();
            SqlCommand comando = new SqlCommand($"SELECT * FROM Mesa where Area = '{this.Area.Text}' and CapacidadOcupada > 0 ", con.Conexifon());
            SqlDataReader redi = comando.ExecuteReader();
            Mesa.Items.Clear();
            while (redi.Read())
            {
                var mesas = redi["NombreMesa"].ToString();

                Mesa.Items.Add(mesas);


            }

        }

        private void Mesa_TextChanged(object sender, EventArgs e)
        {
           
                ConexionSQ.Conexion con = new ConexionSQ.Conexion();
                SqlCommand comando = new SqlCommand($"SELECT * FROM Mesa where Area = '{this.Area.Text}' and  NombreMesa = '{Mesa.Text}' ", con.Conexifon());
                SqlDataReader redi = comando.ExecuteReader();
                redi.Read();
               var CODO =  redi["NumOderOcupado"].ToString();
             

                string consulta = $"select * from FacturaPendiente WHERE NumeroOrdern = '{CODO}' ";
                SqlCommand comadno = new SqlCommand(consulta, con.Conexifon());
                SqlDataReader ejecutar = comadno.ExecuteReader();
                PanelMadre.Controls.Clear();
                while (ejecutar.Read())
                {
                    var orden = ejecutar["NumeroOrdern"].ToString();
                    var estado = ejecutar["Estado"].ToString();
                    var fecha = ejecutar["fechadeFact"].ToString();

                    Elemento(orden, estado, fecha);

                }



           
        }
    }
}
