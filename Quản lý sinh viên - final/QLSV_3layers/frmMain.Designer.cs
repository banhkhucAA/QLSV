namespace QLSV_3layers
{
    partial class frmMain
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopHocPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nganhHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngànhKhoaViệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTInCaNhanSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinCaNhanGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lichHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânGiáoViênGiảngDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachLopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bomontheokhoavientoolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Location = new System.Drawing.Point(0, 28);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1006, 428);
            this.pnlContent.TabIndex = 1;
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienToolStripMenuItem,
            this.giaoVienToolStripMenuItem,
            this.monHocToolStripMenuItem,
            this.lopHocPhanToolStripMenuItem,
            this.nganhHocToolStripMenuItem,
            this.ngànhKhoaViệnToolStripMenuItem,
            this.bomontheokhoavientoolstripmenuitem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.sinhVienToolStripMenuItem.Text = "Sinh viên";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // giaoVienToolStripMenuItem
            // 
            this.giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            this.giaoVienToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.giaoVienToolStripMenuItem.Text = "Giáo viên";
            this.giaoVienToolStripMenuItem.Click += new System.EventHandler(this.giaoVienToolStripMenuItem_Click);
            // 
            // monHocToolStripMenuItem
            // 
            this.monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            this.monHocToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.monHocToolStripMenuItem.Text = "Môn học";
            this.monHocToolStripMenuItem.Click += new System.EventHandler(this.monHocToolStripMenuItem_Click);
            // 
            // lopHocPhanToolStripMenuItem
            // 
            this.lopHocPhanToolStripMenuItem.Name = "lopHocPhanToolStripMenuItem";
            this.lopHocPhanToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.lopHocPhanToolStripMenuItem.Text = "Lớp học phần";
            this.lopHocPhanToolStripMenuItem.Click += new System.EventHandler(this.lopHocPhanToolStripMenuItem_Click);
            // 
            // nganhHocToolStripMenuItem
            // 
            this.nganhHocToolStripMenuItem.Name = "nganhHocToolStripMenuItem";
            this.nganhHocToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.nganhHocToolStripMenuItem.Text = "Lớp chuyên ngành";
            this.nganhHocToolStripMenuItem.Click += new System.EventHandler(this.nganhHocToolStripMenuItem_Click);
            // 
            // ngànhKhoaViệnToolStripMenuItem
            // 
            this.ngànhKhoaViệnToolStripMenuItem.Name = "ngànhKhoaViệnToolStripMenuItem";
            this.ngànhKhoaViệnToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.ngànhKhoaViệnToolStripMenuItem.Text = "Ngành/Khoa/Viện";
            this.ngànhKhoaViệnToolStripMenuItem.Click += new System.EventHandler(this.ngànhKhoaViệnToolStripMenuItem_Click);
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangKyToolStripMenuItem,
            this.traCuuDiemToolStripMenuItem,
            this.thongTInCaNhanSVToolStripMenuItem,
            this.thongTinCaNhanGVToolStripMenuItem,
            this.lichHocToolStripMenuItem,
            this.phânGiáoViênGiảngDạyToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // dangKyToolStripMenuItem
            // 
            this.dangKyToolStripMenuItem.Name = "dangKyToolStripMenuItem";
            this.dangKyToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.dangKyToolStripMenuItem.Text = "Đăng ký môn học";
            this.dangKyToolStripMenuItem.Click += new System.EventHandler(this.dangKyToolStripMenuItem_Click);
            // 
            // traCuuDiemToolStripMenuItem
            // 
            this.traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            this.traCuuDiemToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.traCuuDiemToolStripMenuItem.Text = "Tra cứu điểm";
            this.traCuuDiemToolStripMenuItem.Click += new System.EventHandler(this.traCuuDiemToolStripMenuItem_Click);
            // 
            // thongTInCaNhanSVToolStripMenuItem
            // 
            this.thongTInCaNhanSVToolStripMenuItem.Name = "thongTInCaNhanSVToolStripMenuItem";
            this.thongTInCaNhanSVToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.thongTInCaNhanSVToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thongTInCaNhanSVToolStripMenuItem.Click += new System.EventHandler(this.thongTInCaNhanSVToolStripMenuItem_Click);
            // 
            // thongTinCaNhanGVToolStripMenuItem
            // 
            this.thongTinCaNhanGVToolStripMenuItem.Name = "thongTinCaNhanGVToolStripMenuItem";
            this.thongTinCaNhanGVToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.thongTinCaNhanGVToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thongTinCaNhanGVToolStripMenuItem.Click += new System.EventHandler(this.thongTinCaNhanGVToolStripMenuItem_Click);
            // 
            // lichHocToolStripMenuItem
            // 
            this.lichHocToolStripMenuItem.Name = "lichHocToolStripMenuItem";
            this.lichHocToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.lichHocToolStripMenuItem.Text = "Lịch học";
            this.lichHocToolStripMenuItem.Click += new System.EventHandler(this.lichHocToolStripMenuItem_Click);
            // 
            // phânGiáoViênGiảngDạyToolStripMenuItem
            // 
            this.phânGiáoViênGiảngDạyToolStripMenuItem.Name = "phânGiáoViênGiảngDạyToolStripMenuItem";
            this.phânGiáoViênGiảngDạyToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.phânGiáoViênGiảngDạyToolStripMenuItem.Text = "Phân giáo viên giảng dạy";
            this.phânGiáoViênGiảngDạyToolStripMenuItem.Click += new System.EventHandler(this.phânGiáoViênGiảngDạyToolStripMenuItem_Click);
            // 
            // chamDiemToolStripMenuItem
            // 
            this.chamDiemToolStripMenuItem.Name = "chamDiemToolStripMenuItem";
            this.chamDiemToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.chamDiemToolStripMenuItem.Text = "Chấm điểm";
            this.chamDiemToolStripMenuItem.Click += new System.EventHandler(this.chamDiemToolStripMenuItem_Click);
            // 
            // danhSachLopHocToolStripMenuItem
            // 
            this.danhSachLopHocToolStripMenuItem.Name = "danhSachLopHocToolStripMenuItem";
            this.danhSachLopHocToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.danhSachLopHocToolStripMenuItem.Text = "Danh sách lớp học";
            this.danhSachLopHocToolStripMenuItem.Click += new System.EventHandler(this.danhSachLopHocToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.chucNangToolStripMenuItem,
            this.chamDiemToolStripMenuItem,
            this.danhSachLopHocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bomontheokhoavientoolstripmenuitem
            // 
            this.bomontheokhoavientoolstripmenuitem.Name = "bomontheokhoavientoolstripmenuitem";
            this.bomontheokhoavientoolstripmenuitem.Size = new System.Drawing.Size(249, 26);
            this.bomontheokhoavientoolstripmenuitem.Text = "Bộ môn (theo khoa/viện)";
            this.bomontheokhoavientoolstripmenuitem.Click += new System.EventHandler(this.bomontheokhoavientoolstripmenuitem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 456);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopHocPhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nganhHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngànhKhoaViệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangKyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTInCaNhanSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinCaNhanGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lichHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânGiáoViênGiảngDạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachLopHocToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bomontheokhoavientoolstripmenuitem;
    }
}

