﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INICIO.SubmMenuAlamcen.ProducListo
{
    public partial class EditProduc : Form
    {
        public EditProduc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private int i;
        private void Min()
        {
            i = int.Parse(Can.Text);
            if (i == 0) {
                Can.Text = 0.ToString();
                i = 0;
            }
            i--;
            Can.Text = i.ToString();
        }
        private void Max() {
            i = int.Parse(Can.Text);
            i++;
            Can.Text = i.ToString();
        }
        private void min_Click(object sender, EventArgs e)
        {
            Min();
            guardar();

        }

        INICIO.ConexionSQ.Conexion CON = new ConexionSQ.Conexion();

        private void guardar() {
            Gur.ForeColor = Color.Red;
            SqlCommand comadno = new SqlCommand($"UPDATE ProducHechos set CantidadDispo = {int.Parse(Can.Text)}", CON.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            ejecutar.Read();
            Gur.ForeColor = Color.White;

            

        }
        private void max_Click(object sender, EventArgs e)
        {
            Max();

            guardar();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Gur.ForeColor = Color.Red;
            SqlCommand comadno = new SqlCommand($"DELETE ProducHechos where ID = 2", CON.Conexifon());
            SqlDataReader ejecutar = comadno.ExecuteReader();
            ejecutar.Read();
            Gur.ForeColor = Color.White;
        }
    }
}
