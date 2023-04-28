
namespace INICIO.SubMenusProducto
{
    partial class Consultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataViem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoSearh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.Eiminr = new System.Windows.Forms.Button();
            this.Modific = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataViem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataViem
            // 
            this.DataViem.BackgroundColor = System.Drawing.Color.Teal;
            this.DataViem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViem.Location = new System.Drawing.Point(12, 12);
            this.DataViem.Name = "DataViem";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViem.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViem.Size = new System.Drawing.Size(423, 444);
            this.DataViem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(548, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de producto";
            // 
            // CodigoSearh
            // 
            this.CodigoSearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.CodigoSearh.Location = new System.Drawing.Point(510, 78);
            this.CodigoSearh.Margin = new System.Windows.Forms.Padding(5);
            this.CodigoSearh.Multiline = true;
            this.CodigoSearh.Name = "CodigoSearh";
            this.CodigoSearh.Size = new System.Drawing.Size(175, 31);
            this.CodigoSearh.TabIndex = 2;
            this.CodigoSearh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(543, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.BackColor = System.Drawing.Color.DarkCyan;
            this.Mostrar.Enabled = false;
            this.Mostrar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.Mostrar.FlatAppearance.BorderSize = 2;
            this.Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mostrar.Location = new System.Drawing.Point(24, 87);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(98, 50);
            this.Mostrar.TabIndex = 4;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = false;
            this.Mostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Eiminr
            // 
            this.Eiminr.BackColor = System.Drawing.Color.DarkCyan;
            this.Eiminr.Enabled = false;
            this.Eiminr.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.Eiminr.FlatAppearance.BorderSize = 2;
            this.Eiminr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eiminr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Eiminr.Location = new System.Drawing.Point(24, 24);
            this.Eiminr.Name = "Eiminr";
            this.Eiminr.Size = new System.Drawing.Size(98, 49);
            this.Eiminr.TabIndex = 5;
            this.Eiminr.Text = "Eliminar";
            this.Eiminr.UseVisualStyleBackColor = false;
            this.Eiminr.Click += new System.EventHandler(this.button3_Click);
            // 
            // Modific
            // 
            this.Modific.BackColor = System.Drawing.Color.DarkCyan;
            this.Modific.Enabled = false;
            this.Modific.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Modific.FlatAppearance.BorderSize = 2;
            this.Modific.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modific.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Modific.Location = new System.Drawing.Point(128, 24);
            this.Modific.Name = "Modific";
            this.Modific.Size = new System.Drawing.Size(97, 47);
            this.Modific.TabIndex = 6;
            this.Modific.Text = "Modificar";
            this.Modific.UseVisualStyleBackColor = false;
            this.Modific.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(458, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nombre.Location = new System.Drawing.Point(458, 201);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(105, 20);
            this.Nombre.TabIndex = 8;
            this.Nombre.Text = "----------------";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.precio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.precio.Location = new System.Drawing.Point(540, 233);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(83, 18);
            this.precio.TabIndex = 11;
            this.precio.Text = "---------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(458, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio $:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Combo);
            this.panel1.Controls.Add(this.Mostrar);
            this.panel1.Controls.Add(this.Modific);
            this.panel1.Controls.Add(this.Eiminr);
            this.panel1.Location = new System.Drawing.Point(462, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 173);
            this.panel1.TabIndex = 12;
            // 
            // Combo
            // 
            this.Combo.FormattingEnabled = true;
            this.Combo.Items.AddRange(new object[] {
            "All"});
            this.Combo.Location = new System.Drawing.Point(126, 116);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(97, 21);
            this.Combo.TabIndex = 7;
            this.Combo.Text = "All";
            this.Combo.TextChanged += new System.EventHandler(this.Combo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(128, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filtrar por:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INICIO.Properties.Resources._6110741_black_hole_icon;
            this.pictureBox2.Location = new System.Drawing.Point(701, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources._968_9687047_descarga_estos_imgenes_de_cdigo_de_barras_png;
            this.pictureBox1.Location = new System.Drawing.Point(508, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(787, 467);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CodigoSearh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataViem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataViem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoSearh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button Eiminr;
        private System.Windows.Forms.Button Modific;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combo;
    }
}