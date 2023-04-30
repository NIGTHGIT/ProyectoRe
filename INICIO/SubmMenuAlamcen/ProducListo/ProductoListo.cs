using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO.SubmMenuAlamcen.ProducListo
{
    public partial class ProductoListo : Form
    {
        private NotifyIcon Noti;
        public ProductoListo()
        {
            InitializeComponent();
            Noti = new NotifyIcon();
            Noti.Visible = true;
            Noti.Icon = new Icon("C:\\Users\\Admin\\Downloads\\419660.ico");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            EditProduc pr = new EditProduc();
            pr.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var we = "Pizaa doble queso 100RD$";
            Noti.ShowBalloonTip(10000,$"{we} Esteproducto esta por acabar","Restaurante@hotmail.com",ToolTipIcon.Info);
         
        }
    }
}
