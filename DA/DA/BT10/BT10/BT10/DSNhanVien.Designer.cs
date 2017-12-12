namespace BT10
{
    partial class DSNhanVien
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
            this.ltvNhanVien = new System.Windows.Forms.ListView();
            this.TênĐăngNhập = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ltvNhanVien
            // 
            this.ltvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TênĐăngNhập,
            this.Nickname});
            this.ltvNhanVien.Location = new System.Drawing.Point(65, 83);
            this.ltvNhanVien.Name = "ltvNhanVien";
            this.ltvNhanVien.Size = new System.Drawing.Size(487, 136);
            this.ltvNhanVien.TabIndex = 0;
            this.ltvNhanVien.UseCompatibleStateImageBehavior = false;
            this.ltvNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // TênĐăngNhập
            // 
            this.TênĐăngNhập.Text = "TenDangNhap";
            // 
            // Nickname
            // 
            this.Nickname.Text = "Nickname";
            // 
            // DSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 261);
            this.Controls.Add(this.ltvNhanVien);
            this.Name = "DSNhanVien";
            this.Text = "DSNhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvNhanVien;
        private System.Windows.Forms.ColumnHeader TênĐăngNhập;
        private System.Windows.Forms.ColumnHeader Nickname;
    }
}