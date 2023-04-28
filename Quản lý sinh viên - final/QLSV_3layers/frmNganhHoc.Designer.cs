namespace QLSV_3layers
{
    partial class frmNganhHoc
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
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.lbTenNganh = new System.Windows.Forms.Label();
            this.lbVien = new System.Windows.Forms.Label();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbVien = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Location = new System.Drawing.Point(62, 47);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(71, 17);
            this.lbMaNganh.TabIndex = 0;
            this.lbMaNganh.Text = "Mã ngành";
            // 
            // lbTenNganh
            // 
            this.lbTenNganh.AutoSize = true;
            this.lbTenNganh.Location = new System.Drawing.Point(62, 104);
            this.lbTenNganh.Name = "lbTenNganh";
            this.lbTenNganh.Size = new System.Drawing.Size(77, 17);
            this.lbTenNganh.TabIndex = 1;
            this.lbTenNganh.Text = "Tên ngành";
            // 
            // lbVien
            // 
            this.lbVien.AutoSize = true;
            this.lbVien.Location = new System.Drawing.Point(62, 161);
            this.lbVien.Name = "lbVien";
            this.lbVien.Size = new System.Drawing.Size(36, 17);
            this.lbVien.TabIndex = 2;
            this.lbVien.Text = "Viện";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(143, 47);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(319, 22);
            this.txtMaNganh.TabIndex = 3;
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(143, 104);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(319, 22);
            this.txtTenNganh.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(545, 47);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 51);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(545, 127);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 51);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbVien
            // 
            this.cbbVien.FormattingEnabled = true;
            this.cbbVien.Location = new System.Drawing.Point(143, 161);
            this.cbbVien.Name = "cbbVien";
            this.cbbVien.Size = new System.Drawing.Size(319, 24);
            this.cbbVien.TabIndex = 8;
            // 
            // frmNganhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 227);
            this.Controls.Add(this.cbbVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenNganh);
            this.Controls.Add(this.txtMaNganh);
            this.Controls.Add(this.lbVien);
            this.Controls.Add(this.lbTenNganh);
            this.Controls.Add(this.lbMaNganh);
            this.Name = "frmNganhHoc";
            this.Text = "Ngành học";
            this.Load += new System.EventHandler(this.frmNganhHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.Label lbTenNganh;
        private System.Windows.Forms.Label lbVien;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbVien;
    }
}