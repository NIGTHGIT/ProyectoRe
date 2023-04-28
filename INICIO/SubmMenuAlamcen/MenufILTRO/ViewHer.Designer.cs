
namespace INICIO.SubmMenuAlamcen.MenufILTRO
{
    partial class ViewHer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Descrip = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ff = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PreicoXunidad = new System.Windows.Forms.TextBox();
            this.nes = new System.Windows.Forms.PictureBox();
            this.CantidadDispo = new System.Windows.Forms.Label();
            this.px = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.px)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources.flecha_correcta__1_;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Herramienta";
            // 
            // Name1
            // 
            this.Name1.Enabled = false;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Name1.Location = new System.Drawing.Point(51, 94);
            this.Name1.Multiline = true;
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(292, 31);
            this.Name1.TabIndex = 5;
            this.Name1.Text = "Cuchara";
            // 
            // Descrip
            // 
            this.Descrip.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Descrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Descrip.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Descrip.Location = new System.Drawing.Point(51, 270);
            this.Descrip.Name = "Descrip";
            this.Descrip.Size = new System.Drawing.Size(292, 206);
            this.Descrip.TabIndex = 2;
            this.Descrip.Tag = "";
            this.Descrip.Text = "HOy me levante";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(53, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(242, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ff.Location = new System.Drawing.Point(48, 194);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(84, 17);
            this.ff.TabIndex = 10;
            this.ff.Text = "Precio Total";
            // 
            // Precio
            // 
            this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Precio.Location = new System.Drawing.Point(51, 214);
            this.Precio.Multiline = true;
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(292, 31);
            this.Precio.TabIndex = 9;
            this.Precio.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(233, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio X Unidad";
            // 
            // PreicoXunidad
            // 
            this.PreicoXunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PreicoXunidad.Location = new System.Drawing.Point(211, 157);
            this.PreicoXunidad.Multiline = true;
            this.PreicoXunidad.Name = "PreicoXunidad";
            this.PreicoXunidad.Size = new System.Drawing.Size(132, 20);
            this.PreicoXunidad.TabIndex = 12;
            this.PreicoXunidad.Text = "0.0";
            this.PreicoXunidad.TextChanged += new System.EventHandler(this.PreicoXunidad_TextChanged);
            // 
            // nes
            // 
            this.nes.Image = global::INICIO.Properties.Resources.flecha_correcta__1_;
            this.nes.Location = new System.Drawing.Point(51, 156);
            this.nes.Name = "nes";
            this.nes.Size = new System.Drawing.Size(43, 35);
            this.nes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nes.TabIndex = 13;
            this.nes.TabStop = false;
            this.nes.Click += new System.EventHandler(this.nes_Click);
            // 
            // CantidadDispo
            // 
            this.CantidadDispo.AutoSize = true;
            this.CantidadDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CantidadDispo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CantidadDispo.Location = new System.Drawing.Point(100, 165);
            this.CantidadDispo.Name = "CantidadDispo";
            this.CantidadDispo.Size = new System.Drawing.Size(16, 17);
            this.CantidadDispo.TabIndex = 15;
            this.CantidadDispo.Text = "0";
            // 
            // px
            // 
            this.px.Image = global::INICIO.Properties.Resources.flecha_correcta;
            this.px.Location = new System.Drawing.Point(122, 156);
            this.px.Name = "px";
            this.px.Size = new System.Drawing.Size(43, 35);
            this.px.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.px.TabIndex = 16;
            this.px.TabStop = false;
            this.px.Click += new System.EventHandler(this.px_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(48, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad disponible";
            // 
            // ViewHer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(384, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.px);
            this.Controls.Add(this.CantidadDispo);
            this.Controls.Add(this.nes);
            this.Controls.Add(this.PreicoXunidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Descrip);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewHer";
            this.Text = "ViewHer";
            this.Load += new System.EventHandler(this.ViewHer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.px)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.RichTextBox Descrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PreicoXunidad;
        private System.Windows.Forms.PictureBox nes;
        private System.Windows.Forms.Label CantidadDispo;
        private System.Windows.Forms.PictureBox px;
        private System.Windows.Forms.Label label4;
    }
}