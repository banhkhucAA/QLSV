namespace QLSV_3layers
{
    partial class frmTTDiemSV
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
            this.txtDiem10 = new System.Windows.Forms.TextBox();
            this.lbDiem10 = new System.Windows.Forms.Label();
            this.txtDiem40 = new System.Windows.Forms.TextBox();
            this.lbDiem20 = new System.Windows.Forms.Label();
            this.txtDiem50 = new System.Windows.Forms.TextBox();
            this.lbDiem30 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiem10
            // 
            this.txtDiem10.Location = new System.Drawing.Point(96, 42);
            this.txtDiem10.Name = "txtDiem10";
            this.txtDiem10.Size = new System.Drawing.Size(272, 22);
            this.txtDiem10.TabIndex = 3;
            // 
            // lbDiem10
            // 
            this.lbDiem10.AutoSize = true;
            this.lbDiem10.Location = new System.Drawing.Point(18, 42);
            this.lbDiem10.Name = "lbDiem10";
            this.lbDiem10.Size = new System.Drawing.Size(72, 17);
            this.lbDiem10.TabIndex = 2;
            this.lbDiem10.Text = "Điểm 10%";
            // 
            // txtDiem40
            // 
            this.txtDiem40.Location = new System.Drawing.Point(96, 112);
            this.txtDiem40.Name = "txtDiem40";
            this.txtDiem40.Size = new System.Drawing.Size(272, 22);
            this.txtDiem40.TabIndex = 5;
            // 
            // lbDiem20
            // 
            this.lbDiem20.AutoSize = true;
            this.lbDiem20.Location = new System.Drawing.Point(18, 112);
            this.lbDiem20.Name = "lbDiem20";
            this.lbDiem20.Size = new System.Drawing.Size(72, 17);
            this.lbDiem20.TabIndex = 4;
            this.lbDiem20.Text = "Điểm 40%";
            // 
            // txtDiem50
            // 
            this.txtDiem50.Location = new System.Drawing.Point(96, 183);
            this.txtDiem50.Name = "txtDiem50";
            this.txtDiem50.Size = new System.Drawing.Size(272, 22);
            this.txtDiem50.TabIndex = 7;
            // 
            // lbDiem30
            // 
            this.lbDiem30.AutoSize = true;
            this.lbDiem30.Location = new System.Drawing.Point(18, 186);
            this.lbDiem30.Name = "lbDiem30";
            this.lbDiem30.Size = new System.Drawing.Size(72, 17);
            this.lbDiem30.TabIndex = 6;
            this.lbDiem30.Text = "Điểm 50%";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(447, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 65);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(447, 154);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 63);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTTDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 256);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDiem50);
            this.Controls.Add(this.lbDiem30);
            this.Controls.Add(this.txtDiem40);
            this.Controls.Add(this.lbDiem20);
            this.Controls.Add(this.txtDiem10);
            this.Controls.Add(this.lbDiem10);
            this.Name = "frmTTDiemSV";
            this.Text = "frmTTDiemSV";
            this.Load += new System.EventHandler(this.frmTTDiemSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDiem10;
        private System.Windows.Forms.Label lbDiem10;
        private System.Windows.Forms.TextBox txtDiem40;
        private System.Windows.Forms.Label lbDiem20;
        private System.Windows.Forms.TextBox txtDiem50;
        private System.Windows.Forms.Label lbDiem30;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}