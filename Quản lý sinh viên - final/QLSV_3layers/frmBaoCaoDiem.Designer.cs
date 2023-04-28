namespace QLSV_3layers
{
    partial class frmBaoCaoDiem
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
            this.crvBaoCaoDiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvBaoCaoDiem
            // 
            this.crvBaoCaoDiem.ActiveViewIndex = -1;
            this.crvBaoCaoDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBaoCaoDiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBaoCaoDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBaoCaoDiem.Location = new System.Drawing.Point(0, 0);
            this.crvBaoCaoDiem.Name = "crvBaoCaoDiem";
            this.crvBaoCaoDiem.Size = new System.Drawing.Size(570, 362);
            this.crvBaoCaoDiem.TabIndex = 0;
            // 
            // frmBaoCaoDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 362);
            this.Controls.Add(this.crvBaoCaoDiem);
            this.Name = "frmBaoCaoDiem";
            this.Text = "frmBaoCaoDiem";
            this.Load += new System.EventHandler(this.frmBaoCaoDiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCaoDiem;
    }
}