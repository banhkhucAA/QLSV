namespace QLSV_3layers
{
    partial class frmcapnhat_thembm
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
            this.txtMaBoMon = new System.Windows.Forms.TextBox();
            this.txtTenBoMon = new System.Windows.Forms.TextBox();
            this.lbMaBoMon = new System.Windows.Forms.Label();
            this.lbTenBoMon = new System.Windows.Forms.Label();
            this.lbMaKhoa_vien = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbMaKhoa_Vien = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMaBoMon
            // 
            this.txtMaBoMon.Location = new System.Drawing.Point(118, 51);
            this.txtMaBoMon.Name = "txtMaBoMon";
            this.txtMaBoMon.Size = new System.Drawing.Size(179, 22);
            this.txtMaBoMon.TabIndex = 0;
            // 
            // txtTenBoMon
            // 
            this.txtTenBoMon.Location = new System.Drawing.Point(118, 105);
            this.txtTenBoMon.Name = "txtTenBoMon";
            this.txtTenBoMon.Size = new System.Drawing.Size(179, 22);
            this.txtTenBoMon.TabIndex = 1;
            // 
            // lbMaBoMon
            // 
            this.lbMaBoMon.AutoSize = true;
            this.lbMaBoMon.Location = new System.Drawing.Point(12, 51);
            this.lbMaBoMon.Name = "lbMaBoMon";
            this.lbMaBoMon.Size = new System.Drawing.Size(78, 17);
            this.lbMaBoMon.TabIndex = 3;
            this.lbMaBoMon.Text = "Mã bộ môn";
            // 
            // lbTenBoMon
            // 
            this.lbTenBoMon.AutoSize = true;
            this.lbTenBoMon.Location = new System.Drawing.Point(12, 105);
            this.lbTenBoMon.Name = "lbTenBoMon";
            this.lbTenBoMon.Size = new System.Drawing.Size(84, 17);
            this.lbTenBoMon.TabIndex = 4;
            this.lbTenBoMon.Text = "Tên bộ môn";
            // 
            // lbMaKhoa_vien
            // 
            this.lbMaKhoa_vien.AutoSize = true;
            this.lbMaKhoa_vien.Location = new System.Drawing.Point(12, 163);
            this.lbMaKhoa_vien.Name = "lbMaKhoa_vien";
            this.lbMaKhoa_vien.Size = new System.Drawing.Size(101, 17);
            this.lbMaKhoa_vien.TabIndex = 5;
            this.lbMaKhoa_vien.Text = "Mã khoa - viện";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(359, 42);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 63);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(359, 122);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 63);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbMaKhoa_Vien
            // 
            this.cbbMaKhoa_Vien.FormattingEnabled = true;
            this.cbbMaKhoa_Vien.Location = new System.Drawing.Point(118, 163);
            this.cbbMaKhoa_Vien.Name = "cbbMaKhoa_Vien";
            this.cbbMaKhoa_Vien.Size = new System.Drawing.Size(179, 24);
            this.cbbMaKhoa_Vien.TabIndex = 8;
            // 
            // frmcapnhat_thembm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 227);
            this.Controls.Add(this.cbbMaKhoa_Vien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbMaKhoa_vien);
            this.Controls.Add(this.lbTenBoMon);
            this.Controls.Add(this.lbMaBoMon);
            this.Controls.Add(this.txtTenBoMon);
            this.Controls.Add(this.txtMaBoMon);
            this.Name = "frmcapnhat_thembm";
            this.Text = "frmcapnhat_thembm";
            this.Load += new System.EventHandler(this.frmcapnhat_thembm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaBoMon;
        private System.Windows.Forms.TextBox txtTenBoMon;
        private System.Windows.Forms.Label lbMaBoMon;
        private System.Windows.Forms.Label lbTenBoMon;
        private System.Windows.Forms.Label lbMaKhoa_vien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbMaKhoa_Vien;
    }
}