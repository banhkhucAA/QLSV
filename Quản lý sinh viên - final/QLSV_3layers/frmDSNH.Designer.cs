namespace QLSV_3layers
{
    partial class frmDSNH
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
            this.dgvNganhHoc = new System.Windows.Forms.DataGridView();
            this.malopchuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caclopchuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchiratruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTuKhoa = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganhHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNganhHoc
            // 
            this.dgvNganhHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNganhHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganhHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malopchuyennganh,
            this.tennganh,
            this.caclopchuyennganh,
            this.sotinchiratruong,
            this.manganh,
            this.btnDelete});
            this.dgvNganhHoc.Location = new System.Drawing.Point(0, 108);
            this.dgvNganhHoc.Name = "dgvNganhHoc";
            this.dgvNganhHoc.RowTemplate.Height = 24;
            this.dgvNganhHoc.Size = new System.Drawing.Size(879, 287);
            this.dgvNganhHoc.TabIndex = 0;
            this.dgvNganhHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganhHoc_CellClick);
            this.dgvNganhHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganhHoc_CellDoubleClick);
            // 
            // malopchuyennganh
            // 
            this.malopchuyennganh.DataPropertyName = "malopchuyennganh";
            this.malopchuyennganh.HeaderText = "Mã lớp chuyên ngành";
            this.malopchuyennganh.Name = "malopchuyennganh";
            // 
            // tennganh
            // 
            this.tennganh.DataPropertyName = "tennganh";
            this.tennganh.HeaderText = "Tên ngành";
            this.tennganh.Name = "tennganh";
            // 
            // caclopchuyennganh
            // 
            this.caclopchuyennganh.DataPropertyName = "caclopchuyennganh";
            this.caclopchuyennganh.HeaderText = "Các lớp chuyên ngành";
            this.caclopchuyennganh.Name = "caclopchuyennganh";
            // 
            // sotinchiratruong
            // 
            this.sotinchiratruong.DataPropertyName = "sotinchiratruong";
            this.sotinchiratruong.HeaderText = "Số tín chỉ ra trường";
            this.sotinchiratruong.Name = "sotinchiratruong";
            // 
            // manganh
            // 
            this.manganh.DataPropertyName = "manganh";
            this.manganh.HeaderText = "Mã ngành";
            this.manganh.Name = "manganh";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Xóa";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(197, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(227, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbTuKhoa
            // 
            this.lbTuKhoa.AutoSize = true;
            this.lbTuKhoa.Location = new System.Drawing.Point(97, 39);
            this.lbTuKhoa.Name = "lbTuKhoa";
            this.lbTuKhoa.Size = new System.Drawing.Size(60, 17);
            this.lbTuKhoa.TabIndex = 2;
            this.lbTuKhoa.Text = "Từ khóa";
            this.lbTuKhoa.Click += new System.EventHandler(this.lbTuKhoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(477, 39);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(581, 39);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // frmDSNH
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(879, 395);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lbTuKhoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvNganhHoc);
            this.Name = "frmDSNH";
            this.Text = "frmDSNH";
            this.Load += new System.EventHandler(this.frmDSNH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganhHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNganhHoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopchuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn caclopchuyennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchiratruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganh;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}