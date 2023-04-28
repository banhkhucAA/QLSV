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
    public partial class frmNganhHoc : Form
    {
        private string manganh;
        public frmNganhHoc(string manganh)
        {
            this.manganh = manganh;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string manganh_1 = txtMaNganh.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            

            if (string.IsNullOrEmpty(txtMaNganh.Text))
            {
                MessageBox.Show("Mã ngành không được để trống và không được trùng với mã ngành đã có");
                txtMaNganh.Select();
                return;
            }

            if (string.IsNullOrEmpty(manganh))
            {
                sql = "insertNganh";
                lstPara.Add(new CustomParameter()
                {
                    key = "@manganh",//tham so trong sql
                    value = manganh_1//gia tri moi can luu
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@tennganh",
                    value = txtTenNganh.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@vien",
                    value = cbbVien.Text
                });
            }
            else
            {
                sql = "updateNganh";
                lstPara.Add(new CustomParameter()
                {
                    key = "@manganh",//tham so trong sql
                    value = manganh//gia tri moi can luu
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@tennganh",
                    value = txtTenNganh.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@vien",
                    value = cbbVien.Text
                });
            }
            

            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(manganh))
                {
                    MessageBox.Show("Thêm mới ngành học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin ngành học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }
        }

        Database kn = new Database();

        public void lay_vien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("select makhoa_vien from tblVien");
            cbbVien.DataSource = dta;
            cbbVien.DisplayMember = "makhoa_vien";
            cbbVien.ValueMember = "makhoa_vien";
        }

        private void frmNganhHoc_Load(object sender, EventArgs e)
        {
            lay_vien();
            //var kn = new Database().Select("selectnganhhoc '" + manganh + "'");
            if (string.IsNullOrEmpty(manganh))// neu ma sinh vien ko co => them moi sinh vien
            {
                this.Text = "Thêm mới ngành học"; // text nay la cua grid
            }
            else
            {
                txtMaNganh.Enabled = false;
                this.Text = "Cập nhật ngành học";
                //lấy thông tin chi tiết của 1 môn học dựa vào mã môn học
                var r = new Database().Select("selectnganh_hoc '" + manganh + "'");
                //MessageBox.Show(r[0].ToString());
                //set cac gia tri vao component cua form
                txtMaNganh.Text = r["manganh"].ToString();
                txtTenNganh.Text = r["tennganh"].ToString();
                cbbVien.Text = r["makhoa_vien"].ToString();
            }
        }
    }
}
