namespace QLSV_3layers
{
    partial class frmDSSV_1lop_Diem
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
            this.lbTuKhoa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvChamDiemTungSV = new System.Windows.Forms.DataGridView();
            this.btnLuuDiem = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamDiemTungSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTuKhoa
            // 
            this.lbTuKhoa.AutoSize = true;
            this.lbTuKhoa.Location = new System.Drawing.Point(82, 52);
            this.lbTuKhoa.Name = "lbTuKhoa";
            this.lbTuKhoa.Size = new System.Drawing.Size(60, 17);
            this.lbTuKhoa.TabIndex = 0;
            this.lbTuKhoa.Text = "Từ khóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(164, 49);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(308, 22);
            this.txtTuKhoa.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(501, 49);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(183, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvChamDiemTungSV
            // 
            this.dgvChamDiemTungSV.AllowUserToAddRows = false;
            this.dgvChamDiemTungSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamDiemTungSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamDiemTungSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChamDiemTungSV.Location = new System.Drawing.Point(0, 154);
            this.dgvChamDiemTungSV.Name = "dgvChamDiemTungSV";
            this.dgvChamDiemTungSV.RowTemplate.Height = 24;
            this.dgvChamDiemTungSV.Size = new System.Drawing.Size(989, 264);
            this.dgvChamDiemTungSV.TabIndex = 4;
            this.dgvChamDiemTungSV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamDiemTungSV_CellDoubleClick);
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.Location = new System.Drawing.Point(748, 49);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(183, 23);
            this.btnLuuDiem.TabIndex = 5;
            this.btnLuuDiem.Text = "Lưu";
            this.btnLuuDiem.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(164, 91);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(308, 30);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "In Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmDSSV_1lop_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 418);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnLuuDiem);
            this.Controls.Add(this.dgvChamDiemTungSV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTuKhoa);
            this.Name = "frmDSSV_1lop_Diem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDSSV_1lop_Diem";
            this.Load += new System.EventHandler(this.frmDSSV_1lop_Diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamDiemTungSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTuKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvChamDiemTungSV;
        private System.Windows.Forms.Button btnLuuDiem;
        private System.Windows.Forms.Button btnExcel;
    }
}