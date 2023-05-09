
namespace INICIO
{
    partial class IA
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
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chatbotOutputLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(43, 63);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(432, 20);
            this.userInputTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chatbotOutputLabel
            // 
            this.chatbotOutputLabel.AutoSize = true;
            this.chatbotOutputLabel.Location = new System.Drawing.Point(201, 45);
            this.chatbotOutputLabel.Name = "chatbotOutputLabel";
            this.chatbotOutputLabel.Size = new System.Drawing.Size(114, 13);
            this.chatbotOutputLabel.TabIndex = 2;
            this.chatbotOutputLabel.Text = "Enque puedo ayudarle";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // IA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chatbotOutputLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userInputTextBox);
            this.Name = "IA";
            this.Text = "IA";
            this.Load += new System.EventHandler(this.IA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label chatbotOutputLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer;
    }
}