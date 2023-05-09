using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace INICIO.Empleados
{




    
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();


            chekboxNormal.Checked = Confiempleados.Default.Normal;
            chekboxTropical.Checked = Confiempleados.Default.Tropical;
            chekboxParcial.Checked = Confiempleados.Default.parcial;


            button1.ForeColor = Confiempleados.Default.butoom_config ;
         Guardar.ForeColor = Confiempleados.Default.butoom_config;
            panel1.BackColor = Confiempleados.Default.panel1;
            panel2.BackColor = Confiempleados.Default.panel2;







        }

        public Color Panel11;
        public Color Panel2;
        public Color From1;
        public Color buttom13;
        private void Guardarchekk() {



            Confiempleados.Default.Normal = chekboxNormal.Checked;
             Confiempleados.Default.Tropical = chekboxTropical.Checked;
            Confiempleados.Default.parcial = chekboxParcial.Checked;
            Confiempleados.Default.butoom_config = button1.ForeColor;
            Confiempleados.Default.butoom_config = Guardar.ForeColor;
            Confiempleados.Default.panel1 = panel1.BackColor;
            Confiempleados.Default.panel2 =panel2.BackColor;
          


            Confiempleados.Default.Save();
            MessageBox.Show("se guardo");







        }

        private void Restablecerc()
        {
            Confiempleados.Default.Reset();
            MessageBox.Show("se restablesio");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar sss = Owner as Editar;

            sss.pictureBox11.Visible = false;



        }

        int prox = 0;
        int proy = 0;


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {


            if (e.Button != MouseButtons.Left)
            {
                prox = e.X;
                proy = e.Y;


            }
            else {

                Left = Left + (e.X - prox);
                Top = Top + (e.Y - proy);
            
            
            
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Configuracion_Paint(object sender, PaintEventArgs e)

        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
          

            try
            {


                if (chekboxNormal.Checked == true)
                {

                    panel1.BackColor = Color.DarkSlateGray;
                    panel2.BackColor = Color.DarkSlateGray;
                    button1.ForeColor = Color.PaleTurquoise;




                }
                else if (chekboxParcial.Checked == true)
                {

                }
                else if (chekboxTropical.Checked == true)
                {

                }

            }

            catch (Exception)
            {
                MessageBox.Show("ubo un err");

            }
            finally {

                Guardarchekk();
          
                
            }
            


        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Restablecerc();

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            Restablecerc();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Editar dddd =  new Editar();
            dddd.Show();
            this.Close();
        }
    }
}
