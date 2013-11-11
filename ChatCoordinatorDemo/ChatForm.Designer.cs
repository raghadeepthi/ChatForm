namespace ChatCoordinatorDemo
{
    partial class ChatForm
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
            this.txtRecieve = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecieve
            // 
            this.txtRecieve.Location = new System.Drawing.Point(12, 12);
            this.txtRecieve.Name = "txtRecieve";
            this.txtRecieve.Size = new System.Drawing.Size(260, 20);
            this.txtRecieve.TabIndex = 0;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 38);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(179, 20);
            this.txtSend.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(197, 38);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtRecieve);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecieve;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
    }
}

