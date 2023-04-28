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
    public partial class frmcapnhat_thembm : Form
    {
        private string mbm = "";
        public frmcapnhat_thembm(string mabomon)
        {
            this.mbm = mabomon;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcapnhat_thembm_Load(object sender, EventArgs e)
        {
            Laykhoa_vien();
            capnhat_thembm_load();
        }

        private void capnhat_thembm_load()
        {
            
            cbbMaKhoa_Vien.SelectedIndex = -1;

            if (string.IsNullOrEmpty(mbm))
            {
                this.Text = "Thêm mới bộ môn";
            }
            else
            {
                this.Text = "Cập nhật thông tin bộ môn";
                txtMaBoMon.Enabled = false;
                var r = new Database().Select("selectBM'" + mbm + "'");
                txtMaBoMon.Text = r["mabomon"].ToString();
                txtTenBoMon.Text = r["tenbomon"].ToString();
                cbbMaKhoa_Vien.Text = r["makhoa_vien"].ToString();
            }
        }

        Database kn = new Database();

        private void Laykhoa_vien()
        {
            string sql = "select*from tblVien";
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang(sql);
            cbbMaKhoa_Vien.DataSource = dta;
            cbbMaKhoa_Vien.DisplayMember = "makhoa_vien";
            cbbMaKhoa_Vien.ValueMember = "makhoa_vien";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtMaBoMon.Text))
            {
                MessageBox.Show("Mã bộ môn không được để trống");
                txtMaBoMon.Select();
                return;
            }else if(String.IsNullOrEmpty(txtTenBoMon.Text))
            {
                MessageBox.Show("Tên bộ môn không được để trống");
                txtTenBoMon.Select();
                return;
            }
            else if (String.IsNullOrEmpty(cbbMaKhoa_Vien.Text))
            {
                MessageBox.Show("Mã khoa/viện không được để trống");
                cbbMaKhoa_Vien.Select();
                return;
            }
            string sql = "";
            string mabomon = txtMaBoMon.Text;
            string tenbomon = txtTenBoMon.Text;
            string makhoa_vien = cbbMaKhoa_Vien.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mbm))
            {
                sql = string.Format("thembomon '{0}','{1}','{2}'",mabomon, tenbomon, makhoa_vien);
            }
            else
            {
                sql = string.Format("sua '{0}','{1}','{2}'", mabomon, tenbomon, makhoa_vien);
            }
            try
            {
                kn.ThucThi(sql);
                capnhat_thembm_load();
                MessageBox.Show("Kết thúc thực thi");
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện câu lệnh " + ex.Message);
            }

        }
    }
}
