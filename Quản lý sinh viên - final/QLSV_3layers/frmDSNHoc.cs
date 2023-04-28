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
    public partial class frmDSNHoc : Form
    {
        private string tukhoa = "";
        public frmDSNHoc()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            DSNHoc_Load();
        }

        private void DSNHoc_Load()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSNHoc.DataSource = null;
            dgvDSNHoc.DataSource = new Database().SelectData("selectnganh", lstPara);
            dgvDSNHoc.Columns["manganh"].HeaderText = "Mã ngành";
            dgvDSNHoc.Columns["tennganh"].HeaderText = "Tên ngành";
            dgvDSNHoc.Columns["makhoa_vien"].HeaderText = "Khoa/Viện";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmNganhHoc(null).ShowDialog();
            DSNHoc_Load();
        }

        private void frmDSNHoc_Load(object sender, EventArgs e)
        {
            DSNHoc_Load();
        }

        private void dgvDSNHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show("Mã sinh viên: " + dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());
                var manganh = dgvDSNHoc.Rows[e.RowIndex].Cells["manganh"].Value.ToString();
                new frmNganhHoc(manganh).ShowDialog();
                DSNHoc_Load();
            }
        }

        private void dgvDSNHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSNHoc.Columns["btnDelete"].Index)
                {
                    var masv = dgvDSNHoc.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                    var sql = "deleteSV";
                    var lstPara = new List<CustomParameter>
                    {
                        new CustomParameter()
                        {
                            key = "@msv",
                            value = masv
                        }
                    };
                    var result = new Database().Execute(sql, lstPara);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa ngành học thành công");
                    }
                }
            }
        }
    }
}
