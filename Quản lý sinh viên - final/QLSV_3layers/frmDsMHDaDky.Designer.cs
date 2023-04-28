namespace QLSV_3layers
{
    partial class frmDsMHDaDky
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
            this.dgvDsMHDaDky = new System.Windows.Forms.DataGridView();
            this.lbTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDangKyMon = new System.Windows.Forms.Button();
            this.btnInFile = new System.Windows.Forms.Button();
            this.malophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotengvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMHDaDky)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsMHDaDky
            // 
            this.dgvDsMHDaDky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsMHDaDky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsMHDaDky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsMHDaDky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malophoc,
            this.tenmonhoc,
            this.sotinchi,
            this.masinhvien,
            this.hotengvien,
            this.ca,
            this.thu,
            this.btnDelete});
            this.dgvDsMHDaDky.Location = new System.Drawing.Point(-6, 84);
            this.dgvDsMHDaDky.MultiSelect = false;
            this.dgvDsMHDaDky.Name = "dgvDsMHDaDky";
            this.dgvDsMHDaDky.RowTemplate.Height = 24;
            this.dgvDsMHDaDky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsMHDaDky.Size = new System.Drawing.Size(842, 311);
            this.dgvDsMHDaDky.TabIndex = 0;
            this.dgvDsMHDaDky.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsMHDaDky_CellClick);
            // 
            // lbTuKhoa
            // 
            this.lbTuKhoa.AutoSize = true;
            this.lbTuKhoa.Location = new System.Drawing.Point(140, 32);
            this.lbTuKhoa.Name = "lbTuKhoa";
            this.lbTuKhoa.Size = new System.Drawing.Size(60, 17);
            this.lbTuKhoa.TabIndex = 1;
            this.lbTuKhoa.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(206, 32);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(172, 22);
            this.txtTuKhoa.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(384, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDangKyMon
            // 
            this.btnDangKyMon.Location = new System.Drawing.Point(515, 32);
            this.btnDangKyMon.Name = "btnDangKyMon";
            this.btnDangKyMon.Size = new System.Drawing.Size(137, 23);
            this.btnDangKyMon.TabIndex = 4;
            this.btnDangKyMon.Text = "Đăng ký mới";
            this.btnDangKyMon.UseVisualStyleBackColor = true;
            this.btnDangKyMon.Click += new System.EventHandler(this.btnDangKyMon_Click);
            // 
            // btnInFile
            // 
            this.btnInFile.Location = new System.Drawing.Point(658, 32);
            this.btnInFile.Name = "btnInFile";
            this.btnInFile.Size = new System.Drawing.Size(137, 23);
            this.btnInFile.TabIndex = 5;
            this.btnInFile.Text = "Xuất file ra Excel";
            this.btnInFile.UseVisualStyleBackColor = true;
            this.btnInFile.Click += new System.EventHandler(this.btnInFile_Click);
            // 
            // malophoc
            // 
            this.malophoc.DataPropertyName = "malophoc";
            this.malophoc.HeaderText = "Mã lớp học";
            this.malophoc.Name = "malophoc";
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.Name = "tenmonhoc";
            // 
            // sotinchi
            // 
            this.sotinchi.DataPropertyName = "sotinchi";
            this.sotinchi.HeaderText = "Số tín chỉ";
            this.sotinchi.Name = "sotinchi";
            // 
            // masinhvien
            // 
            this.masinhvien.DataPropertyName = "masinhvien";
            this.masinhvien.HeaderText = "Mã sinh viên";
            this.masinhvien.Name = "masinhvien";
            // 
            // hotengvien
            // 
            this.hotengvien.DataPropertyName = "hotengvien";
            this.hotengvien.HeaderText = "Họ tên giáo viên";
            this.hotengvien.Name = "hotengvien";
            // 
            // ca
            // 
            this.ca.DataPropertyName = "ca";
            this.ca.HeaderText = "Ca học";
            this.ca.Name = "ca";
            // 
            // thu
            // 
            this.thu.DataPropertyName = "thu";
            this.thu.HeaderText = "Thứ học";
            this.thu.Name = "thu";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Xóa";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmDsMHDaDky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 395);
            this.Controls.Add(this.btnInFile);
            this.Controls.Add(this.btnDangKyMon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.lbTuKhoa);
            this.Controls.Add(this.dgvDsMHDaDky);
            this.Name = "frmDsMHDaDky";
            this.Text = "Danh sách môn học đã đăng ký";
            this.Load += new System.EventHandler(this.frmDsMHDaDky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMHDaDky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsMHDaDky;
        private System.Windows.Forms.Label lbTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDangKyMon;
        private System.Windows.Forms.Button btnInFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn malophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotengvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}