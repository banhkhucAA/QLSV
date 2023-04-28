namespace QLSV_3layers
{
    partial class frmKetQuaHocTap
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
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.dgvTraCuuDiem = new System.Windows.Forms.DataGridView();
            this.lbStc = new System.Windows.Forms.Label();
            this.lbDtb = new System.Windows.Forms.Label();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnCrystalReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(221, 68);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(123, 30);
            this.btnTraCuu.TabIndex = 0;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(23, 25);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(64, 17);
            this.lbTimKiem.TabIndex = 1;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(93, 22);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(387, 22);
            this.txtTraCuu.TabIndex = 2;
            // 
            // dgvTraCuuDiem
            // 
            this.dgvTraCuuDiem.AllowUserToAddRows = false;
            this.dgvTraCuuDiem.AllowUserToDeleteRows = false;
            this.dgvTraCuuDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraCuuDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTraCuuDiem.Location = new System.Drawing.Point(0, 117);
            this.dgvTraCuuDiem.Name = "dgvTraCuuDiem";
            this.dgvTraCuuDiem.ReadOnly = true;
            this.dgvTraCuuDiem.RowTemplate.Height = 24;
            this.dgvTraCuuDiem.Size = new System.Drawing.Size(989, 262);
            this.dgvTraCuuDiem.TabIndex = 3;
            // 
            // lbStc
            // 
            this.lbStc.AutoSize = true;
            this.lbStc.Location = new System.Drawing.Point(645, 25);
            this.lbStc.Name = "lbStc";
            this.lbStc.Size = new System.Drawing.Size(98, 17);
            this.lbStc.TabIndex = 4;
            this.lbStc.Text = "Tích lũy tín chỉ";
            // 
            // lbDtb
            // 
            this.lbDtb.AutoSize = true;
            this.lbDtb.Location = new System.Drawing.Point(595, 72);
            this.lbDtb.Name = "lbDtb";
            this.lbDtb.Size = new System.Drawing.Size(148, 17);
            this.lbDtb.TabIndex = 5;
            this.lbDtb.Text = "Điểm trung bình hệ 10";
            // 
            // txtTinChi
            // 
            this.txtTinChi.Enabled = false;
            this.txtTinChi.Location = new System.Drawing.Point(758, 25);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.Size = new System.Drawing.Size(199, 22);
            this.txtTinChi.TabIndex = 6;
            // 
            // txtDTB
            // 
            this.txtDTB.Enabled = false;
            this.txtDTB.Location = new System.Drawing.Point(758, 72);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(199, 22);
            this.txtDTB.TabIndex = 7;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(93, 68);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(111, 30);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "Xuất file Excel";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnCrystalReport
            // 
            this.btnCrystalReport.Location = new System.Drawing.Point(357, 68);
            this.btnCrystalReport.Name = "btnCrystalReport";
            this.btnCrystalReport.Size = new System.Drawing.Size(123, 30);
            this.btnCrystalReport.TabIndex = 9;
            this.btnCrystalReport.Text = "Báo cáo điểm";
            this.btnCrystalReport.UseVisualStyleBackColor = true;
            this.btnCrystalReport.Click += new System.EventHandler(this.btnCrystalReport_Click);
            // 
            // frmKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 379);
            this.Controls.Add(this.btnCrystalReport);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtTinChi);
            this.Controls.Add(this.lbDtb);
            this.Controls.Add(this.lbStc);
            this.Controls.Add(this.dgvTraCuuDiem);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.btnTraCuu);
            this.Name = "frmKetQuaHocTap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.frmKetQuaHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.DataGridView dgvTraCuuDiem;
        private System.Windows.Forms.Label lbStc;
        private System.Windows.Forms.Label lbDtb;
        private System.Windows.Forms.TextBox txtTinChi;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnCrystalReport;
    }
}