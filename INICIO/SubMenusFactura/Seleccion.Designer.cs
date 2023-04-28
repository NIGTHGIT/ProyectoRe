
namespace INICIO.SubMenusFactura
{
    partial class Seleccion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Control = new System.Windows.Forms.FlowLayoutPanel();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Subtotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CodigoN = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Precio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Descrip = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.NombreProud = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.yes = new System.Windows.Forms.RadioButton();
            this.not = new System.Windows.Forms.RadioButton();
            this.PanelDatosCliente = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.ApellidoPerson = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NombrePerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.PanelDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Control);
            this.panel1.Controls.Add(this.DataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 518);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria";
            // 
            // Control
            // 
            this.Control.AutoScroll = true;
            this.Control.Location = new System.Drawing.Point(22, 44);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(259, 202);
            this.Control.TabIndex = 4;
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AllowUserToOrderColumns = true;
            this.DataView.BackgroundColor = System.Drawing.Color.Teal;
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(12, 252);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.Size = new System.Drawing.Size(279, 254);
            this.DataView.TabIndex = 3;
            this.DataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.PanelDatosCliente);
            this.panel2.Controls.Add(this.not);
            this.panel2.Controls.Add(this.yes);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.Subtotal);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CodigoN);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Descrip);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.Numero);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.NombreProud);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(309, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 518);
            this.panel2.TabIndex = 1;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.BackColor = System.Drawing.Color.Transparent;
            this.Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Subtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Subtotal.Location = new System.Drawing.Point(273, 214);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(101, 17);
            this.Subtotal.TabIndex = 29;
            this.Subtotal.Text = "Sub Total = 0$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Total a pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(462, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cantidad disponible: 3";
            // 
            // CodigoN
            // 
            this.CodigoN.AutoSize = true;
            this.CodigoN.BackColor = System.Drawing.Color.Transparent;
            this.CodigoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CodigoN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CodigoN.Location = new System.Drawing.Point(30, 278);
            this.CodigoN.Name = "CodigoN";
            this.CodigoN.Size = new System.Drawing.Size(100, 20);
            this.CodigoN.TabIndex = 26;
            this.CodigoN.Text = "NO-00021-1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(30, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Numero de orden";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Precio);
            this.panel3.Location = new System.Drawing.Point(22, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 128);
            this.panel3.TabIndex = 24;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Precio.ForeColor = System.Drawing.Color.Honeydew;
            this.Precio.Location = new System.Drawing.Point(78, 53);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(29, 31);
            this.Precio.TabIndex = 19;
            this.Precio.Text = "0";
            this.Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(273, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descripcion";
            // 
            // Descrip
            // 
            this.Descrip.Location = new System.Drawing.Point(276, 121);
            this.Descrip.Name = "Descrip";
            this.Descrip.Size = new System.Drawing.Size(364, 83);
            this.Descrip.TabIndex = 13;
            this.Descrip.Text = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(289, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(351, 175);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(552, 94);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(82, 20);
            this.Numero.TabIndex = 10;
            this.Numero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numero.ValueChanged += new System.EventHandler(this.Numero_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(554, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(273, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de producto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(557, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NombreProud
            // 
            this.NombreProud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NombreProud.Location = new System.Drawing.Point(276, 64);
            this.NombreProud.Multiline = true;
            this.NombreProud.Name = "NombreProud";
            this.NombreProud.ReadOnly = true;
            this.NombreProud.Size = new System.Drawing.Size(142, 27);
            this.NombreProud.TabIndex = 0;
            this.NombreProud.TextChanged += new System.EventHandler(this.NombreProud_TextChanged);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Location = new System.Drawing.Point(19, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 17);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cancelar todo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yes.Location = new System.Drawing.Point(33, 64);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(37, 17);
            this.yes.TabIndex = 31;
            this.yes.TabStop = true;
            this.yes.Text = "Si ";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.CheckedChanged += new System.EventHandler(this.yes_CheckedChanged);
            // 
            // not
            // 
            this.not.AutoSize = true;
            this.not.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.not.Location = new System.Drawing.Point(78, 64);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(39, 17);
            this.not.TabIndex = 32;
            this.not.TabStop = true;
            this.not.Text = "No";
            this.not.UseVisualStyleBackColor = true;
            this.not.CheckedChanged += new System.EventHandler(this.not_CheckedChanged);
            // 
            // PanelDatosCliente
            // 
            this.PanelDatosCliente.Controls.Add(this.label10);
            this.PanelDatosCliente.Controls.Add(this.ApellidoPerson);
            this.PanelDatosCliente.Controls.Add(this.label9);
            this.PanelDatosCliente.Controls.Add(this.NombrePerson);
            this.PanelDatosCliente.Controls.Add(this.label3);
            this.PanelDatosCliente.Location = new System.Drawing.Point(18, 87);
            this.PanelDatosCliente.Name = "PanelDatosCliente";
            this.PanelDatosCliente.Size = new System.Drawing.Size(195, 165);
            this.PanelDatosCliente.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Apellido";
            // 
            // ApellidoPerson
            // 
            this.ApellidoPerson.Location = new System.Drawing.Point(15, 140);
            this.ApellidoPerson.Name = "ApellidoPerson";
            this.ApellidoPerson.Size = new System.Drawing.Size(129, 20);
            this.ApellidoPerson.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nombre";
            // 
            // NombrePerson
            // 
            this.NombrePerson.Location = new System.Drawing.Point(15, 69);
            this.NombrePerson.Name = "NombrePerson";
            this.NombrePerson.Size = new System.Drawing.Size(129, 20);
            this.NombrePerson.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Datos del cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(31, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Habilitar";
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1002, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion";
            this.Text = "Seleccion";
            this.Load += new System.EventHandler(this.Seleccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.PanelDatosCliente.ResumeLayout(false);
            this.PanelDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NombreProud;
        private System.Windows.Forms.NumericUpDown Numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel Control;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Descrip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label CodigoN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelDatosCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ApellidoPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NombrePerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton not;
        private System.Windows.Forms.RadioButton yes;
    }
}