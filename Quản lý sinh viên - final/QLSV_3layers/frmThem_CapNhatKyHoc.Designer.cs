namespace QLSV_3layers
{
    partial class frmThem_CapNhatKyHoc
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
            this.lbNBD = new System.Windows.Forms.Label();
            this.lbNKT = new System.Windows.Forms.Label();
            this.lbBDDK = new System.Windows.Forms.Label();
            this.lbKTDK = new System.Windows.Forms.Label();
            this.mtbNBD = new System.Windows.Forms.MaskedTextBox();
            this.mtbNKT = new System.Windows.Forms.MaskedTextBox();
            this.mtbNDK = new System.Windows.Forms.MaskedTextBox();
            this.mtbNKTDK = new System.Windows.Forms.MaskedTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNBD
            // 
            this.lbNBD.AutoSize = true;
            this.lbNBD.Location = new System.Drawing.Point(44, 38);
            this.lbNBD.Name = "lbNBD";
            this.lbNBD.Size = new System.Drawing.Size(111, 17);
            this.lbNBD.TabIndex = 0;
            this.lbNBD.Text = "Ngày bắt đầu kỳ";
            // 
            // lbNKT
            // 
            this.lbNKT.AutoSize = true;
            this.lbNKT.Location = new System.Drawing.Point(44, 87);
            this.lbNKT.Name = "lbNKT";
            this.lbNKT.Size = new System.Drawing.Size(113, 17);
            this.lbNKT.TabIndex = 1;
            this.lbNKT.Text = "Ngày kết thúc kỳ";
            // 
            // lbBDDK
            // 
            this.lbBDDK.AutoSize = true;
            this.lbBDDK.Location = new System.Drawing.Point(44, 134);
            this.lbBDDK.Name = "lbBDDK";
            this.lbBDDK.Size = new System.Drawing.Size(111, 17);
            this.lbBDDK.TabIndex = 2;
            this.lbBDDK.Text = "Bắt đầu đăng ký";
            // 
            // lbKTDK
            // 
            this.lbKTDK.AutoSize = true;
            this.lbKTDK.Location = new System.Drawing.Point(44, 181);
            this.lbKTDK.Name = "lbKTDK";
            this.lbKTDK.Size = new System.Drawing.Size(114, 17);
            this.lbKTDK.TabIndex = 3;
            this.lbKTDK.Text = "Kết thúc đăng ký";
            // 
            // mtbNBD
            // 
            this.mtbNBD.Location = new System.Drawing.Point(167, 38);
            this.mtbNBD.Mask = "00/00/0000";
            this.mtbNBD.Name = "mtbNBD";
            this.mtbNBD.Size = new System.Drawing.Size(117, 22);
            this.mtbNBD.TabIndex = 4;
            this.mtbNBD.ValidatingType = typeof(System.DateTime);
            // 
            // mtbNKT
            // 
            this.mtbNKT.Location = new System.Drawing.Point(167, 87);
            this.mtbNKT.Mask = "00/00/0000";
            this.mtbNKT.Name = "mtbNKT";
            this.mtbNKT.Size = new System.Drawing.Size(117, 22);
            this.mtbNKT.TabIndex = 5;
            this.mtbNKT.ValidatingType = typeof(System.DateTime);
            // 
            // mtbNDK
            // 
            this.mtbNDK.Location = new System.Drawing.Point(167, 134);
            this.mtbNDK.Mask = "00/00/0000";
            this.mtbNDK.Name = "mtbNDK";
            this.mtbNDK.Size = new System.Drawing.Size(117, 22);
            this.mtbNDK.TabIndex = 6;
            this.mtbNDK.ValidatingType = typeof(System.DateTime);
            // 
            // mtbNKTDK
            // 
            this.mtbNKTDK.Location = new System.Drawing.Point(167, 178);
            this.mtbNKTDK.Mask = "00/00/0000";
            this.mtbNKTDK.Name = "mtbNKTDK";
            this.mtbNKTDK.Size = new System.Drawing.Size(117, 22);
            this.mtbNKTDK.TabIndex = 7;
            this.mtbNKTDK.ValidatingType = typeof(System.DateTime);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(333, 38);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 47);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(333, 151);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 47);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThem_CapNhatKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 230);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.mtbNKTDK);
            this.Controls.Add(this.mtbNDK);
            this.Controls.Add(this.mtbNKT);
            this.Controls.Add(this.mtbNBD);
            this.Controls.Add(this.lbKTDK);
            this.Controls.Add(this.lbBDDK);
            this.Controls.Add(this.lbNKT);
            this.Controls.Add(this.lbNBD);
            this.Name = "frmThem_CapNhatKyHoc";
            this.Text = "frmThem_CapNhatKyHoc";
            this.Load += new System.EventHandler(this.frmThem_CapNhatKyHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNBD;
        private System.Windows.Forms.Label lbNKT;
        private System.Windows.Forms.Label lbBDDK;
        private System.Windows.Forms.Label lbKTDK;
        private System.Windows.Forms.MaskedTextBox mtbNBD;
        private System.Windows.Forms.MaskedTextBox mtbNKT;
        private System.Windows.Forms.MaskedTextBox mtbNDK;
        private System.Windows.Forms.MaskedTextBox mtbNKTDK;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}