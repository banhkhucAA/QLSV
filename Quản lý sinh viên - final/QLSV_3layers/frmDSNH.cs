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
    public partial class frmDSNH : Form
    {
        private string tukhoa = "";
        private string taikhoan;
        public frmDSNH(string taikhoan)
        {
            this.taikhoan = taikhoan;
            InitializeComponent();
        }

        private void frmDSNH_Load(object sender, EventArgs e)
        {
            DSNH_Load();
        }
        private void DSNH_Load()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvNganhHoc.DataSource = null;
            dgvNganhHoc.DataSource = new Database().SelectData("selectnganhhoc", lstPara);
            dgvNganhHoc.Columns["malopchuyennganh"].HeaderText = "Mã lớp chuyên ngành";
            dgvNganhHoc.Columns["tennganh"].HeaderText = "Tên ngành học";
            dgvNganhHoc.Columns["caclopchuyennganh"].HeaderText = "Tên lớp chuyên ngành";
            dgvNganhHoc.Columns["sotinchiratruong"].HeaderText = "Số tín chỉ ra trường";
            dgvNganhHoc.Columns["manganh"].HeaderText = "Mã ngành";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            DSNH_Load();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frm_new_nganhhoc().ShowDialog();
            DSNH_Load();
        }

        private void dgvNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvNganhHoc.Columns["btnDelete"].Index)
                {
                    var malcn = dgvNganhHoc.Rows[e.RowIndex].Cells["malopchuyennganh"].Value.ToString();
                    var sql = "deleteLCN";
                    var lstPara = new List<CustomParameter>
                    {
                        new CustomParameter()
                        {
                            key = "@mlcn",
                            value = malcn
                        }
                    };
                    var result = new Database().Execute(sql, lstPara);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa ngành học thành công");
                        DSNH_Load();
                    }
                }
            }
        }

        private void dgvNganhHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var malopchuyennganh = dgvNganhHoc.Rows[e.RowIndex].Cells["malopchuyennganh"].Value.ToString();
            var manganh = dgvNganhHoc.Rows[e.RowIndex].Cells["manganh"].Value.ToString();
            new frm_capnhat_nganh(malopchuyennganh,manganh).ShowDialog();
            DSNH_Load();
        }

        private void lbTuKhoa_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
