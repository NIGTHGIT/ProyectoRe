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
    public partial class Suplentes : Form
    {
        public Suplentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar ddd = new Editar();
            ddd.Show();
            this.Close();

        }

        private void Abrir2(object hija)
        {
            Form Conver = hija as Form;
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            Conver.TopLevel = false;
            Conver.Dock = DockStyle.Fill;
            Conver.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(Conver);
            panel3.Tag = Conver;
            Conver.Show();




        }

        static public int dddx = 0;
        static public int dddy = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                dddx = e.X;
                dddy = e.Y;

            }
            else {
                Left = Left + (e.X - dddx);
                Top = Top + (e.Y - dddy);


            }



        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Abrir2(new SUB.SUAGRE());
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Abrir2(new SUB.Supletes1());
        }
    }
}
