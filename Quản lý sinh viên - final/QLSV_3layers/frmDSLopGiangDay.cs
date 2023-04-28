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
    public partial class frmDSLopGiangDay : Form
    {
        private string mgv;
        private string malophoc = "";
        private string tukhoa = "";
        public frmDSLopGiangDay(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }

        private void frmDSLopGiangDay_Load(object sender, EventArgs e)
        {
            DSLop();
        }

        private void DSLop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = mgv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSLop.DataSource = new Database().SelectData("danhsachlop", lstPara);
            dgvDSLop.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvDSLop.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSLop.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLop.Columns["ca"].HeaderText = "Ca giảng dạy";
            dgvDSLop.Columns["thu"].HeaderText = "Thứ giảng dạy";
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            DSLop();
        }

        private void dgvDSLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var mlh = dgvDSLop.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                new frmDSSV1lop(mlh).ShowDialog();
                DSLop();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgvDSLop.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dgvDSLop.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvDSLop.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDSLop.Columns.Count; j++)
                {
                    if (dgvDSLop.Rows[i].Cells[j].Value != null)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvDSLop.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
