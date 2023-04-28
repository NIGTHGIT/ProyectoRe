
namespace INICIO.SubmMenuAlamcen.MenufILTRO
{
    partial class ViewHerramienta
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
            this.DataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.area3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(30, 170);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(436, 150);
            this.DataView.TabIndex = 0;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(129, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Herramientas para esta categoria";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INICIO.Properties.Resources.Londres;
            this.pictureBox2.Location = new System.Drawing.Point(193, 347);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INICIO.Properties.Resources.etiqueta;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // area3
            // 
            this.area3.AutoSize = true;
            this.area3.BackColor = System.Drawing.Color.Transparent;
            this.area3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.area3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.area3.Location = new System.Drawing.Point(364, 143);
            this.area3.Name = "area3";
            this.area3.Size = new System.Drawing.Size(44, 20);
            this.area3.TabIndex = 10;
            this.area3.Text = "Area";
            // 
            // ViewHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(514, 437);
            this.Controls.Add(this.area3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewHerramienta";
            this.Text = "ViewHerramienta";
            this.Load += new System.EventHandler(this.ViewHerramienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label area3;
    }
}