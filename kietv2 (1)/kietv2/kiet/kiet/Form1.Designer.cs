namespace kiet
{
    partial class Form1
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
            this.BT1login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT1login
            // 
            this.BT1login.Location = new System.Drawing.Point(65, 182);
            this.BT1login.Name = "BT1login";
            this.BT1login.Size = new System.Drawing.Size(105, 42);
            this.BT1login.TabIndex = 0;
            this.BT1login.Text = "Đăng nhập";
            this.BT1login.UseVisualStyleBackColor = true;
            this.BT1login.Click += new System.EventHandler(this.BT1login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng kí";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT1login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT1login;
        private System.Windows.Forms.Button button1;
    }
}

