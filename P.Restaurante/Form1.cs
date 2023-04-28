using INICIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.Restaurante
{
    public partial class Login : Form
    {
        public Login()
        {
            //hola
            InitializeComponent();
            this.CenterToScreen();
         
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio jkjm = new Inicio();
            jkjm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro newRegis = new Registro();
            newRegis.Show();
            this.Hide();
        }
    }
}
