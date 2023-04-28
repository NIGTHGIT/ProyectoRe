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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        int posx = 0;
        int postt = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                postt = e.Y;


            }
            else {
                Left = Left + (e.X- posx);
                Top = Top +(e.Y - postt);
            
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado ssss = new Empleado();
            ssss.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MODIFICAR2 mmmg = new MODIFICAR2();
            mmmg.Show();

            this.Close();
        }
    }
}
