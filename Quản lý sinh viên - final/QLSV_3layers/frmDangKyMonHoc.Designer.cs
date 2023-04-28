namespace QLSV_3layers
{
    partial class frmDangKyMonHoc
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
            this.dgvDsLH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsLH
            // 
            this.dgvDsLH.AllowUserToAddRows = false;
            this.dgvDsLH.AllowUserToDeleteRows = false;
            this.dgvDsLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsLH.Location = new System.Drawing.Point(0, 0);
            this.dgvDsLH.MultiSelect = false;
            this.dgvDsLH.Name = "dgvDsLH";
            this.dgvDsLH.ReadOnly = true;
            this.dgvDsLH.RowTemplate.Height = 24;
            this.dgvDsLH.Size = new System.Drawing.Size(955, 391);
            this.dgvDsLH.TabIndex = 0;
            this.dgvDsLH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsLH_CellContentClick);
            this.dgvDsLH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsLH_CellDoubleClick);
            // 
            // frmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 391);
            this.Controls.Add(this.dgvDsLH);
            this.Name = "frmDangKyMonHoc";
            this.Text = "Danh sách lớp học";
            this.Load += new System.EventHandler(this.frmDangKyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsLH;
    }
}