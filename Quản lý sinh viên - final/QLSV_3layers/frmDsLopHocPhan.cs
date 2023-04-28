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
    public partial class frmDsLopHocPhan : Form
    {
        public frmDsLopHocPhan()
        {
            InitializeComponent();
        }

        private void frmDsLopHocPhan_Load(object sender, EventArgs e)
        {
            frmDSLH_Load();
        }
        private string tukhoa = "";
        private void frmDSLH_Load()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgvDSLH.DataSource = new Database().SelectData(sql,lstPara);
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp học phần";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSLH.Columns["ca"].HeaderText = "Ca";
            dgvDSLH.Columns["thu"].HeaderText = "Thứ";
            dgvDSLH.Columns["phong"].HeaderText = "Phòng";
            dgvDSLH.Columns["lichthi"].HeaderText = "Lịch thi";
        }

        private void btnTImKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            frmDSLH_Load();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmLopHoc(null).ShowDialog();
            frmDSLH_Load();
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var mlh = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString(); ;
                new frmLopHoc(mlh).ShowDialog();
                frmDSLH_Load();
            }
        }

        private void dgvDSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSLH.Columns["btnDelete"].Index)
                {
                    var malh = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                    var sql = "deleteLHP";
                    var lstPara = new List<CustomParameter>
                    {
                        new CustomParameter()
                        {
                            key = "@mlh",
                            value = malh
                        }
                    };
                    var result = new Database().Execute(sql, lstPara);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa lớp học phần thành công");
                        frmDSLH_Load();
                    }
                }
            }
        }
    }
}
