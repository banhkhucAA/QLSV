namespace QLSV_3layers
{
    partial class frmDSNHoc
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
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbTuKhoa = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDSNHoc = new System.Windows.Forms.DataGridView();
            this.manganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(591, 33);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(98, 23);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(462, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbTuKhoa
            // 
            this.lbTuKhoa.AutoSize = true;
            this.lbTuKhoa.Location = new System.Drawing.Point(82, 33);
            this.lbTuKhoa.Name = "lbTuKhoa";
            this.lbTuKhoa.Size = new System.Drawing.Size(60, 17);
            this.lbTuKhoa.TabIndex = 6;
            this.lbTuKhoa.Text = "Từ khóa";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(182, 33);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(227, 22);
            this.txtTimKiem.TabIndex = 5;
            // 
            // dgvDSNHoc
            // 
            this.dgvDSNHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manganh,
            this.tennganh,
            this.makhoa_vien,
            this.btnDelete});
            this.dgvDSNHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSNHoc.Location = new System.Drawing.Point(0, 83);
            this.dgvDSNHoc.Name = "dgvDSNHoc";
            this.dgvDSNHoc.RowTemplate.Height = 24;
            this.dgvDSNHoc.Size = new System.Drawing.Size(758, 258);
            this.dgvDSNHoc.TabIndex = 9;
            this.dgvDSNHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNHoc_CellClick);
            this.dgvDSNHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNHoc_CellDoubleClick);
            // 
            // manganh
            // 
            this.manganh.DataPropertyName = "manganh";
            this.manganh.HeaderText = "Mã ngành";
            this.manganh.Name = "manganh";
            // 
            // tennganh
            // 
            this.tennganh.DataPropertyName = "tennganh";
            this.tennganh.HeaderText = "Tên ngành";
            this.tennganh.Name = "tennganh";
            // 
            // makhoa_vien
            // 
            this.makhoa_vien.DataPropertyName = "makhoa_vien";
            this.makhoa_vien.HeaderText = "Khoa/Viện";
            this.makhoa_vien.Name = "makhoa_vien";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Xóa";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmDSNHoc
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 341);
            this.Controls.Add(this.dgvDSNHoc);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lbTuKhoa);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "frmDSNHoc";
            this.Text = "frmDSNHoc";
            this.Load += new System.EventHandler(this.frmDSNHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbTuKhoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSNHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa_vien;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}