
namespace INICIO.SubMenusFactura.SudmenudeFacturarFin
{
    partial class ViewFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.Codig = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Factura = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(108, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de orden";
            // 
            // Codig
            // 
            this.Codig.AutoSize = true;
            this.Codig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Codig.ForeColor = System.Drawing.Color.Aqua;
            this.Codig.Location = new System.Drawing.Point(121, 84);
            this.Codig.Name = "Codig";
            this.Codig.Size = new System.Drawing.Size(165, 25);
            this.Codig.TabIndex = 3;
            this.Codig.Text = "NO-23423423-1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources.flecha_correcta__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(26, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ver factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Factura
            // 
            this.Factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Factura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Factura.Location = new System.Drawing.Point(82, 222);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(240, 48);
            this.Factura.TabIndex = 6;
            this.Factura.Text = "Facturar";
            this.Factura.UseVisualStyleBackColor = true;
            this.Factura.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(240, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Imprimir cocina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ViewFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(406, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Codig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFactura";
            this.Text = "ViewFactura";
            this.Load += new System.EventHandler(this.ViewFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Codig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Factura;
        private System.Windows.Forms.Button button2;
    }
}