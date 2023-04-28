
namespace INICIO
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.But1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PanedlMadre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanedlMadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // But1
            // 
            this.But1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.But1.Enabled = false;
            this.But1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.But1.FlatAppearance.BorderSize = 2;
            this.But1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.But1.Location = new System.Drawing.Point(121, 18);
            this.But1.Name = "But1";
            this.But1.Size = new System.Drawing.Size(146, 45);
            this.But1.TabIndex = 0;
            this.But1.Text = "Seleccionar";
            this.But1.UseVisualStyleBackColor = false;
            this.But1.Click += new System.EventHandler(this.But1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(286, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Envio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.But1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 79);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::INICIO.Properties.Resources._10285440_delete_cross_cancel_button_decline_icon;
            this.pictureBox3.Location = new System.Drawing.Point(943, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INICIO.Properties.Resources.vender_empresa;
            this.pictureBox2.Location = new System.Drawing.Point(24, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(778, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "Administrar facturas";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(697, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PanedlMadre
            // 
            this.PanedlMadre.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanedlMadre.Controls.Add(this.pictureBox1);
            this.PanedlMadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanedlMadre.Location = new System.Drawing.Point(0, 79);
            this.PanedlMadre.Name = "PanedlMadre";
            this.PanedlMadre.Size = new System.Drawing.Size(1002, 518);
            this.PanedlMadre.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources.vender_empresa;
            this.pictureBox1.Location = new System.Drawing.Point(144, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1002, 597);
            this.Controls.Add(this.PanedlMadre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanedlMadre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Panel PanedlMadre;
    }
}