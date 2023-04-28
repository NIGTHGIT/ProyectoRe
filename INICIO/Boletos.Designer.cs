
namespace INICIO
{
    partial class Boletos
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
            this.txtValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.AutoSize = true;
            this.txtValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValor.Location = new System.Drawing.Point(476, 157);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(35, 13);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "label1";
            this.txtValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // Boletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValor);
            this.Name = "Boletos";
            this.Text = "Boletos";
            this.Load += new System.EventHandler(this.Boletos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtValor;
    }
}