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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;
        private string lstPara;
        private string matkhau = "";
        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmDangnhap(taikhoan);
            fn.ShowDialog();

            var tk = fn.tendangnhap;
            MessageBox.Show("Tài khoản đã đăng nhập là: " + tk);

            //sau khi form đăng nhập được tắt, lấy tài khoản đã đăng nhập
            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if(loaitk.Equals("qldt"))
            {
                chamDiemToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
                danhSachLopHocToolStripMenuItem.Visible = false;
                thongTinCaNhanGVToolStripMenuItem.Visible = false;
                thongTInCaNhanSVToolStripMenuItem.Visible = false;
                lichHocToolStripMenuItem.Visible = false;
                sinhVienToolStripMenuItem.Visible = false;
                giaoVienToolStripMenuItem.Visible = false;
            }
            else if(loaitk.Equals("admin"))
            {
                //nếu là admin
                //ẩn 2 menu chấm điểm và đăng ký môn học
                //chỉ để lại menu quản lý
                //MessageBox.Show("Đây là tài khoản của admin");
                chamDiemToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
                danhSachLopHocToolStripMenuItem.Visible = false;
                thongTinCaNhanGVToolStripMenuItem.Visible = false;
                thongTInCaNhanSVToolStripMenuItem.Visible = false;
                lichHocToolStripMenuItem.Visible = false;
                monHocToolStripMenuItem.Visible = false;
                lopHocPhanToolStripMenuItem.Visible = false;
                nganhHocToolStripMenuItem.Visible = false;
                ngànhKhoaViệnToolStripMenuItem.Visible = false;
                bomontheokhoavientoolstripmenuitem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
                if(loaitk.Equals("gv"))
                {
                    //MessageBox.Show("Đây là tài khoản của giáo viên");
                    dangKyToolStripMenuItem.Visible = false;
                    traCuuDiemToolStripMenuItem.Visible = false;
                    thongTInCaNhanSVToolStripMenuItem.Visible = false;
                    doiMatKhauToolStripMenuItem.Visible = false;
                    thongTInCaNhanSVToolStripMenuItem.Visible = false;
                    lichHocToolStripMenuItem.Visible = false;
                    ngànhKhoaViệnToolStripMenuItem.Visible = false;
                    bomontheokhoavientoolstripmenuitem.Visible = false;

                    Database dtb = new Database();
                    string sql = "select* from tblgiaovien where chucvu = N'Trưởng bộ môn' and magiaovien = '" + tk + "'";
                    DataTable dta = new DataTable();
                    dta = dtb.Lay_DuLieuBang(sql);
                    if (dta.Rows.Count ==0 )
                    {
                        phânGiáoViênGiảngDạyToolStripMenuItem.Visible = false;
                    }

                }
                else
                {
                    //MessageBox.Show("Đây là tài khoản của sinh viên");
                    chamDiemToolStripMenuItem.Visible = false;
                    danhSachLopHocToolStripMenuItem.Visible = false;
                    doiMatKhauToolStripMenuItem.Visible = false;
                    thongTinCaNhanGVToolStripMenuItem.Visible = false;
                    ngànhKhoaViệnToolStripMenuItem.Visible = false;
                    bomontheokhoavientoolstripmenuitem.Visible = false;
                    phânGiáoViênGiảngDạyToolStripMenuItem.Visible = false;
                }
            }           
            frmWelcome wc = new frmWelcome();
            AddForm(wc);
            this.Text = "Bắt đầu chương trình";
        }

        private void AddForm(Form f)//add luôn form nào đó vào form chính, cụ thể là add vào panel của form chính
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV sv = new frmDSSV(taikhoan,loaitk);
            AddForm(sv);
            this.Text = "Quản lý sinh viên";
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSGV gv = new frmDSGV(taikhoan);
            AddForm(gv);
            this.Text = "Quản lý giáo viên";
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.pnlContent.Controls.Clear();
            frmDSMH mh = new frmDSMH();
            AddForm(mh);
            this.Text = "Quản lý môn học";
        }

        private void lopHocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsLopHocPhan ds = new frmDsLopHocPhan();
            AddForm(ds);
            this.Text = "Quản lý lớp học phần";
        }

        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmDsMHDaDky(taikhoan).ShowDialog();
            var f = new frmDsMHDaDky(taikhoan);
            AddForm(f);
            this.Text = "Danh sách đăng ký môn học";
        }

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmKetQuaHocTap(taikhoan);
            AddForm(f);
            this.Text = "Tra cứu điểm";
        }

        //thêm cái thời khóa biểu học tập
        private void danhSachLopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDSLopGiangDay(taikhoan);
            AddForm(f);
            this.Text = "Danh sách lớp giảng dạy";
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoiMK(matkhau);
            f.Text = "Đổi mật khẩu";
            f.ShowDialog();
        }

        private void thongTInCaNhanSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmSinhVien(taikhoan,taikhoan,loaitk);
            f.Text = "Thông tin cá nhân sinh viên";
            f.ShowDialog();
        }

        private void thongTinCaNhanGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmGiaoVien(taikhoan,taikhoan);
            f.Text = "Thông tin cá nhân giáo viên";
            f.ShowDialog();
        }

        private void chamDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmChamDiem(taikhoan);
            AddForm(f);
            this.Text = "Chấm điểm";
        }
        
        private void nganhHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDSNH(taikhoan);
            AddForm(f);
            this.Text = "Lớp chuyên ngành";
        }


        private void lichHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThoiKhoaBieu(taikhoan);
            AddForm(f);
            this.Text = "Thời khóa biểu";
        }

        private void ngànhKhoaViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDSNHoc();
            AddForm(f);
            this.Text = "Ngành học";
        }

        Database kn = new Database();

        private void phânGiáoViênGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhanGiaoVien(taikhoan);
            AddForm(f);
            this.Text = "Phân giáo viên giảng dạy";
        }

        private void bomontheokhoavientoolstripmenuitem_Click(object sender, EventArgs e)
        {
            var f = new frmBoMon();
            AddForm(f);
            this.Text = "Bộ môn (của từng khoa/viện)";
        }
    }
}
