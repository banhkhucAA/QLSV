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
    public partial class frmDSSV1lop : Form
    {
        private string mlh = "";
        private string tukhoa = "";
        public frmDSSV1lop(string mlh)
        {
            this.mlh = mlh;
            InitializeComponent();
        }

        private void frmDSSV1lop_Load(object sender, EventArgs e)
        {
            DSSV1lop();
        }
        private void DSSV1lop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = mlh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSSV1Lop.DataSource = new Database().SelectData("dssv1lophp", lstPara);
            dgvDSSV1Lop.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSSV1Lop.Columns["hotensinhvien"].HeaderText = "Họ tên sinh viên";
            dgvDSSV1Lop.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvDSSV1Lop.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvDSSV1Lop.Columns["quequan"].HeaderText = "Quê quán";
            dgvDSSV1Lop.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvDSSV1Lop.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvDSSV1Lop.Columns["email"].HeaderText = "Email";

            this.Text = "Danh sách sinh viên lớp";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            DSSV1lop();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgvDSSV1Lop.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dgvDSSV1Lop.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvDSSV1Lop.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDSSV1Lop.Columns.Count; j++)
                {
                    if (dgvDSSV1Lop.Rows[i].Cells[j].Value != null)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvDSSV1Lop.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
