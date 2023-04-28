
namespace INICIO.subMANUSConfigura.MenusInfo
{
    partial class ModifycEmpresa
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Dirrecion = new System.Windows.Forms.TextBox();
            this.Fech = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Decrip = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MOdifu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(30, 85);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(114, 20);
            this.Nombre.TabIndex = 0;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(30, 134);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(114, 20);
            this.Correo.TabIndex = 1;
            // 
            // Dirrecion
            // 
            this.Dirrecion.Location = new System.Drawing.Point(30, 189);
            this.Dirrecion.Name = "Dirrecion";
            this.Dirrecion.Size = new System.Drawing.Size(114, 20);
            this.Dirrecion.TabIndex = 2;
            // 
            // Fech
            // 
            this.Fech.Location = new System.Drawing.Point(30, 242);
            this.Fech.Name = "Fech";
            this.Fech.Size = new System.Drawing.Size(114, 20);
            this.Fech.TabIndex = 3;
            this.Fech.Value = new System.DateTime(2023, 3, 21, 13, 5, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de la empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(26, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de crecion";
            // 
            // Decrip
            // 
            this.Decrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Decrip.Location = new System.Drawing.Point(25, 296);
            this.Decrip.Name = "Decrip";
            this.Decrip.Size = new System.Drawing.Size(246, 89);
            this.Decrip.TabIndex = 8;
            this.Decrip.Text = "";
            this.Decrip.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(26, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Informcion extra";
            // 
            // MOdifu
            // 
            this.MOdifu.BackColor = System.Drawing.Color.Teal;
            this.MOdifu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MOdifu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MOdifu.ForeColor = System.Drawing.Color.White;
            this.MOdifu.Location = new System.Drawing.Point(93, 405);
            this.MOdifu.Name = "MOdifu";
            this.MOdifu.Size = new System.Drawing.Size(94, 33);
            this.MOdifu.TabIndex = 10;
            this.MOdifu.Text = "Modicar";
            this.MOdifu.UseVisualStyleBackColor = false;
            this.MOdifu.Click += new System.EventHandler(this.MOdifu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources._10285440_delete_cross_cancel_button_decline_icon;
            this.pictureBox1.Location = new System.Drawing.Point(249, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ModifycEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MOdifu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Decrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fech);
            this.Controls.Add(this.Dirrecion);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifycEmpresa";
            this.Text = "ModifycEmpresa";
            this.Load += new System.EventHandler(this.ModifycEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Dirrecion;
        private System.Windows.Forms.DateTimePicker Fech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Decrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MOdifu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}