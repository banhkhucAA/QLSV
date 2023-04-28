namespace QLSV_3layers
{
    partial class frmMonHoc
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
            this.txtTenmonhoc = new System.Windows.Forms.TextBox();
            this.lbTenMonHoc = new System.Windows.Forms.Label();
            this.txtSotinchi = new System.Windows.Forms.TextBox();
            this.lbSoTInChi = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.cbbMaNganh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTenmonhoc
            // 
            this.txtTenmonhoc.Location = new System.Drawing.Point(104, 44);
            this.txtTenmonhoc.Name = "txtTenmonhoc";
            this.txtTenmonhoc.Size = new System.Drawing.Size(211, 22);
            this.txtTenmonhoc.TabIndex = 3;
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.AutoSize = true;
            this.lbTenMonHoc.Location = new System.Drawing.Point(13, 44);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.Size = new System.Drawing.Size(91, 17);
            this.lbTenMonHoc.TabIndex = 2;
            this.lbTenMonHoc.Text = "Tên môn học";
            // 
            // txtSotinchi
            // 
            this.txtSotinchi.Location = new System.Drawing.Point(486, 44);
            this.txtSotinchi.Name = "txtSotinchi";
            this.txtSotinchi.Size = new System.Drawing.Size(144, 22);
            this.txtSotinchi.TabIndex = 5;
            // 
            // lbSoTInChi
            // 
            this.lbSoTInChi.AutoSize = true;
            this.lbSoTInChi.Location = new System.Drawing.Point(397, 47);
            this.lbSoTInChi.Name = "lbSoTInChi";
            this.lbSoTInChi.Size = new System.Drawing.Size(66, 17);
            this.lbSoTInChi.TabIndex = 4;
            this.lbSoTInChi.Text = "Số tín chỉ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(683, 29);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 52);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(807, 29);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 52);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Location = new System.Drawing.Point(13, 105);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(71, 17);
            this.lbMaNganh.TabIndex = 8;
            this.lbMaNganh.Text = "Mã ngành";
            // 
            // cbbMaNganh
            // 
            this.cbbMaNganh.FormattingEnabled = true;
            this.cbbMaNganh.Location = new System.Drawing.Point(104, 102);
            this.cbbMaNganh.Name = "cbbMaNganh";
            this.cbbMaNganh.Size = new System.Drawing.Size(211, 24);
            this.cbbMaNganh.TabIndex = 9;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 139);
            this.Controls.Add(this.cbbMaNganh);
            this.Controls.Add(this.lbMaNganh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSotinchi);
            this.Controls.Add(this.lbSoTInChi);
            this.Controls.Add(this.txtTenmonhoc);
            this.Controls.Add(this.lbTenMonHoc);
            this.Name = "frmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenmonhoc;
        private System.Windows.Forms.Label lbTenMonHoc;
        private System.Windows.Forms.TextBox txtSotinchi;
        private System.Windows.Forms.Label lbSoTInChi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.ComboBox cbbMaNganh;
    }
}