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
    public partial class frmDoiMK : Form
    {
        private string tendangnhap = "";
        private string loaitk = "";
        private string matkhau= "";
        public frmDoiMK(string tendangnhap)
        {
            this.tendangnhap = tendangnhap;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới");
                txtMatKhau.Select();
                return;
            }

            switch (cbbLoaiTaiKhoan.Text)
            {
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
                    value = txtTaiKhoan.Text,
                },
                new CustomParameter()
                {
                    key = "@matkhaumoi",
                    value = txtMatKhau.Text,
                }
            };
            var rs = new Database().Execute("doimatkhau", lstPara);
            if (rs==1)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ, vui lòng kiểm tra lại");
            }
        }
    }
}
