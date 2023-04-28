namespace QLSV_3layers
{
    partial class frmBoMon
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTuKhoa = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dgvBoMon = new System.Windows.Forms.DataGridView();
            this.mabomon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbomon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(194, 46);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(151, 22);
            this.txtTimKiem.TabIndex = 0;
            // 
            // lbTuKhoa
            // 
            this.lbTuKhoa.AutoSize = true;
            this.lbTuKhoa.Location = new System.Drawing.Point(97, 49);
            this.lbTuKhoa.Name = "lbTuKhoa";
            this.lbTuKhoa.Size = new System.Drawing.Size(60, 17);
            this.lbTuKhoa.TabIndex = 1;
            this.lbTuKhoa.Text = "Từ khóa";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(368, 41);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 32);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiém";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(494, 41);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(109, 32);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // dgvBoMon
            // 
            this.dgvBoMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabomon,
            this.tenbomon,
            this.makhoa_vien,
            this.btnDelete});
            this.dgvBoMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBoMon.Location = new System.Drawing.Point(0, 106);
            this.dgvBoMon.Name = "dgvBoMon";
            this.dgvBoMon.RowTemplate.Height = 24;
            this.dgvBoMon.Size = new System.Drawing.Size(727, 274);
            this.dgvBoMon.TabIndex = 4;
            this.dgvBoMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoMon_CellClick);
            this.dgvBoMon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoMon_CellDoubleClick);
            // 
            // mabomon
            // 
            this.mabomon.DataPropertyName = "mabomon";
            this.mabomon.HeaderText = "Mã bộ môn";
            this.mabomon.Name = "mabomon";
            // 
            // tenbomon
            // 
            this.tenbomon.DataPropertyName = "tenbomon";
            this.tenbomon.HeaderText = "Tên bộ môn";
            this.tenbomon.Name = "tenbomon";
            // 
            // makhoa_vien
            // 
            this.makhoa_vien.DataPropertyName = "makhoa_vien";
            this.makhoa_vien.HeaderText = "Mã khoa - viện";
            this.makhoa_vien.Name = "makhoa_vien";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Xóa";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 380);
            this.Controls.Add(this.dgvBoMon);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lbTuKhoa);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "frmBoMon";
            this.Text = "frmBoMon";
            this.Load += new System.EventHandler(this.frmBoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView dgvBoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabomon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbomon;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa_vien;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}