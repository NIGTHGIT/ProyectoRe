
namespace INICIO.SubMenusFactura.SudmenudeFacturarFin.MenuEliminarFac
{
    partial class EliminarUna
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
            this.Norden = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Norden
            // 
            this.Norden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Norden.Location = new System.Drawing.Point(91, 53);
            this.Norden.Multiline = true;
            this.Norden.Name = "Norden";
            this.Norden.Size = new System.Drawing.Size(326, 35);
            this.Norden.TabIndex = 0;
            this.Norden.Text = "NO-";
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(171, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eliminar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Instroduzca su numero de orden";
            // 
            // Aceptar
            // 
            this.Aceptar.AutoSize = true;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aceptar.Location = new System.Drawing.Point(41, 134);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(184, 21);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "Aceptas la consecuencia";
            this.Aceptar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Al eliminar esta factura no tendra reversion";
            // 
            // EliminarUna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(519, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Norden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarUna";
            this.Text = "EliminarUna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Norden;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Aceptar;
        private System.Windows.Forms.Label label2;
    }
}