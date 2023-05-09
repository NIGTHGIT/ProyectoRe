using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO.Empleados.SUB
{
    public partial class Llamar : Form
    {
        public Llamar()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Visible == true)
            {


                pictureBox8.Visible = false;
            }
            else {
                pictureBox8.Visible = true;

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Visible == true)
            {


                pictureBox8.Visible = false;
            }
            else
            {
                pictureBox8.Visible = true;

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Visible == true) {
                pictureBox9.Visible = false;
            
            }
            else
            {
                pictureBox9.Visible = true;

            }

        }
    }
}
   