
namespace INICIO.SubmMenuAlamcen
{
    partial class herramientasAlma
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanedlMadre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Paneel1 = new System.Windows.Forms.Panel();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanedlMadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Paneel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(36, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Areas de herramienta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 476);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INICIO.Properties.Resources.cerrar_con_llave__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(33, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanedlMadre);
            this.panel2.Controls.Add(this.Paneel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 476);
            this.panel2.TabIndex = 3;
            // 
            // PanedlMadre
            // 
            this.PanedlMadre.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanedlMadre.Controls.Add(this.pictureBox1);
            this.PanedlMadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanedlMadre.Location = new System.Drawing.Point(204, 0);
            this.PanedlMadre.Name = "PanedlMadre";
            this.PanedlMadre.Size = new System.Drawing.Size(530, 476);
            this.PanedlMadre.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources.gestion_web;
            this.pictureBox1.Location = new System.Drawing.Point(78, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Paneel1
            // 
            this.Paneel1.AutoScroll = true;
            this.Paneel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.Paneel1.Controls.Add(this.flow);
            this.Paneel1.Controls.Add(this.label1);
            this.Paneel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Paneel1.Location = new System.Drawing.Point(0, 0);
            this.Paneel1.Name = "Paneel1";
            this.Paneel1.Size = new System.Drawing.Size(204, 476);
            this.Paneel1.TabIndex = 0;
            // 
            // flow
            // 
            this.flow.AutoScroll = true;
            this.flow.Location = new System.Drawing.Point(18, 77);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(180, 359);
            this.flow.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(76, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Areas";
            // 
            // herramientasAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1002, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "herramientasAlma";
            this.Text = "herramientasAlma";
            this.Load += new System.EventHandler(this.herramientasAlma_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PanedlMadre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Paneel1.ResumeLayout(false);
            this.Paneel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanedlMadre;
        private System.Windows.Forms.Panel Paneel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flow;
    }
}