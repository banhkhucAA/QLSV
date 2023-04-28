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
    public partial class frmKyHoc : Form
    {
        private string tukhoa = " ";
        public frmKyHoc()
        {
            InitializeComponent();
        }

        Database kn = new Database();

        private void frmKyHoc_Load(object sender, EventArgs e)
        {
            Dkyhoc_load();
        }

        private void Dkyhoc_load()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("Select*from kyhoc");
            dgvKyHoc.DataSource = dta;

            dgvKyHoc.Columns["makyhoc"].HeaderText = "Mã kỳ học";
            dgvKyHoc.Columns["thoigianbatdau"].HeaderText = "Thời gian bắt đầu";
            dgvKyHoc.Columns["thoigianketthuc"].HeaderText = "Thời gian kết thúc";
            dgvKyHoc.Columns["thoigianbatdaudkytin"].HeaderText = "Thời gian bắt đầu đăng ký tín";
            dgvKyHoc.Columns["thoigianketthucdkytin"].HeaderText = "Thời gian kết thúc đăng ký tín";
        }

        private void dgvKyHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show("Mã sinh viên: " + dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());
                var makyhoc = dgvKyHoc.Rows[e.RowIndex].Cells["makyhoc"].Value.ToString();
                new frmThem_CapNhatKyHoc(makyhoc).ShowDialog();
                //sau khi form sinhvien dc dong lai can load lai danh sach sinh vien
                Dkyhoc_load();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTImKiem.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvKyHoc.DataSource = new Database().SelectData("Selectallkyhoc", lstPara);

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmThem_CapNhatKyHoc(null).ShowDialog();
            Dkyhoc_load();
        }
    }
}
