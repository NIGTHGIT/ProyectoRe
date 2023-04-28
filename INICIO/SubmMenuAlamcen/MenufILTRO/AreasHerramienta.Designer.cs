
namespace INICIO.SubmMenuAlamcen.MenufILTRO
{
    partial class AreasHerramienta
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Areaname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pANEL111 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pANEL111.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador de Area";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Areaname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(106, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 55);
            this.panel1.TabIndex = 2;
            // 
            // Areaname
            // 
            this.Areaname.Location = new System.Drawing.Point(3, 15);
            this.Areaname.Multiline = true;
            this.Areaname.Name = "Areaname";
            this.Areaname.Size = new System.Drawing.Size(226, 32);
            this.Areaname.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources.Londres;
            this.pictureBox1.Location = new System.Drawing.Point(292, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(109, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nomber de Area";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pANEL111
            // 
            this.pANEL111.Controls.Add(this.panel2);
            this.pANEL111.Location = new System.Drawing.Point(109, 164);
            this.pANEL111.Name = "pANEL111";
            this.pANEL111.Size = new System.Drawing.Size(336, 256);
            this.pANEL111.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 39);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INICIO.Properties.Resources.Delete_Icon_PNG_HD_Quality;
            this.pictureBox2.Location = new System.Drawing.Point(289, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cocina";
            // 
            // AreasHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(530, 476);
            this.Controls.Add(this.pANEL111);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreasHerramienta";
            this.Text = "AreasHerramienta";
            this.Load += new System.EventHandler(this.AreasHerramienta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pANEL111.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Areaname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pANEL111;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}