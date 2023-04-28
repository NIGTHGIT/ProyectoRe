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
    public partial class Donar : Form
    {
        public Donar()
        {
            InitializeComponent();
        }
        private void abrirft(Form  Formulario)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (panel2.Visible == false)
            {
                panel2.Visible = true;

            }
            else
            {
                panel2.Visible = false;


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            panel5.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grasias por donar");

            textBox1.Text ="";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 15;


            string numero = textBox1.Text;
            if (numero.StartsWith("4"))
            {
                master.Visible = false;
                visa.Visible = true;
                expre.Visible = false;
                errorProvider1.SetError(textBox1, "");
            }
            else if (numero.StartsWith("5"))
            {
                master.Visible = true;
                visa.Visible = false;
                expre.Visible = false;
                errorProvider1.SetError(textBox1, "");
            }
            else if (numero.StartsWith("3"))
            {
                master.Visible = false;
                visa.Visible = false;
                expre.Visible = true;
                errorProvider1.SetError(textBox1, "");
            }
            else {

                errorProvider1.SetError(textBox1,"el cart no esta disponoble");


            
            
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Editar DDD = new Editar();
            DDD.Show();
            this.Close();
        }
    }
}
