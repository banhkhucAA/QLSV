namespace QLSV_3layers
{
    partial class frmBaoCaoPhanLop
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
            this.lbMaGiaoVien = new System.Windows.Forms.Label();
            this.cbbMaGiaoVien = new System.Windows.Forms.ComboBox();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.crvBaoCaoLop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lbMaGiaoVien
            // 
            this.lbMaGiaoVien.AutoSize = true;
            this.lbMaGiaoVien.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaGiaoVien.Location = new System.Drawing.Point(101, 27);
            this.lbMaGiaoVien.Name = "lbMaGiaoVien";
            this.lbMaGiaoVien.Size = new System.Drawing.Size(104, 24);
            this.lbMaGiaoVien.TabIndex = 0;
            this.lbMaGiaoVien.Text = "Mã giáo viên";
            // 
            // cbbMaGiaoVien
            // 
            this.cbbMaGiaoVien.FormattingEnabled = true;
            this.cbbMaGiaoVien.Location = new System.Drawing.Point(229, 27);
            this.cbbMaGiaoVien.Name = "cbbMaGiaoVien";
            this.cbbMaGiaoVien.Size = new System.Drawing.Size(144, 24);
            this.cbbMaGiaoVien.TabIndex = 1;
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(399, 22);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(128, 32);
            this.btnInBaoCao.TabIndex = 2;
            this.btnInBaoCao.Text = "Xuất báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // crvBaoCaoLop
            // 
            this.crvBaoCaoLop.ActiveViewIndex = -1;
            this.crvBaoCaoLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvBaoCaoLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBaoCaoLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBaoCaoLop.Location = new System.Drawing.Point(-7, 60);
            this.crvBaoCaoLop.Name = "crvBaoCaoLop";
            this.crvBaoCaoLop.Size = new System.Drawing.Size(643, 320);
            this.crvBaoCaoLop.TabIndex = 3;
            // 
            // frmBaoCaoPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(631, 380);
            this.Controls.Add(this.crvBaoCaoLop);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.cbbMaGiaoVien);
            this.Controls.Add(this.lbMaGiaoVien);
            this.Name = "frmBaoCaoPhanLop";
            this.Text = "frmBaoCaoPhanLop";
            this.Load += new System.EventHandler(this.frmBaoCaoPhanLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaGiaoVien;
        private System.Windows.Forms.ComboBox cbbMaGiaoVien;
        private System.Windows.Forms.Button btnInBaoCao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCaoLop;
    }
}