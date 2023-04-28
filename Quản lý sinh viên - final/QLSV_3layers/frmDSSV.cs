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
    public partial class frmDSSV : Form
    {
        private string taikhoan;
        private string loaitk;
        public frmDSSV(string taikhoan,string loaitk)
        {
            this.taikhoan = taikhoan;
            this.loaitk = loaitk;
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }
        private void LoadDSSV()
        {
            
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                });
                dgvDSSV.DataSource = null;
                dgvDSSV.DataSource = new Database().SelectData("SelectSinhVien", lstPara);

                dgvDSSV.Columns["masinhvien"].HeaderText = "Mã sinh viên";
                dgvDSSV.Columns["hoten"].HeaderText = "Họ tên";
                dgvDSSV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dgvDSSV.Columns["gt"].HeaderText = "Giới tính";
                dgvDSSV.Columns["diachi"].HeaderText = "Địa chỉ";
                dgvDSSV.Columns["quequan"].HeaderText = "Quê quán";
                dgvDSSV.Columns["email"].HeaderText = "Email";
                dgvDSSV.Columns["matkhau"].HeaderText = "Mật khẩu";
                dgvDSSV.Columns["dienthoai"].HeaderText = "Điện thoại";
                dgvDSSV.Columns["manganh"].HeaderText = "Mã ngành học";

        }

        private void dgvDSSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    //MessageBox.Show("Mã sinh viên: " + dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());
                    var msv = dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                    new frmSinhVien(msv,taikhoan,loaitk).ShowDialog();
                    //sau khi form sinhvien dc dong lai can load lai danh sach sinh vien
                    LoadDSSV();
                }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null,taikhoan,loaitk).ShowDialog(); //neu them moi, ma sinh vien = null
            LoadDSSV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = textBox1.Text;
            LoadDSSV();
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                if(e.ColumnIndex==dgvDSSV.Columns["btnDelete"].Index)
                {
                    var masv = dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
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
                    if(result==1)
                    {
                        MessageBox.Show("Xóa sinh viên thành công");
                        LoadDSSV();
                    }
                }
            }
        }

        
    }
}
