namespace QLSV_3layers
{
    partial class frmKyHoc
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
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtTImKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dgvKyHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(99, 51);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(60, 17);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "Từ khóa";
            // 
            // txtTImKiem
            // 
            this.txtTImKiem.Location = new System.Drawing.Point(171, 51);
            this.txtTImKiem.Name = "txtTImKiem";
            this.txtTImKiem.Size = new System.Drawing.Size(311, 22);
            this.txtTImKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(518, 50);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(657, 51);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(115, 23);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // dgvKyHoc
            // 
            this.dgvKyHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKyHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKyHoc.Location = new System.Drawing.Point(0, 105);
            this.dgvKyHoc.Name = "dgvKyHoc";
            this.dgvKyHoc.RowTemplate.Height = 24;
            this.dgvKyHoc.Size = new System.Drawing.Size(872, 263);
            this.dgvKyHoc.TabIndex = 4;
            this.dgvKyHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyHoc_CellDoubleClick);
            // 
            // frmKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 368);
            this.Controls.Add(this.dgvKyHoc);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTImKiem);
            this.Controls.Add(this.lbTimKiem);
            this.Name = "frmKyHoc";
            this.Text = "frmKyHoc";
            this.Load += new System.EventHandler(this.frmKyHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TextBox txtTImKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView dgvKyHoc;
    }
}