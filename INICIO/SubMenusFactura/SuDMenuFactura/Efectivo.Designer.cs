
namespace INICIO.SubMenusFactura.SuDMenuFactura
{
    partial class Efectivo
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
            this.MondoTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Descuen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Descuento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MontoPagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Devuelta = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.PrecioBruto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.MondoTotal);
            this.panel1.Location = new System.Drawing.Point(506, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 69);
            this.panel1.TabIndex = 0;
            // 
            // MondoTotal
            // 
            this.MondoTotal.AutoSize = true;
            this.MondoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.MondoTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MondoTotal.Location = new System.Drawing.Point(2, 18);
            this.MondoTotal.Name = "MondoTotal";
            this.MondoTotal.Size = new System.Drawing.Size(36, 39);
            this.MondoTotal.TabIndex = 0;
            this.MondoTotal.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Descuen);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Descuento);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 471);
            this.panel2.TabIndex = 1;
            // 
            // Descuen
            // 
            this.Descuen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Descuen.AutoSize = true;
            this.Descuen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Descuen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Descuen.Location = new System.Drawing.Point(190, 93);
            this.Descuen.Name = "Descuen";
            this.Descuen.Size = new System.Drawing.Size(28, 17);
            this.Descuen.TabIndex = 11;
            this.Descuen.Text = "0%";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(47, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descuento aplicado:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(177, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 325);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources._2331941;
            this.pictureBox1.Location = new System.Drawing.Point(31, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Descuento
            // 
            this.Descuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Descuento.FormattingEnabled = true;
            this.Descuento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Descuento.Location = new System.Drawing.Point(50, 49);
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(121, 21);
            this.Descuento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(47, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descuentos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(320, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto a pagar ($)";
            // 
            // MontoPagar
            // 
            this.MontoPagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MontoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.MontoPagar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MontoPagar.Location = new System.Drawing.Point(323, 170);
            this.MontoPagar.Multiline = true;
            this.MontoPagar.Name = "MontoPagar";
            this.MontoPagar.Size = new System.Drawing.Size(151, 31);
            this.MontoPagar.TabIndex = 8;
            this.MontoPagar.Text = "0.0";
            this.MontoPagar.TextChanged += new System.EventHandler(this.MontoPagar_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(506, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto a pagar total";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 13;
            this.comboBox2.Items.AddRange(new object[] {
            "DO"});
            this.comboBox2.Location = new System.Drawing.Point(323, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "DO";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(321, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de moneda";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(421, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Vender";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(321, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Devuelta";
            // 
            // Devuelta
            // 
            this.Devuelta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Devuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Devuelta.Location = new System.Drawing.Point(324, 235);
            this.Devuelta.Multiline = true;
            this.Devuelta.Name = "Devuelta";
            this.Devuelta.ReadOnly = true;
            this.Devuelta.Size = new System.Drawing.Size(150, 27);
            this.Devuelta.TabIndex = 15;
            this.Devuelta.Text = "0.0";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.PrecioBruto);
            this.panel4.Location = new System.Drawing.Point(507, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 33);
            this.panel4.TabIndex = 1;
            // 
            // PrecioBruto
            // 
            this.PrecioBruto.AutoSize = true;
            this.PrecioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.PrecioBruto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrecioBruto.Location = new System.Drawing.Point(3, 0);
            this.PrecioBruto.Name = "PrecioBruto";
            this.PrecioBruto.Size = new System.Drawing.Size(29, 31);
            this.PrecioBruto.TabIndex = 0;
            this.PrecioBruto.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(507, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Monto bruto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INICIO.Properties.Resources._1160515;
            this.pictureBox2.Location = new System.Drawing.Point(9, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Efectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(660, 471);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Devuelta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MontoPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Efectivo";
            this.Text = "Efectivo";
            this.Load += new System.EventHandler(this.Efectivo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MondoTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Descuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MontoPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Descuen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Devuelta;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label PrecioBruto;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}