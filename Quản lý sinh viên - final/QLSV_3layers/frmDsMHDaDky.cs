using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmDsMHDaDky : Form
    {
        private string msv = " ";
        private string tukhoa = "";

        public frmDsMHDaDky(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }

        private void frmDsMHDaDky_Load(object sender, EventArgs e)
        {
            LoadMonDky();                        
        }
        private void LoadMonDky()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvDsMHDaDky.DataSource = null;
            dgvDsMHDaDky.DataSource = new Database().SelectData("mondadangky", lstPara);

            dgvDsMHDaDky.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDsMHDaDky.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDsMHDaDky.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDsMHDaDky.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvDsMHDaDky.Columns["hotengvien"].HeaderText = "Họ tên giáo viên";
            dgvDsMHDaDky.Columns["ca"].HeaderText = "Ca";
            dgvDsMHDaDky.Columns["thu"].HeaderText = "Thứ";

        }

        private void btnDangKyMon_Click(object sender, EventArgs e)
        {
            new frmDangKyMonHoc(msv).ShowDialog();
            //new frmDkyMonHoc_Test(msv).ShowDialog();
            LoadMonDky();
        }

        private void btnInFile_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgvDsMHDaDky.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dgvDsMHDaDky.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvDsMHDaDky.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDsMHDaDky.Columns.Count; j++)
                {
                    if (dgvDsMHDaDky.Rows[i].Cells[j].Value != null)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvDsMHDaDky.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void dgvDsMHDaDky_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                if(e.ColumnIndex == dgvDsMHDaDky.Columns["btnDelete"].Index)
                {
                    var masv = dgvDsMHDaDky.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                    var malh = dgvDsMHDaDky.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                    var sql = "xoadangky";
                    List<CustomParameter> lstPara = new List<CustomParameter>
                    {
                        new CustomParameter()
                        {
                            key = "@msv",
                            value = masv
                        },
                        new CustomParameter()
                        {
                            key = "@mlh",
                            value = malh
                        }
                    };
                    var result = new Database().Execute(sql, lstPara);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa môn học thành công");
                        LoadMonDky();
                    }else
                    {
                        MessageBox.Show("Không thể xóa do đã hết thời gian đăng ký");
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadMonDky();
        }
    }
}
