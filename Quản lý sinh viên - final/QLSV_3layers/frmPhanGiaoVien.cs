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
    public partial class frmPhanGiaoVien : Form
    {
        private string taikhoan;
        public frmPhanGiaoVien(string taikhoan)
        {
            this.taikhoan = taikhoan;
            InitializeComponent();
        }

        private void frmPhanGiaoVien_Load(object sender, EventArgs e)
        {
            Lay_LopHoc();
            Lay_MaGiaoVien();
            Lay_GiaoVien_BoMon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Database kn = new Database();

        private void Lay_LopHoc()
        {
            string sql = string.Format("lophocphan_theomanganh '{0}'",taikhoan);
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang(sql);
            dgvLopHoc.DataSource = dta;
            DataBinding();

            txtCa.Enabled = false;
            txtMaLopHoc.Enabled = false;
            txtMaMonHoc.Enabled = false;
            txtPhong.Enabled = false;
            txtThu.Enabled = false;
            txtToaNha.Enabled = false;
            mtbLichThi.Enabled = false;
        }

        private void Lay_MaGiaoVien()
        {
            string sql = "duyet_giaovienbomon '" + taikhoan + "'";
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang(sql);
            cbbMaGiaoVien.DataSource = dta;
            cbbMaGiaoVien.DisplayMember = "magiaovien";
            cbbMaGiaoVien.ValueMember = "magiaovien";
        }

        private void Lay_GiaoVien_BoMon()
        {
            string sql = "duyet_giaovienbomon '" + taikhoan + "'";
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang(sql);
            dgvGiaoVien.DataSource = dta;
            dgvGiaoVien.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            dgvGiaoVien.Columns["hoten"].HeaderText = "Họ tên giáo viên";
            dgvGiaoVien.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvGiaoVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvGiaoVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvGiaoVien.Columns["email"].HeaderText = "Email";
            dgvGiaoVien.Columns["diachi"].HeaderText = "Địa chỉ";
        }

        private void DataBinding()
        {
            txtMaLopHoc.DataBindings.Clear();
            txtMaLopHoc.DataBindings.Add("Text", dgvLopHoc.DataSource, "malophoc");

            mtbLichThi.DataBindings.Clear();
            mtbLichThi.DataBindings.Add("Text", dgvLopHoc.DataSource, "lichthi");

            txtMaMonHoc.DataBindings.Clear();
            txtMaMonHoc.DataBindings.Add("Text", dgvLopHoc.DataSource, "mamonhoc");

            txtPhong.DataBindings.Clear();
            txtPhong.DataBindings.Add("Text", dgvLopHoc.DataSource, "phong");

            txtToaNha.DataBindings.Clear();
            txtToaNha.DataBindings.Add("Text", dgvLopHoc.DataSource, "toanha");

            txtCa.DataBindings.Clear();
            txtCa.DataBindings.Add("Text", dgvLopHoc.DataSource, "ca");

            cbbMaGiaoVien.DataBindings.Clear();
            cbbMaGiaoVien.DataBindings.Add("Text", dgvLopHoc.DataSource, "magiaovien");

            txtThu.DataBindings.Clear();
            txtThu.DataBindings.Add("Text", dgvLopHoc.DataSource, "thu");

            dgvLopHoc.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvLopHoc.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvLopHoc.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            dgvLopHoc.Columns["ca"].HeaderText = "Ca";
            dgvLopHoc.Columns["thu"].HeaderText = "Thứ";
            dgvLopHoc.Columns["toanha"].HeaderText = "Tòa nhà";
            dgvLopHoc.Columns["phong"].HeaderText = "Phòng";
            dgvLopHoc.Columns["lichthi"].HeaderText = "Lịch thi";
            dgvLopHoc.Columns["manganh"].HeaderText = "Mã ngành";
            dgvLopHoc.Columns["tenmonhoc"].HeaderText = "Tên môn học";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            string sql = "timkiemgiaovien '" + taikhoan + "', N'" +tukhoa+ "'";
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang(sql);
            dgvGiaoVien.DataSource = dta;
        }


        private void btnSuaGiaoVien_Click(object sender, EventArgs e)
        {
            string malophoc = txtMaLopHoc.Text;
            if(String.IsNullOrEmpty(cbbMaGiaoVien.Text))
            {
                MessageBox.Show("Không thể để trống mã giáo viên, vui lòng chọn giáo viên");
                cbbMaGiaoVien.Select();
                return;
            }
            string magiaovien = cbbMaGiaoVien.Text;
            string ca = txtCa.Text;
            string thu = txtThu.Text;
            /*
            string sql = string.Format("chiagiaovien '{0}','{1}','{2}','{3}'", malophoc,magiaovien,ca,thu);
            try
            {
                DataTable dta = new DataTable();
                dta = kn.Lay_DuLieuBang(sql);
                dgvLopHoc.DataSource = dta;
                MessageBox.Show("Cập nhật giáo viên cho lớp học phần thành công");
            }catch(Exception ex)
            {
                MessageBox.Show("Thực thi thất bại"+ex.Message);
            }*/
            string sql = "chiagiaovien";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            
            // add tat ca cac thuoc tinh nhu ho, ten,....
            lstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malophoc
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = magiaovien
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ca",
                value = ca
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@thu",
                value = thu
            });

            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {             
                MessageBox.Show("Cập nhật thông tin lớp học thành công");
            }
            else
            {
                MessageBox.Show("Thực thi thất bại, không thể bị trùng lịch giảng dạy của giáo viên");
            }
            Lay_LopHoc();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCaoPhanLop baocao = new frmBaoCaoPhanLop(taikhoan);
            baocao.ShowDialog();
        }
    }
}
