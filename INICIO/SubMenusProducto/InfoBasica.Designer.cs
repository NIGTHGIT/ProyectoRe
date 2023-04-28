
namespace INICIO.SubMenusProducto
{
    partial class InfoBasica
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriaP = new System.Windows.Forms.ComboBox();
            this.PesoN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigoTex = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClasifiP = new System.Windows.Forms.ComboBox();
            this.PrecioP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaActual = new System.Windows.Forms.Label();
            this.DescripcionP = new System.Windows.Forms.RichTextBox();
            this.Count = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(563, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Peso neto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del platillo";
            // 
            // NombreP
            // 
            this.NombreP.Location = new System.Drawing.Point(20, 51);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(150, 20);
            this.NombreP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(194, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(380, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clasificacion";
            // 
            // CategoriaP
            // 
            this.CategoriaP.FormattingEnabled = true;
            this.CategoriaP.Location = new System.Drawing.Point(190, 50);
            this.CategoriaP.Name = "CategoriaP";
            this.CategoriaP.Size = new System.Drawing.Size(180, 21);
            this.CategoriaP.TabIndex = 6;
            // 
            // PesoN
            // 
            this.PesoN.Location = new System.Drawing.Point(566, 51);
            this.PesoN.Name = "PesoN";
            this.PesoN.Size = new System.Drawing.Size(161, 20);
            this.PesoN.TabIndex = 10;
            this.PesoN.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo:";
            // 
            // CodigoTex
            // 
            this.CodigoTex.Location = new System.Drawing.Point(20, 121);
            this.CodigoTex.Name = "CodigoTex";
            this.CodigoTex.ReadOnly = true;
            this.CodigoTex.Size = new System.Drawing.Size(176, 20);
            this.CodigoTex.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(202, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClasifiP
            // 
            this.ClasifiP.FormattingEnabled = true;
            this.ClasifiP.Items.AddRange(new object[] {
            "Clasico",
            "Estandar",
            "Premium"});
            this.ClasifiP.Location = new System.Drawing.Point(383, 50);
            this.ClasifiP.Name = "ClasifiP";
            this.ClasifiP.Size = new System.Drawing.Size(164, 21);
            this.ClasifiP.TabIndex = 15;
            // 
            // PrecioP
            // 
            this.PrecioP.Location = new System.Drawing.Point(269, 120);
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.Size = new System.Drawing.Size(188, 20);
            this.PrecioP.TabIndex = 18;
            this.PrecioP.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(266, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Precio del producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(627, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "( g )";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(310, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(67, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(472, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha que se agrego";
            // 
            // FechaActual
            // 
            this.FechaActual.AutoSize = true;
            this.FechaActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FechaActual.Location = new System.Drawing.Point(472, 129);
            this.FechaActual.Name = "FechaActual";
            this.FechaActual.Size = new System.Drawing.Size(52, 13);
            this.FechaActual.TabIndex = 23;
            this.FechaActual.Text = "---------------";
            // 
            // DescripcionP
            // 
            this.DescripcionP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripcionP.Location = new System.Drawing.Point(124, 231);
            this.DescripcionP.Name = "DescripcionP";
            this.DescripcionP.Size = new System.Drawing.Size(497, 159);
            this.DescripcionP.TabIndex = 24;
            this.DescripcionP.Text = "";
            this.DescripcionP.TextChanged += new System.EventHandler(this.DescripcionP_TextChanged);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.ForeColor = System.Drawing.Color.Lime;
            this.Count.Location = new System.Drawing.Point(640, 371);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(13, 13);
            this.Count.TabIndex = 25;
            this.Count.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(668, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "/ 500";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumTurquoise;
            this.linkLabel1.Location = new System.Drawing.Point(120, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 22);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copiar!!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // InfoBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(787, 467);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.DescripcionP);
            this.Controls.Add(this.FechaActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PrecioP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClasifiP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CodigoTex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PesoN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoriaP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoBasica";
            this.Text = "InfoBasica";
            this.Load += new System.EventHandler(this.InfoBasica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoriaP;
        private System.Windows.Forms.TextBox PesoN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox CodigoTex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ClasifiP;
        private System.Windows.Forms.TextBox PrecioP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FechaActual;
        private System.Windows.Forms.RichTextBox DescripcionP;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}