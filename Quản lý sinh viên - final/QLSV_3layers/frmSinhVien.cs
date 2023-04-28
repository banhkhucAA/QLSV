//dung de khoi tao 1 sinh vien, voi ma sinh vien
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
    public partial class frmSinhVien : Form
    {
        private string loaitk;
        private string taikhoan;
        private string msv;
        Database kn = new Database();
        public frmSinhVien(string msv,string taikhoan,string loaitk)
        {
            this.taikhoan = taikhoan;
            this.loaitk = loaitk;
            this.msv = msv; //truyền lại mã sinh viên khi form chạy
            InitializeComponent();
        }

        public void Lay_MaNganh()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("Select distinct malopchuyennganh from LopChuyenNganh");
            cbbManganh.DataSource = dta;
            cbbManganh.DisplayMember = "malopchuyennganh";
            cbbManganh.ValueMember = "malopchuyennganh";
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            Lay_MaNganh();
            //MessageBox.Show("Mã sinh viên nhận được là " + msv);
            if (string.IsNullOrEmpty(msv))// neu ma sinh vien ko co => them moi sinh vien
            {
                this.Text = "Thêm mới sinh viên"; // text nay la cua grid
            }
            else
            {
                if (loaitk.Equals("admin"))
                {
                    cbbManganh.Enabled = true;
                }
                else cbbManganh.Enabled = false;
                this.Text = "Cập nhật thông tin sinh viên";
                //lấy thông tin chi tiết của 1 sinh viên dựa vào mã sinh viên
                var r = new Database().Select("selectSV '" + msv + "'"); 
                //MessageBox.Show(r[0].ToString());
                //set cac gia tri vao component cua form
                txtHo.Text = r["ho"].ToString();
                txtTenDem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                txtDiaChi.Text = r["diachi"].ToString();
                txQueQuan.Text = r["quequan"].ToString();
                mtbNgaySinh.Text = r["ngaysinh"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtDienThoai.Text = r["dienthoai"].ToString();
                txtMatKhau.Text = r["matkhau"].ToString();
                cbbManganh.Text = r["manganh"].ToString();
                if (r["gioitinh"].ToString() == "Nam")
                {
                    rbtNam.Checked = true;
                }
                else
                    rbtNu.Checked = true;           
            }
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            
            string ho = txtHo.Text;
            string tendem = txtTenDem.Text;
            string ten = txtTen.Text;
            //string ngaysinh = r["ngaysinh"].ToString();
            string diachi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string gioitinh = rbtNam.Checked?"Nam":"Nữ";
            string quequan = txQueQuan.Text;
            string dienthoai = txtDienThoai.Text;
            string matkhau = txtMatKhau.Text;
            string manganh = cbbManganh.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaySinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            } catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaySinh.Select();// tro chuot ve mtbNgaySinh
                return;
            }

            if (string.IsNullOrEmpty(msv))
            {
                sql = "ThemSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@malopchuyennganh",//tham so trong sql
                    value = manganh//gia tri moi can luu
                });
            }
            else
            {
                sql = "updateSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@msv",//tham so trong sql
                    value = msv//gia tri moi can luu
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
                key = "@Ngaysinh",
                value = ngaysinh.ToString("yyyy-mm-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@QueQuan",
                value = quequan
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
                key = "@matkhau",
                value = matkhau
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DienThoai",
                value = dienthoai
            });


            var rs = new Database().Execute(sql, lstPara);
            if(rs==1)
            {
                if(string.IsNullOrEmpty(msv))// neu them moi
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }else
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                }
                this.Dispose(); //dong form sau khi thuc thi xong
            }
            else
            {
                MessageBox.Show("Thực thi thất bại, phải điền mục Mã ngành"); 
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
