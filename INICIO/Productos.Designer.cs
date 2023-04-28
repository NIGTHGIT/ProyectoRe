
namespace INICIO
{
    partial class Productos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.w = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Panelmadre = new System.Windows.Forms.Panel();
            this.FEHCA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.max = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.Panelmadre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.w.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.w.Location = new System.Drawing.Point(149, 34);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(332, 31);
            this.w.TabIndex = 1;
            this.w.Text = "Configuracion de producto";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.linkLabel2.Location = new System.Drawing.Point(46, 399);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 16);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Volver al inicio";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Panelmadre
            // 
            this.Panelmadre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panelmadre.Controls.Add(this.pictureBox2);
            this.Panelmadre.Location = new System.Drawing.Point(217, 86);
            this.Panelmadre.Name = "Panelmadre";
            this.Panelmadre.Size = new System.Drawing.Size(787, 467);
            this.Panelmadre.TabIndex = 20;
            // 
            // FEHCA
            // 
            this.FEHCA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FEHCA.AutoSize = true;
            this.FEHCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FEHCA.ForeColor = System.Drawing.Color.Firebrick;
            this.FEHCA.Location = new System.Drawing.Point(861, 59);
            this.FEHCA.Name = "FEHCA";
            this.FEHCA.Size = new System.Drawing.Size(34, 24);
            this.FEHCA.TabIndex = 21;
            this.FEHCA.Text = "----";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 75);
            this.button1.TabIndex = 22;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(14, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 65);
            this.button2.TabIndex = 23;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 415);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.min);
            this.panel2.Controls.Add(this.max);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 31);
            this.panel2.TabIndex = 28;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Productos_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources._1274382_box_product_delivery_icon;
            this.pictureBox1.Location = new System.Drawing.Point(38, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.Image = global::INICIO.Properties.Resources._9809759_minimize_button_website_interface_app_icon;
            this.min.Location = new System.Drawing.Point(956, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(33, 26);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 27;
            this.min.TabStop = false;
            this.min.Visible = false;
            this.min.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.Image = global::INICIO.Properties.Resources._10285518_maximize_button_view_window_full_icon;
            this.max.Location = new System.Drawing.Point(956, 3);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(33, 26);
            this.max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.max.TabIndex = 26;
            this.max.TabStop = false;
            this.max.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INICIO.Properties.Resources.AdobeStock_199693074_Preview;
            this.pictureBox2.Location = new System.Drawing.Point(-26, -27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(827, 579);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FEHCA);
            this.Controls.Add(this.Panelmadre);
            this.Controls.Add(this.w);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Productos_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.Panelmadre.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel Panelmadre;
        private System.Windows.Forms.Label FEHCA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox max;
    }
}