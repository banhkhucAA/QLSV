namespace QLSV_3layers
{
    partial class frmLopHoc
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
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.cbbMonhoc = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.cbbThu = new System.Windows.Forms.ComboBox();
            this.lbCa = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.lbToa = new System.Windows.Forms.Label();
            this.cbbToa = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuyXacNhan = new System.Windows.Forms.Button();
            this.lbNgayThi = new System.Windows.Forms.Label();
            this.mtbdate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Location = new System.Drawing.Point(47, 35);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(62, 17);
            this.lbMonHoc.TabIndex = 0;
            this.lbMonHoc.Text = "Môn học";
            // 
            // cbbMonhoc
            // 
            this.cbbMonhoc.FormattingEnabled = true;
            this.cbbMonhoc.Location = new System.Drawing.Point(147, 35);
            this.cbbMonhoc.Name = "cbbMonhoc";
            this.cbbMonhoc.Size = new System.Drawing.Size(438, 24);
            this.cbbMonhoc.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(50, 371);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 61);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(182, 371);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 61);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbCa
            // 
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(147, 87);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(438, 24);
            this.cbbCa.TabIndex = 6;
            // 
            // cbbThu
            // 
            this.cbbThu.FormattingEnabled = true;
            this.cbbThu.Location = new System.Drawing.Point(147, 145);
            this.cbbThu.Name = "cbbThu";
            this.cbbThu.Size = new System.Drawing.Size(438, 24);
            this.cbbThu.TabIndex = 7;
            // 
            // lbCa
            // 
            this.lbCa.AutoSize = true;
            this.lbCa.Location = new System.Drawing.Point(47, 87);
            this.lbCa.Name = "lbCa";
            this.lbCa.Size = new System.Drawing.Size(25, 17);
            this.lbCa.TabIndex = 8;
            this.lbCa.Text = "Ca";
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.Location = new System.Drawing.Point(47, 145);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(33, 17);
            this.lbThu.TabIndex = 9;
            this.lbThu.Text = "Thứ";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(47, 271);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(49, 17);
            this.lbPhong.TabIndex = 11;
            this.lbPhong.Text = "Phòng";
            // 
            // cbbPhong
            // 
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(147, 271);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(438, 24);
            this.cbbPhong.TabIndex = 10;
            // 
            // lbToa
            // 
            this.lbToa.AutoSize = true;
            this.lbToa.Location = new System.Drawing.Point(47, 210);
            this.lbToa.Name = "lbToa";
            this.lbToa.Size = new System.Drawing.Size(33, 17);
            this.lbToa.TabIndex = 13;
            this.lbToa.Text = "Tòa";
            // 
            // cbbToa
            // 
            this.cbbToa.FormattingEnabled = true;
            this.cbbToa.Items.AddRange(new object[] {
            "A2",
            "B",
            "C",
            "D"});
            this.cbbToa.Location = new System.Drawing.Point(147, 210);
            this.cbbToa.Name = "cbbToa";
            this.cbbToa.Size = new System.Drawing.Size(438, 24);
            this.cbbToa.TabIndex = 12;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(605, 196);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(102, 50);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.Text = "Xác nhận tòa nhà học";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "**Hãy xác nhận tòa nhà trước khi chọn số phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lời nhắc";
            // 
            // btnHuyXacNhan
            // 
            this.btnHuyXacNhan.Location = new System.Drawing.Point(713, 196);
            this.btnHuyXacNhan.Name = "btnHuyXacNhan";
            this.btnHuyXacNhan.Size = new System.Drawing.Size(102, 50);
            this.btnHuyXacNhan.TabIndex = 17;
            this.btnHuyXacNhan.Text = "Hủy xác nhận";
            this.btnHuyXacNhan.UseVisualStyleBackColor = true;
            this.btnHuyXacNhan.Click += new System.EventHandler(this.btnHuyXacNhan_Click);
            // 
            // lbNgayThi
            // 
            this.lbNgayThi.AutoSize = true;
            this.lbNgayThi.Location = new System.Drawing.Point(47, 332);
            this.lbNgayThi.Name = "lbNgayThi";
            this.lbNgayThi.Size = new System.Drawing.Size(60, 17);
            this.lbNgayThi.TabIndex = 18;
            this.lbNgayThi.Text = "Ngày thi";
            // 
            // mtbdate
            // 
            this.mtbdate.Location = new System.Drawing.Point(147, 332);
            this.mtbdate.Mask = "00/00/0000";
            this.mtbdate.Name = "mtbdate";
            this.mtbdate.Size = new System.Drawing.Size(110, 22);
            this.mtbdate.TabIndex = 19;
            this.mtbdate.ValidatingType = typeof(System.DateTime);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 454);
            this.Controls.Add(this.mtbdate);
            this.Controls.Add(this.lbNgayThi);
            this.Controls.Add(this.btnHuyXacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lbToa);
            this.Controls.Add(this.cbbToa);
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.lbThu);
            this.Controls.Add(this.lbCa);
            this.Controls.Add(this.cbbThu);
            this.Controls.Add(this.cbbCa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbMonhoc);
            this.Controls.Add(this.lbMonHoc);
            this.Name = "frmLopHoc";
            this.Text = "frmLopHoc";
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.ComboBox cbbMonhoc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.ComboBox cbbThu;
        private System.Windows.Forms.Label lbCa;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.Label lbToa;
        private System.Windows.Forms.ComboBox cbbToa;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyXacNhan;
        private System.Windows.Forms.Label lbNgayThi;
        private System.Windows.Forms.MaskedTextBox mtbdate;
    }
}