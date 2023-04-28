using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmGiaoVien : Form
    {
        private string mgv;
        private string taikhoan;
        public frmGiaoVien(string mgv,string taikhoan)
        {
            this.taikhoan = taikhoan;
            this.mgv = mgv;
            InitializeComponent();
        }

        Database kn = new Database();

        private void Lay_mabomon()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("select distinct mabomon from bomon_giaovien");
            cbbMaBoMon.DataSource = dta;
            cbbMaBoMon.DisplayMember = "mabomon";
            cbbMaBoMon.ValueMember = "mabomon";
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            if(taikhoan.Equals("admin"))
            {
                cbbChucVu.Enabled = true;
                cbbMaBoMon.Enabled = true;
            }
            else
            {
                cbbChucVu.Enabled = false;
                cbbMaBoMon.Enabled = false;
            }
            Lay_mabomon();
            cbbMaBoMon.SelectedIndex = -1;
            
            cbbChucVu.SelectedIndex = -1;

            if (taikhoan.Equals("admin"))
            {
                cbbChucVu.Enabled = true;
                cbbMaBoMon.Enabled = true;
                if (string.IsNullOrEmpty(mgv))
                {
                    this.Text = "Thêm mới giáo viên";
                }
                else
                {
                    this.Text = "Cập nhật thông tin giảng viên";
                    var r = new Database().Select("selectGV'" + mgv + "'");
                    txHo.Text = r["ho"].ToString();
                    txtDiaChi.Text = r["diachi"].ToString();
                    txtTenDem.Text = r["tendem"].ToString();
                    txtTen.Text = r["ten"].ToString();
                    txtEmail.Text = r["email"].ToString();
                    txtDienThoai.Text = r["dienthoai"].ToString();
                    mtbNgaySinh.Text = r["ngaysinh"].ToString();
                    txtMatKhau.Text = r["matkhau"].ToString();
                    cbbChucVu.Text = r["chucvu"].ToString();
                    cbbMaBoMon.Text = r["mabomon"].ToString();
                    if (r["gioitinh"].ToString() == "Nam")
                    {
                        rtbNam.Checked = true;
                    }
                    else
                        rbtNu.Checked = true;
                }
            }else
            {
                cbbChucVu.Enabled = false;
                cbbMaBoMon.Enabled = false;
                this.Text = "Cập nhật thông tin giảng viên";
                var r = new Database().Select("selectGV'" + mgv + "'");
                txHo.Text = r["ho"].ToString();
                txtDiaChi.Text = r["diachi"].ToString();
                txtTenDem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtDienThoai.Text = r["dienthoai"].ToString();
                mtbNgaySinh.Text = r["ngaysinh"].ToString();
                txtMatKhau.Text = r["matkhau"].ToString();
                cbbChucVu.Text = r["chucvu"].ToString();
                cbbMaBoMon.Text = r["mabomon"].ToString();
                if (r["gioitinh"].ToString() == "Nam")
                {
                    rtbNam.Checked = true;
                }
                else
                    rbtNu.Checked = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = txHo.Text;
            string ten = txtTen.Text;
            string tendem = txtTenDem.Text;
            string email = txtEmail.Text;
            string diachi = txtDiaChi.Text;
            string dienthoai = txtDienThoai.Text;
            string matkhau = txtMatKhau.Text;
            string chucvu = cbbChucVu.Text;
            string mabomon = cbbMaBoMon.Text;

            string gioitinh = rtbNam.Checked == true ? "Nam" : "Nữ";
            DateTime Ngaysinh;
            try
            {
                Ngaysinh = DateTime.ParseExact(mtbNgaySinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không hợp lệ" + ex.Message);
                mtbNgaySinh.Select();
                return;
            }

            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mgv))
            {
                sql = "ThemGV";
            }
            else
            {
                sql = "updateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@mgv",//tham so trong sql
                    value = mgv//gia tri moi can luu
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",//tham so trong sql
                    value = taikhoan//gia tri moi can luu
                });
            }
            // add tat ca cac thuoc tinh nhu ho, ten,....
            lstPara.Add(new CustomParameter()
            {
                key = "@matkhau",
                value = matkhau
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TenDem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ngaysinh",
                value = Ngaysinh.ToString("yyyy-mm-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DienThoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Diachi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = email
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@chucvu",
                value = chucvu
            }); lstPara.Add(new CustomParameter()
            {
                key = "@mabomon",
                value = mabomon
            });

            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))// neu them moi
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin giáo viên thành công");
                }
                this.Dispose(); //dong form sau khi thuc thi xong
            }
            else
            {
                MessageBox.Show("Thực thi thất bại, mỗi ngành chỉ có thể có 1 trưởng bộ môn");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
