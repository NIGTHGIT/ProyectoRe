using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data.SqlClient; //Asumiendo que se usa una base de datos SQL Server


namespace INICIO.SubMenusFactura.SudmenudeFacturarFin
{
    public partial class ViewFactura : Form
    {
        public ViewFactura(string codigo,string DIS)
        {
            InitializeComponent();
            go = codigo;
            this.CenterToParent();
            eSTADO = DIS;

        }



        private string go;
        private string eSTADO;

        private void ViewFactura_Load(object sender, EventArgs e)
        {
            Codig.Text = go;
            if (eSTADO == "Ver...") {

                Factura.Enabled = false;


            }
            else
            {
                Factura.Enabled = true;
            }

           

        }










        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable dtProductos;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PrintDocument factura = new PrintDocument();
            factura.PrintPage += new PrintPageEventHandler(ImprimirFactura);
            PrintDialog dialogo = new PrintDialog();
            dialogo.Document = factura;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                factura.Print();
            }
        }



       
        private void button2_Click(object sender, EventArgs e)
        {

            Facturar fac = new Facturar(go);
            fac.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument factura = new PrintDocument();
            factura.PrintPage += new PrintPageEventHandler(ImprimirFactura);
            PrintDialog dialogo = new PrintDialog();
            dialogo.Document = factura;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                factura.Print();
            }

        }


       


      

        private void ImprimirFactura(object sender, PrintPageEventArgs e)

        {
            ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
            SqlCommand COMADNO = new SqlCommand($"select * from FacturaPendiente WHERE NumeroOrdern = '{go}'", CON.Conexifon());
            SqlDataReader eje = COMADNO.ExecuteReader();
            eje.Read();
            var ESTAO = eje["Estado"].ToString();


            // Dibuja la tabla de productos y precios
            int x = 100;
            int y = 200;

            // Dibuja los elementos de la factura utilizando los métodos de dibujo de la clase Graphics
            e.Graphics.DrawString("Factura", new Font("Arial", 20), Brushes.Black, x, y);
            y = y + 50;
            e.Graphics.DrawString("Numero de orden", new Font("Arial", 15), Brushes.Black, x, y);
            e.Graphics.DrawString("Estado", new Font("Arial", 15), Brushes.Black, x + 200, y);
            y = y + 25;
            e.Graphics.DrawString(go, new Font("Arial", 13), Brushes.Black, x, y);
            e.Graphics.DrawString(ESTAO, new Font("Arial", 13), Brushes.Black, x + 200, y);
            y = y + 25;
            e.Graphics.DrawString("--------------------------------------------------", new Font("Arial", 13), Brushes.Black, x, y);
            y = y + 50;
            e.Graphics.DrawString("Producto", new Font("Arial", 13), Brushes.Black, x, y);
            e.Graphics.DrawString("Precio", new Font("Arial", 13), Brushes.Black, x + 225, y);
            y = y + 50;
            //pRODUCOS AN PRECIOS
            SqlCommand comano = new SqlCommand($"select * from Factura where NumeroDeOrden = '{go}'",CON.Conexifon());
            SqlDataReader ejecutar2 = comano.ExecuteReader();
            while (ejecutar2.Read()) { 

                e.Graphics.DrawString( ejecutar2["CantidadProducto"].ToString() + "x"  + ejecutar2["NombreProducto"].ToString(), new Font("Arial", 10), Brushes.Black, x, y);
                e.Graphics.DrawString(ejecutar2["PrecioProducto"].ToString() + "$", new Font("Arial", 10), Brushes.Black, x + 225, y);
                y = y + 25;
            }
            y = y + 25;
            e.Graphics.DrawString("--------------------------------------------------", new Font("Arial", 13), Brushes.Black, x, y);
            y = y + 50;
            e.Graphics.DrawString("Total", new Font("Arial", 13), Brushes.Black, x, y);
            SqlCommand comano2 = new SqlCommand($"select * from Factura where NumeroDeOrden = '{go}'", CON.Conexifon());
            SqlDataReader ejecutar22 = comano2.ExecuteReader();
            int a = 0;
            while (ejecutar22.Read())
            {

                int i = int.Parse(ejecutar22["PrecioTotal"].ToString());
                a = a + i;

            }
            e.Graphics.DrawString("Total:", new Font("Arial", 13), Brushes.Black, x, y);
            e.Graphics.DrawString(a.ToString() + "$", new Font("Arial", 13), Brushes.Black, x + 50, y);








        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            PrintDocument factura = new PrintDocument();
            factura.PrintPage += new PrintPageEventHandler(ImprimirFacturaCocina);
            PrintDialog dialogo = new PrintDialog();
            dialogo.Document = factura;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                factura.Print();
            }
        }

        private void ImprimirFacturaCocina(object sender, PrintPageEventArgs e) {

            ConexionSQ.Conexion CON = new ConexionSQ.Conexion();
            SqlCommand COMADNO = new SqlCommand($"select * from FacturaPendiente WHERE NumeroOrdern = '{go}'", CON.Conexifon());
            SqlDataReader eje = COMADNO.ExecuteReader();
            eje.Read();
            var ESTAO = eje["Estado"].ToString();
            //Buscala mesa
    
            SqlCommand COMADNO3 = new SqlCommand($"select * from Mesa where NumOderOcupado = '{go}'", CON.Conexifon());
            SqlDataReader eje3 = COMADNO3.ExecuteReader();
            eje3.Read();
            var ESTAO3 = eje3["Area"].ToString();
            var ESTAO4 = eje3["NombreMesa"].ToString();

            // Dibuja la tabla de productos y precios
            int x = 100;
            int y = 200;

            // Dibuja los elementos de la factura utilizando los métodos de dibujo de la clase Graphics
            e.Graphics.DrawString("Factura de cocina", new Font("Arial", 20), Brushes.Black, x, y);
            y = y + 50;
            e.Graphics.DrawString("Numero de orden", new Font("Arial", 15), Brushes.Black, x, y);
            e.Graphics.DrawString("Estado", new Font("Arial", 15), Brushes.Black, x + 200, y);
            y = y + 25;
            e.Graphics.DrawString(go, new Font("Arial", 13), Brushes.Black, x, y);
            e.Graphics.DrawString(ESTAO, new Font("Arial", 13), Brushes.Black, x + 200, y);
            y = y + 25;
            e.Graphics.DrawString("--------------------------------------------------", new Font("Arial", 13), Brushes.Black, x, y);
            y = y + 50;
            e.Graphics.DrawString("Area:", new Font("Arial", 14), Brushes.Black, x, y);
            e.Graphics.DrawString("Mesa:", new Font("Arial", 14), Brushes.Black, x + 200, y);
            y = y + 25;
            e.Graphics.DrawString(ESTAO3, new Font("Arial", 13), Brushes.Black, x, y);
            e.Graphics.DrawString(ESTAO4, new Font("Arial", 13), Brushes.Black, x + 200, y);
            y = y + 25;

            e.Graphics.DrawString("--------------------------------------------------", new Font("Arial", 13), Brushes.Black, x, y);
            y = y + 50;
            e.Graphics.DrawString("Producto", new Font("Arial", 13), Brushes.Black, x, y);
            e.Graphics.DrawString("Descripcion", new Font("Arial", 13), Brushes.Black, x + 225, y);
            y = y + 50;
            SqlCommand comano = new SqlCommand($"select * from Factura where NumeroDeOrden = '{go}'", CON.Conexifon());
            SqlDataReader ejecutar2 = comano.ExecuteReader();
            while (ejecutar2.Read())
            {

                e.Graphics.DrawString(ejecutar2["CantidadProducto"].ToString() + " x " + ejecutar2["NombreProducto"].ToString(), new Font("Arial", 10), Brushes.Black, x, y);
                e.Graphics.DrawString(ejecutar2["DescripProducto"].ToString(), new Font("Arial", 10), Brushes.Black, x + 225, y);
                y = y + 25;
            }
            y = y + 25;
        }





    }
}
