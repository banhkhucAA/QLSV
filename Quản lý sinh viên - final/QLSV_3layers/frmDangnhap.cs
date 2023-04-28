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
    public partial class frmDangnhap : Form
    {
        public string tendangnhap="";
        //public string matkhau ="";
        public string loaitk = "";
        public frmDangnhap(string tendangnhap)
        {
            this.tendangnhap = tendangnhap;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(cbbLoaiTaiKhoan.SelectedIndex<0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if(string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txtTenDangNhap.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu","Mật khẩu không thể để trống");
                txtTenDangNhap.Select();
                return;
            }

            tendangnhap = txtTenDangNhap.Text;
            loaitk = "";
            
            switch(cbbLoaiTaiKhoan.Text)
            {
                case "Quản lý đào tạo":
                    loaitk = "qldt";
                    break;
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";
                    break;
                case "Sinh viên":
                    loaitk = "sv";
                    break;
            }
            /*
            if (cbbLoaiTaiKhoan.Text == "Quản trị viên") loaitk = "admin";
            else if (cbbLoaiTaiKhoan.Text == "Giáo viên") loaitk = "gv";
            else loaitk = "sv";
            */
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value = loaitk,
                },
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = txtTenDangNhap.Text,
                },
                new CustomParameter()
                {
                    key = "@matkhau",
                    value = txtMatKhau.Text,
                }
            };
            var rs = new Database().SelectData("dangnhap", lstPara);
            if(rs.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ, vui lòng kiểm tra lại");
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
