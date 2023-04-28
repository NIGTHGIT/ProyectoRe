using INICIO.subMANUSConfigura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

      

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Inicio d = new Inicio();
            d.Show();
        }


       public void aBRIRhIJA(Object HIJA)
        {

            Form R = HIJA as Form;
          if (Panelmadre.Controls.Count > 0)
            {
                Panelmadre.Controls.RemoveAt(0);
            }
            R.FormBorderStyle = FormBorderStyle.None;
            R.Dock = DockStyle.Fill;
            R.TopLevel = false;
            Panelmadre.Controls.Add(R);
            Panelmadre.Tag = R;
            R.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            aBRIRhIJA(new InfOUser());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            aBRIRhIJA(new ConfiguracionII());
        }
    }
}
