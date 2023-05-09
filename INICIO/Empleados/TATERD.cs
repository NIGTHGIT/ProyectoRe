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
    public partial class TATERD : Form
    {
        public TATERD()
        {
            InitializeComponent();
        }

        int prox = 0;
        int proy = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) {
                prox = e.X;
                proy = e.Y;
            
            
            }
            else
            {

                Left = Left +(e.X - prox);
                 Top = Top + (e.Y - proy);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           agrd dd = new agrd();
            dd.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado dd = new Empleado();
            dd.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar asb = new Modificar();
            asb.Show();

            Empleado sss = new Empleado();
            sss.Close();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
