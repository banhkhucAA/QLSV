namespace QLSV_3layers
{
    partial class frm_capnhat_nganh
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
            this.txtstcRaTruong = new System.Windows.Forms.TextBox();
            this.txtLopChuyenNganh = new System.Windows.Forms.TextBox();
            this.lbstcRaTruong = new System.Windows.Forms.Label();
            this.lbLopChuyenNganh = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.cbbMaNganh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtstcRaTruong
            // 
            this.txtstcRaTruong.Location = new System.Drawing.Point(171, 109);
            this.txtstcRaTruong.Name = "txtstcRaTruong";
            this.txtstcRaTruong.Size = new System.Drawing.Size(329, 22);
            this.txtstcRaTruong.TabIndex = 11;
            // 
            // txtLopChuyenNganh
            // 
            this.txtLopChuyenNganh.Location = new System.Drawing.Point(171, 46);
            this.txtLopChuyenNganh.Name = "txtLopChuyenNganh";
            this.txtLopChuyenNganh.Size = new System.Drawing.Size(329, 22);
            this.txtLopChuyenNganh.TabIndex = 10;
            // 
            // lbstcRaTruong
            // 
            this.lbstcRaTruong.AutoSize = true;
            this.lbstcRaTruong.Location = new System.Drawing.Point(21, 112);
            this.lbstcRaTruong.Name = "lbstcRaTruong";
            this.lbstcRaTruong.Size = new System.Drawing.Size(128, 17);
            this.lbstcRaTruong.TabIndex = 8;
            this.lbstcRaTruong.Text = "Số tín chỉ ra trường";
            // 
            // lbLopChuyenNganh
            // 
            this.lbLopChuyenNganh.AutoSize = true;
            this.lbLopChuyenNganh.Location = new System.Drawing.Point(23, 46);
            this.lbLopChuyenNganh.Name = "lbLopChuyenNganh";
            this.lbLopChuyenNganh.Size = new System.Drawing.Size(126, 17);
            this.lbLopChuyenNganh.TabIndex = 7;
            this.lbLopChuyenNganh.Text = "Lớp chuyên ngành";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(552, 157);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 53);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(552, 28);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 53);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Location = new System.Drawing.Point(49, 178);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(71, 17);
            this.lbMaNganh.TabIndex = 14;
            this.lbMaNganh.Text = "Mã ngành";
            // 
            // cbbMaNganh
            // 
            this.cbbMaNganh.FormattingEnabled = true;
            this.cbbMaNganh.Location = new System.Drawing.Point(171, 178);
            this.cbbMaNganh.Name = "cbbMaNganh";
            this.cbbMaNganh.Size = new System.Drawing.Size(329, 24);
            this.cbbMaNganh.TabIndex = 15;
            // 
            // frm_capnhat_nganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 252);
            this.Controls.Add(this.cbbMaNganh);
            this.Controls.Add(this.lbMaNganh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtstcRaTruong);
            this.Controls.Add(this.txtLopChuyenNganh);
            this.Controls.Add(this.lbstcRaTruong);
            this.Controls.Add(this.lbLopChuyenNganh);
            this.Name = "frm_capnhat_nganh";
            this.Text = "Cập nhật lớp chuyên ngành";
            this.Load += new System.EventHandler(this.frm_capnhat_nganh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstcRaTruong;
        private System.Windows.Forms.TextBox txtLopChuyenNganh;
        private System.Windows.Forms.Label lbstcRaTruong;
        private System.Windows.Forms.Label lbLopChuyenNganh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.ComboBox cbbMaNganh;
    }
}