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
    public partial class frmChamDiem : Form
    {
        private string mgv;
        private string tukhoa="";
        public frmChamDiem(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }

        private void frmChamDiem_Load(object sender, EventArgs e)
        {
            frmDiem_Load();

        }
        private void frmDiem_Load()
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
            dgvChamDiem.DataSource = new Database().SelectData("danhsachlop", lstPara);
            dgvChamDiem.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvChamDiem.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvChamDiem.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvChamDiem.Columns["ca"].HeaderText = "Ca học";
            dgvChamDiem.Columns["thu"].HeaderText = "Thứ học";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            frmDiem_Load();
        }

        private void dgvChamDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var mlh = dgvChamDiem.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                frmDSSV_1lop_Diem dssv = new frmDSSV_1lop_Diem(mlh,mgv);
                dssv.ShowDialog();
            }
        }
    }
}
