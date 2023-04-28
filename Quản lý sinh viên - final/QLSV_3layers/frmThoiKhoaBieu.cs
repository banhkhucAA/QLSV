using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmThoiKhoaBieu : Form
    {
        private string masv;
        public frmThoiKhoaBieu(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private void frmThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@msv",
                value = masv
            });
            dgvTKB.DataSource = new Database().SelectData("thoikhoabieu", lstPara);
            dgvTKB.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvTKB.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvTKB.Columns["ca"].HeaderText = "Ca";
            dgvTKB.Columns["thu"].HeaderText = "Thứ";
            dgvTKB.Columns["phonghoc"].HeaderText = "Phòng học";
            dgvTKB.Columns["lichthi"].HeaderText = "Lịch thi";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgvTKB.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dgvTKB.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvTKB.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTKB.Columns.Count; j++)
                {
                    if (dgvTKB.Rows[i].Cells[j].Value != null)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvTKB.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
