
namespace INICIO.SubmMenuAlamcen.Stok
{
    partial class ViewStok
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
            this.Conte = new System.Windows.Forms.RichTextBox();
            this.Fecha = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Modific = new System.Windows.Forms.PictureBox();
            this.PO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modific)).BeginInit();
            this.SuspendLayout();
            // 
            // Conte
            // 
            this.Conte.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Conte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Conte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Conte.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Conte.Location = new System.Drawing.Point(17, 135);
            this.Conte.Name = "Conte";
            this.Conte.Size = new System.Drawing.Size(455, 216);
            this.Conte.TabIndex = 1;
            this.Conte.Text = "Sin quilos de mas";
            this.Conte.TextChanged += new System.EventHandler(this.Conte_TextChanged);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Fecha.LinkColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(12, 79);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(276, 24);
            this.Fecha.TabIndex = 2;
            this.Fecha.TabStop = true;
            this.Fecha.Text = "Ultima actualizacion { 06/05/23  )";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::INICIO.Properties.Resources.Delete_Icon_PNG_HD_Quality;
            this.pictureBox1.Location = new System.Drawing.Point(99, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Modific
            // 
            this.Modific.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modific.Enabled = false;
            this.Modific.Image = global::INICIO.Properties.Resources._1055085_compose_edit_paper_pencil_write_icon;
            this.Modific.Location = new System.Drawing.Point(288, 372);
            this.Modific.Name = "Modific";
            this.Modific.Size = new System.Drawing.Size(74, 56);
            this.Modific.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Modific.TabIndex = 5;
            this.Modific.TabStop = false;
            this.Modific.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PO
            // 
            this.PO.AutoSize = true;
            this.PO.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.PO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PO.Location = new System.Drawing.Point(177, 24);
            this.PO.Name = "PO";
            this.PO.Size = new System.Drawing.Size(67, 29);
            this.PO.TabIndex = 6;
            this.PO.Text = "Stok ";
            // 
            // ViewStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.PO);
            this.Controls.Add(this.Modific);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Conte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewStok";
            this.Text = "ViewStok";
            this.Load += new System.EventHandler(this.ViewStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modific)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Conte;
        private System.Windows.Forms.LinkLabel Fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Modific;
        private System.Windows.Forms.Label PO;
    }
}