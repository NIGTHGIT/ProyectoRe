
namespace INICIO.SubMenusProducto
{
    partial class ModifyConsul
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
            this.Modific = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Pesoneo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClasifiP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Descip = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(86, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar";
            // 
            // Modific
            // 
            this.Modific.Location = new System.Drawing.Point(103, 407);
            this.Modific.Name = "Modific";
            this.Modific.Size = new System.Drawing.Size(75, 23);
            this.Modific.TabIndex = 1;
            this.Modific.Text = "Modificar";
            this.Modific.UseVisualStyleBackColor = true;
            this.Modific.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(24, 95);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(178, 20);
            this.Nombre.TabIndex = 2;
            // 
            // Pesoneo
            // 
            this.Pesoneo.Location = new System.Drawing.Point(24, 224);
            this.Pesoneo.Name = "Pesoneo";
            this.Pesoneo.Size = new System.Drawing.Size(178, 20);
            this.Pesoneo.TabIndex = 5;
            this.Pesoneo.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // ClasifiP
            // 
            this.ClasifiP.FormattingEnabled = true;
            this.ClasifiP.Items.AddRange(new object[] {
            "Clasico",
            "Estandar",
            "Premium"});
            this.ClasifiP.Location = new System.Drawing.Point(24, 183);
            this.ClasifiP.Name = "ClasifiP";
            this.ClasifiP.Size = new System.Drawing.Size(178, 21);
            this.ClasifiP.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Clasificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Peso neto ( g )";
            // 
            // Descip
            // 
            this.Descip.Location = new System.Drawing.Point(29, 281);
            this.Descip.Name = "Descip";
            this.Descip.Size = new System.Drawing.Size(221, 96);
            this.Descip.TabIndex = 19;
            this.Descip.Text = "";
            this.Descip.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descripcion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources._5353380;
            this.pictureBox1.Location = new System.Drawing.Point(208, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(15, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(205, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "/ 500";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.ForeColor = System.Drawing.Color.Black;
            this.Count.Location = new System.Drawing.Point(176, 380);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(13, 13);
            this.Count.TabIndex = 27;
            this.Count.Text = "0";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(24, 138);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(178, 20);
            this.Precio.TabIndex = 29;
            this.Precio.Text = "0.0";
            // 
            // ModifyConsul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 442);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Descip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClasifiP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pesoneo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Modific);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyConsul";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.ModifyConsul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Modific;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Pesoneo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClasifiP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Descip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.TextBox Precio;
    }
}