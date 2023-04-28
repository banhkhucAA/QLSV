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
    public partial class frmDSMH : Form
    {
        private string tukhoa = "";
        public frmDSMH()
        {
            InitializeComponent();
        }
        private void DSMH_load()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMH.DataSource = null;
            dgvDSMH.DataSource = new Database().SelectData("SelectMonHoc", lstPara);
            dgvDSMH.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvDSMH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSMH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSMH.Columns["manganh"].HeaderText = "Mã ngành";
        }

        private void dgvDSMH_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show("Mã sinh viên: " + dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());
                var mmh = dgvDSMH.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new frmMonHoc(mmh).ShowDialog();
                //sau khi form sinhvien dc dong lai can load lai danh sach sinh vien
                DSMH_load();
            }
        }

        private void frmDSMH_Load(object sender, EventArgs e)
        {
            DSMH_load();
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
          
            frmMonHoc mh = new frmMonHoc(null);
            mh.ShowDialog();//showdialog hiển thị luôn lên màn hình chính, còn show kia đơn thuần chỉ là showform
            DSMH_load();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            DSMH_load();
        }

        private void dgvDSMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSMH.Columns["btnDelete"].Index)
                {
                    var mamh = dgvDSMH.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                    var sql = "deleteMH";
                    var lstPara = new List<CustomParameter>
                    {
                        new CustomParameter()
                        {
                            key = "@mmh",
                            value = mamh
                        }
                    };
                    var result = new Database().Execute(sql, lstPara);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa môn học thành công");
                        DSMH_load();
                    }
                }
            }
        }
    }
}
