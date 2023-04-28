namespace QLSV_3layers
{
    partial class frm_new_nganhhoc
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
            this.lbLopChuyenNganh = new System.Windows.Forms.Label();
            this.lbstcRaTruong = new System.Windows.Forms.Label();
            this.txtLopChuyenNganh = new System.Windows.Forms.TextBox();
            this.txtstcRaTruong = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.cbbMaNganh = new System.Windows.Forms.ComboBox();
            this.txtmlcn = new System.Windows.Forms.TextBox();
            this.lbCn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLopChuyenNganh
            // 
            this.lbLopChuyenNganh.AutoSize = true;
            this.lbLopChuyenNganh.Location = new System.Drawing.Point(44, 79);
            this.lbLopChuyenNganh.Name = "lbLopChuyenNganh";
            this.lbLopChuyenNganh.Size = new System.Drawing.Size(126, 17);
            this.lbLopChuyenNganh.TabIndex = 1;
            this.lbLopChuyenNganh.Text = "Lớp chuyên ngành";
            // 
            // lbstcRaTruong
            // 
            this.lbstcRaTruong.AutoSize = true;
            this.lbstcRaTruong.Location = new System.Drawing.Point(42, 145);
            this.lbstcRaTruong.Name = "lbstcRaTruong";
            this.lbstcRaTruong.Size = new System.Drawing.Size(128, 17);
            this.lbstcRaTruong.TabIndex = 2;
            this.lbstcRaTruong.Text = "Số tín chỉ ra trường";
            // 
            // txtLopChuyenNganh
            // 
            this.txtLopChuyenNganh.Location = new System.Drawing.Point(176, 79);
            this.txtLopChuyenNganh.Name = "txtLopChuyenNganh";
            this.txtLopChuyenNganh.Size = new System.Drawing.Size(329, 22);
            this.txtLopChuyenNganh.TabIndex = 4;
            // 
            // txtstcRaTruong
            // 
            this.txtstcRaTruong.Location = new System.Drawing.Point(176, 142);
            this.txtstcRaTruong.Name = "txtstcRaTruong";
            this.txtstcRaTruong.Size = new System.Drawing.Size(329, 22);
            this.txtstcRaTruong.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(616, 35);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 53);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(616, 164);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 53);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Location = new System.Drawing.Point(76, 199);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(71, 17);
            this.lbMaNganh.TabIndex = 8;
            this.lbMaNganh.Text = "Mã ngành";
            // 
            // cbbMaNganh
            // 
            this.cbbMaNganh.FormattingEnabled = true;
            this.cbbMaNganh.Location = new System.Drawing.Point(176, 199);
            this.cbbMaNganh.Name = "cbbMaNganh";
            this.cbbMaNganh.Size = new System.Drawing.Size(329, 24);
            this.cbbMaNganh.TabIndex = 9;
            // 
            // txtmlcn
            // 
            this.txtmlcn.Location = new System.Drawing.Point(176, 23);
            this.txtmlcn.Name = "txtmlcn";
            this.txtmlcn.Size = new System.Drawing.Size(329, 22);
            this.txtmlcn.TabIndex = 11;
            // 
            // lbCn
            // 
            this.lbCn.AutoSize = true;
            this.lbCn.Location = new System.Drawing.Point(26, 23);
            this.lbCn.Name = "lbCn";
            this.lbCn.Size = new System.Drawing.Size(144, 17);
            this.lbCn.TabIndex = 12;
            this.lbCn.Text = "Mã lớp chuyên ngành";
            // 
            // frm_new_nganhhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 263);
            this.Controls.Add(this.lbCn);
            this.Controls.Add(this.txtmlcn);
            this.Controls.Add(this.cbbMaNganh);
            this.Controls.Add(this.lbMaNganh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtstcRaTruong);
            this.Controls.Add(this.txtLopChuyenNganh);
            this.Controls.Add(this.lbstcRaTruong);
            this.Controls.Add(this.lbLopChuyenNganh);
            this.Name = "frm_new_nganhhoc";
            this.Text = "Thêm lớp chuyên ngành";
            this.Load += new System.EventHandler(this.frm_new_nganhhoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbLopChuyenNganh;
        private System.Windows.Forms.Label lbstcRaTruong;
        private System.Windows.Forms.TextBox txtLopChuyenNganh;
        private System.Windows.Forms.TextBox txtstcRaTruong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.ComboBox cbbMaNganh;
        private System.Windows.Forms.TextBox txtmlcn;
        private System.Windows.Forms.Label lbCn;
    }
}