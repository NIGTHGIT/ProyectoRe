using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using INICIO.ConexionSQ;
using System.Windows.Forms;

namespace INICIO.SubMenusFactura
{
    public partial class Seleccion : Form
    {
        public Seleccion(string CO)
        {
            InitializeComponent();
            codi = CO;
        }
        private int totalFin; 
        private string PrecioTotal;
        private string codi;
        private int sumaPrecio;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eres gay");
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            if (NombrePerson.Text == "" && ApellidoPerson.Text == "")
            {
                errorP.SetError(NombrePerson, "Uno de estos campos estan vacios");
                errorP.SetError(ApellidoPerson, "Uno de estos campos estan vacios");
            }
            else
            {

                errorP.SetError(NombrePerson, "");
                errorP.SetError(ApellidoPerson, "");


               


                Conexion con = new Conexion();

                int pProduc = int.Parse(PrecioTotal);
                int i2 = int.Parse(this.Numero.Value.ToString());
                int rSUL = pProduc * i2;
                totalFin += rSUL;



                string consulta = $"INSERT INTO dbo.Factura(NumeroDeOrden, NombreCliente, ApellidoCliente, NombreProducto, CantidadProducto, PrecioProducto, PrecioTotal, DescripProducto)values('{ this.CodigoN.Text}', '{ this.NombrePerson.Text}', '{this.ApellidoPerson.Text }', '{ this.NombreProud.Text}',{this.Numero.Value },{ PrecioTotal },{rSUL}, '{ this.Descrip.Text}')";
                
                SqlCommand coma = new SqlCommand(consulta,con.Conexifon());
                SqlDataReader redi1 = coma.ExecuteReader();
                redi1.Read();
                MessageBox.Show("Se agrego elemento!!","Agregar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Precio.Text = totalFin.ToString();
                string Consulta = $"SELECT NombreProducto,CantidadProducto,PrecioProducto,PrecioTotal FROM Factura WHERE NumeroDeOrden = '{ this.CodigoN.Text}'";
                SqlDataAdapter daptador = new SqlDataAdapter(Consulta,con.Conexifon());
                SqlCommandBuilder BUL = new SqlCommandBuilder(daptador);
                DataSet DATA = new DataSet();

                daptador.Fill(DATA);
                dataGridView2.ReadOnly = true;
                dataGridView2.DataSource = DATA.Tables[0];


                

            }
            
        }

        private void addCategoria()
        {
            Conexion CON = new Conexion();

            string COMADNO = "SELECT * FROM CateogoriaAlimenticia";
            SqlCommand comando = new SqlCommand(COMADNO,CON.Conexifon());
            SqlDataReader Botoens = comando.ExecuteReader();
            while (Botoens.Read()) {

                Button btn = new Button();
                btn.Name = Botoens["NombreDecategoria"].ToString();
                btn.Text = Botoens["NombreDecategoria"].ToString();
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.DarkCyan;
                btn.Size = new Size(104, 52);
                btn.ForeColor = Color.White;
                btn.Click += new EventHandler(btn_Click);
                this.Control.Controls.Add(btn);



            }





        }


        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            string c = $"SELECT NombrePlatillo,PrecioProducto,CodigoProducto FROM dbo.Productos where CategoriaPlatillo = '{btn.Name}'";
            SqlDataAdapter adao = new SqlDataAdapter(c, "DATA SOURCE = .\\SQLEXPRESS ; DATABASE = RestaHurante ; integrated security = true ");
            SqlCommandBuilder A = new SqlCommandBuilder(adao);
            DataSet fl = new DataSet();

            adao.Fill(fl);
            this.DataView.ReadOnly = false;
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
            this.DataView.DataSource = fl.Tables[0];
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {

            addCategoria();
            this.CodigoN.Text = codi;
            Conexion con = new Conexion();
            string Consulta = $"SELECT NombreProducto,CantidadProducto,PrecioProducto,PrecioTotal FROM Factura WHERE NumeroDeOrden = '{ this.CodigoN.Text}'";
            SqlDataAdapter daptador = new SqlDataAdapter(Consulta, con.Conexifon());
            SqlCommandBuilder BUL = new SqlCommandBuilder(daptador);
            DataSet DATA = new DataSet();

            daptador.Fill(DATA);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = DATA.Tables[0];

        }

        
        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >  -1)
            {
                DataGridViewRow row = DataView.Rows[e.RowIndex];
                string NOmbre = row.Cells["NombrePlatillo"].Value.ToString();
                PrecioTotal = row.Cells["PrecioProducto"].Value.ToString();
              var a =   MessageBox.Show($" Quieres agregar  a '{NOmbre}' \n Con un precio de: {PrecioTotal}$","Agregar",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

                if (a == DialogResult.Yes) {

                    this.NombreProud.Text = NOmbre;
                    this.Subtotal.Text = PrecioTotal;
                    sumaPrecio = int.Parse(PrecioTotal);

                }
            }
        }
     
        private void NombreProud_TextChanged(object sender, EventArgs e)
        {

           
    
    
         }

        private int i;
        private void Numero_ValueChanged(object sender, EventArgs e)
        {
           
            var a = Numero.Value.ToString();
            int tras = int.Parse(a);

             i = sumaPrecio * tras;

            this.Subtotal.Text = i.ToString() + "$"; 



        }

        //esto sirve para Eliminar elemnetos de la  fila
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex > -1)
            {
                var po = MessageBox.Show("¿Seguro que quieres elimnarlo?","Elimnar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (po == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                    Conexion con = new Conexion();
                    var a = row.Cells["NombreProducto"].Value.ToString();
                    var b = row.Cells["PrecioTotal"].Value.ToString();
                    string consulta = $"DELETE Factura where NombreProducto = '{a}' AND NumeroDeOrden = '{ this.CodigoN.Text}'";
                    SqlCommand comando = new SqlCommand(consulta, con.Conexifon());
                    SqlDataReader s = comando.ExecuteReader();
                    
                    int p2 = int.Parse(b);
                    totalFin = totalFin- p2;
                    this.Precio.Text = totalFin.ToString();

      
                    
                    s.Read();
                    if (e.RowIndex < 0)
                    {
                        totalFin = 0;
                       this.Precio.Text = "0";

                    }


                    MessageBox.Show("Se elimino complemante");
                    string Consulta = $"SELECT NombreProducto,CantidadProducto,PrecioProducto,PrecioTotal FROM Factura WHERE NumeroDeOrden = '{ this.CodigoN.Text}'";
                    SqlDataAdapter daptador = new SqlDataAdapter(Consulta, con.Conexifon());
                    SqlCommandBuilder BUL = new SqlCommandBuilder(daptador);
                    DataSet DATA = new DataSet();

                    daptador.Fill(DATA);
                    dataGridView2.ReadOnly = true;
                    dataGridView2.DataSource = DATA.Tables[0];
                   

                }
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Conexion con = new Conexion();
            INICIO.ConexionSQ.Conexion C = new ConexionSQ.Conexion();

            SqlCommand COMADNO = new SqlCommand($"DELETE LLevar WHERE  NumeroDeOrden = '{codi}'", C.Conexifon());
            SqlDataReader red = COMADNO.ExecuteReader();
            red.Read();
            SqlCommand COMADNO1 = new SqlCommand($"DELETE FacturaMesa WHERE  NumeroOrden = '{codi}'", C.Conexifon());
            SqlDataReader red1 = COMADNO1.ExecuteReader();
            red1.Read();
            SqlCommand COMADNO2 = new SqlCommand($"DELETE Factura WHERE  NumeroDeOrden= '{codi}'", C.Conexifon());
            SqlDataReader red2 = COMADNO2.ExecuteReader();
            red2.Read();
            SqlCommand COMADNO3 = new SqlCommand($"DELETE FactuarTotal WHERE  NumeroDeOrden = '{codi}'", C.Conexifon());
            SqlDataReader red3 = COMADNO3.ExecuteReader();
            red3.Read();
            SqlCommand COMADNO4 = new SqlCommand($"DELETE FacturaPendiente WHERE  NumeroOrdern = '{codi}'", C.Conexifon());
            SqlDataReader red4 = COMADNO4.ExecuteReader();
            red4.Read();
            string Consulta = $"SELECT NombreProducto,CantidadProducto,PrecioProducto,PrecioTotal FROM Factura WHERE NumeroDeOrden = '{ this.CodigoN.Text}'";
            SqlDataAdapter daptador = new SqlDataAdapter(Consulta, con.Conexifon());
            SqlCommandBuilder BUL = new SqlCommandBuilder(daptador);
            DataSet DATA = new DataSet();

            daptador.Fill(DATA);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = DATA.Tables[0];
            NombreProud.Text = "";
            Precio.Text = "0";
            totalFin = 0;
            MessageBox.Show("Restablecio.", "Restablecer", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void not_CheckedChanged(object sender, EventArgs e)
        {
            PanelDatosCliente.Enabled = false;
            this.NombrePerson.Text = "No aplica";
            this.ApellidoPerson.Text = "No aplica";
        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {

            PanelDatosCliente.Enabled = true;
            this.NombrePerson.Text = "";
            this.ApellidoPerson.Text = "";
        }
    }
}
