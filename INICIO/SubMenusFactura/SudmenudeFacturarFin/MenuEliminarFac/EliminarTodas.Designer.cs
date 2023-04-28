
namespace INICIO.SubMenusFactura.SudmenudeFacturarFin.MenuEliminarFac
{
    partial class EliminarTodas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hacer copia de seguridad";
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(318, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eliminar  todas la facturas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.AutoSize = true;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aceptar.Location = new System.Drawing.Point(305, 117);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(184, 21);
            this.Aceptar.TabIndex = 8;
            this.Aceptar.Text = "Aceptas la consecuencia";
            this.Aceptar.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(293, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(214, 98);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Al eliminar estas facturas no hara vueltas atras, al menos que tengas una copia d" +
    "e seguridad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "No disponible ";
            // 
            // EliminarTodas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(519, 232);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarTodas";
            this.Text = "EliminarTodas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox Aceptar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}