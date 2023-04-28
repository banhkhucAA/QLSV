using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using PDFCreatorPilotLib;
using System.Text;

namespace QLSV_3layers
{
    public partial class frmDSSV_1lop_Diem : Form
    {
        private string mlh;
        private string mgv;
        private string tukhoa = "";
        public frmDSSV_1lop_Diem(string mlh,string mgv)
        {
            this.mlh = mlh;
            this.mgv = mgv;
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            frmSV_1lop_Diem();
        }

        private void frmDSSV_1lop_Diem_Load(object sender, EventArgs e)
        {
            frmSV_1lop_Diem();
        }
        private void frmSV_1lop_Diem()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@mlh",
                value = mlh,
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa,
            });
            dgvChamDiemTungSV.DataSource = new Database().SelectData("selectDiem", lstPara);
            dgvChamDiemTungSV.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvChamDiemTungSV.Columns["hotensinhvien"].HeaderText = "Họ tên sinh viên";
            dgvChamDiemTungSV.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvChamDiemTungSV.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvChamDiemTungSV.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvChamDiemTungSV.Columns["diem10"].HeaderText = "Điểm 10%";
            dgvChamDiemTungSV.Columns["diem40"].HeaderText = "Điểm 40%";
            dgvChamDiemTungSV.Columns["diem50"].HeaderText = "Điểm 50%";
            dgvChamDiemTungSV.Columns["tongket"].HeaderText = "Điểm tổng kết";
            this.Text = "Danh sách điểm sinh viên";
        }

        private void dgvChamDiemTungSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var msv = dgvChamDiemTungSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                var diem10 = dgvChamDiemTungSV.Rows[e.RowIndex].Cells["diem10"].Value.ToString();
                var diem40 = dgvChamDiemTungSV.Rows[e.RowIndex].Cells["diem40"].Value.ToString();
                var diem50 = dgvChamDiemTungSV.Rows[e.RowIndex].Cells["diem50"].Value.ToString();
                frmTTDiemSV ttsv = new frmTTDiemSV(mgv,msv,mlh,diem10,diem40,diem50);
                ttsv.ShowDialog();
                frmSV_1lop_Diem();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);
            for(int i=1;i<dgvChamDiemTungSV.Columns.Count+1;i++)
            {
                xcelApp.Cells[1, i] = dgvChamDiemTungSV.Columns[i - 1].HeaderText;
            }
            for(int i=0;i<dgvChamDiemTungSV.Rows.Count;i++)
            {
                for(int j = 0;j<dgvChamDiemTungSV.Columns.Count;j++)
                {
                    if (dgvChamDiemTungSV.Rows[i].Cells[j].Value != null)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvChamDiemTungSV.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
