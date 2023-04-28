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
    public partial class Boletos : Form
    {
        public string InformacionEnviada { get; set; }
        public Boletos()
        {
            InitializeComponent();
         

               

        }

      



        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Boletos_Load(object sender, EventArgs e)
        {
            
                // Asignar el valor de la propiedad InformacionEnviada al control TextBox txtValor
                txtValor.Text = InformacionEnviada;
            

        }
    }
}
