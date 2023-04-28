using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using INICIO.ConexionSQ;
using System.Windows.Forms;

namespace INICIO.subMANUSConfigura
{
    public partial class ConfiguracionII : Form
    {
        public ConfiguracionII()
        {
            InitializeComponent();
        }

        //        Puesto de trabajo
        //Mesas
        //Categoria

        public void AbrirMenu(object hija)
        {
            if (this.panelM.Controls.Count > 0)
            {
                panelM.Controls.RemoveAt(0);
            }

            Form hijo = hija as Form;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            this.panelM.Controls.Add(hijo);
            this.panelM.Tag = hijo;
            hijo.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            AbrirMenu(new AreaAndMESA.MesaAmdArea1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirMenu(new AreaAndMESA.Categoria());
        }
    }

}

