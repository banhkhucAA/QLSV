namespace QLSV_3layers
{
    partial class frmGiaoVien
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
            this.lbHo = new System.Windows.Forms.Label();
            this.lbTenDem = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.mtbNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.rtbNam = new System.Windows.Forms.RadioButton();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txHo = new System.Windows.Forms.TextBox();
            this.txtTenDem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.lbBoMon = new System.Windows.Forms.Label();
            this.cbbMaBoMon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(67, 29);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(26, 17);
            this.lbHo.TabIndex = 0;
            this.lbHo.Text = "Họ";
            // 
            // lbTenDem
            // 
            this.lbTenDem.AutoSize = true;
            this.lbTenDem.Location = new System.Drawing.Point(67, 66);
            this.lbTenDem.Name = "lbTenDem";
            this.lbTenDem.Size = new System.Drawing.Size(64, 17);
            this.lbTenDem.TabIndex = 1;
            this.lbTenDem.Text = "Tên đệm";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(67, 102);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(33, 17);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Tên";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(67, 224);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(72, 17);
            this.lbDienThoai.TabIndex = 3;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(67, 260);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(51, 17);
            this.lbDiaChi.TabIndex = 4;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(67, 297);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // mtbNgaySinh
            // 
            this.mtbNgaySinh.Location = new System.Drawing.Point(140, 146);
            this.mtbNgaySinh.Mask = "00/00/0000";
            this.mtbNgaySinh.Name = "mtbNgaySinh";
            this.mtbNgaySinh.Size = new System.Drawing.Size(311, 22);
            this.mtbNgaySinh.TabIndex = 7;
            this.mtbNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(67, 146);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(71, 17);
            this.lbNgaysinh.TabIndex = 8;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // rtbNam
            // 
            this.rtbNam.AutoSize = true;
            this.rtbNam.Location = new System.Drawing.Point(140, 186);
            this.rtbNam.Name = "rtbNam";
            this.rtbNam.Size = new System.Drawing.Size(58, 21);
            this.rtbNam.TabIndex = 9;
            this.rtbNam.Text = "Nam";
            this.rtbNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Location = new System.Drawing.Point(217, 186);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(47, 21);
            this.rbtNu.TabIndex = 10;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(67, 186);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(60, 17);
            this.lbGioiTinh.TabIndex = 11;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // txHo
            // 
            this.txHo.Location = new System.Drawing.Point(140, 26);
            this.txHo.Name = "txHo";
            this.txHo.Size = new System.Drawing.Size(311, 22);
            this.txHo.TabIndex = 12;
            // 
            // txtTenDem
            // 
            this.txtTenDem.Location = new System.Drawing.Point(140, 66);
            this.txtTenDem.Name = "txtTenDem";
            this.txtTenDem.Size = new System.Drawing.Size(311, 22);
            this.txtTenDem.TabIndex = 13;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(140, 102);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(311, 22);
            this.txtTen.TabIndex = 14;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(140, 224);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(311, 22);
            this.txtDienThoai.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(140, 260);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(311, 22);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(501, 97);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 66);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(501, 224);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 58);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(351, 185);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(100, 22);
            this.txtMatKhau.TabIndex = 21;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(279, 186);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(66, 17);
            this.lbMatKhau.TabIndex = 22;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(67, 336);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(59, 17);
            this.lbChucVu.TabIndex = 23;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Trưởng bộ môn",
            "Giáo viên"});
            this.cbbChucVu.Location = new System.Drawing.Point(140, 336);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(311, 24);
            this.cbbChucVu.TabIndex = 27;
            // 
            // lbBoMon
            // 
            this.lbBoMon.AutoSize = true;
            this.lbBoMon.Location = new System.Drawing.Point(61, 380);
            this.lbBoMon.Name = "lbBoMon";
            this.lbBoMon.Size = new System.Drawing.Size(78, 17);
            this.lbBoMon.TabIndex = 28;
            this.lbBoMon.Text = "Mã bộ môn";
            // 
            // cbbMaBoMon
            // 
            this.cbbMaBoMon.FormattingEnabled = true;
            this.cbbMaBoMon.Items.AddRange(new object[] {
            "Trưởng bộ môn",
            "Giáo viên"});
            this.cbbMaBoMon.Location = new System.Drawing.Point(140, 380);
            this.cbbMaBoMon.Name = "cbbMaBoMon";
            this.cbbMaBoMon.Size = new System.Drawing.Size(311, 24);
            this.cbbMaBoMon.TabIndex = 29;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 407);
            this.Controls.Add(this.cbbMaBoMon);
            this.Controls.Add(this.lbBoMon);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtTenDem);
            this.Controls.Add(this.txHo);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.rbtNu);
            this.Controls.Add(this.rtbNam);
            this.Controls.Add(this.lbNgaysinh);
            this.Controls.Add(this.mtbNgaySinh);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbTenDem);
            this.Controls.Add(this.lbHo);
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbTenDem;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.MaskedTextBox mtbNgaySinh;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.RadioButton rtbNam;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox txHo;
        private System.Windows.Forms.TextBox txtTenDem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label lbBoMon;
        private System.Windows.Forms.ComboBox cbbMaBoMon;
    }
}