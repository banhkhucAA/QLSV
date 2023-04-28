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
    public partial class frmDangKyMonHoc : Form
    {
        private string masv;
        public frmDangKyMonHoc(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
            dgvDsLH.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDsLH.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvDsLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDsLH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDsLH.Columns["gvien"].HeaderText = "Giáo viên";
            dgvDsLH.Columns["ca"].HeaderText = "Ca";
            dgvDsLH.Columns["thu"].HeaderText = "Thứ";
        }

        private void LoadDSLH()
        {
            dgvDsLH.DataSource = null;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });
            dgvDsLH.DataSource = new Database().SelectData("dsLopChuaDky", lstPara);
        }

        private void dgvDsLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //double click hiện lên hộp thoại đăng ký môn học

            if (e.RowIndex >= 0)
            {
                //if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng ký [" + dgvDsLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + "]", "Xác nhận đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                DialogResult dlg = MessageBox.Show("Bạn có muốn đăng ký [" + dgvDsLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + "]", "Xác nhận đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dlg)
                {
                    case DialogResult.No:
                        break;

                    case DialogResult.Yes:
                    List<CustomParameter> lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = masv
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = dgvDsLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@Thu",
                        value = dgvDsLH.Rows[e.RowIndex].Cells["thu"].Value.ToString()
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@Ca",
                        value = dgvDsLH.Rows[e.RowIndex].Cells["ca"].Value.ToString()
                    });

                    var rs = new Database().Execute("dkyhoc", lstPara);
                    if (rs == -1)
                    {
                        MessageBox.Show("Học phần này bạn đã đăng ký, hoặc lịch của bạn đang bị trùng, vui lòng kiểm tra lại", "Cảnh báo!!!");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("Đã đăng ký học phần thành công", "Thành công!!!");
                        this.Dispose();
                    }
                        break;
                        LoadDSLH();
                }
            }
        }

        private void dgvDsLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
