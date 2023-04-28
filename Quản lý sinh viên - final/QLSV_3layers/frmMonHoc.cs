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
    public partial class frmMonHoc : Form
    {
        private string mmh;
        public frmMonHoc(string mmh)
        {
            this.mmh = mmh;
            InitializeComponent();
        }

        Database kn = new Database();
        private void Lay_manganh()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("select distinct manganh from ChuyenNganh");
            cbbMaNganh.DataSource = dta;
            cbbMaNganh.DisplayMember = "manganh";
            cbbMaNganh.ValueMember = "manganh";
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            Lay_manganh();
            cbbMaNganh.SelectedIndex = -1;
            if (string.IsNullOrEmpty(mmh))// neu ma sinh vien ko co => them moi sinh vien
            {
                this.Text = "Thêm mới môn học"; // text nay la cua grid
            }
            else
            {
                this.Text = "Cập nhật môn học";
                //lấy thông tin chi tiết của 1 môn học dựa vào mã môn học
                var r = new Database().Select("selectMH '" + mmh + "'");
                //MessageBox.Show(r[0].ToString());
                //set cac gia tri vao component cua form
                txtTenmonhoc.Text = r["tenmonhoc"].ToString();
                txtSotinchi.Text = r["sotinchi"].ToString();
                cbbMaNganh.Text = r["manganh"].ToString();           
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            try
            {
                var stc = int.Parse(txtSotinchi.Text);
                if(stc<=0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txtSotinchi.Select();
                    return;
                }
            }catch
            {
                MessageBox.Show("Số tín chỉ phải là kiểu số nguyên");
                txtSotinchi.Select();
                return;
            }

            if(string.IsNullOrEmpty(txtTenmonhoc.Text))
            {
                MessageBox.Show("Tên môn học không được để trống");
                txtTenmonhoc.Select();
                return;
            }
            if (string.IsNullOrEmpty(cbbMaNganh.Text))
            {
                MessageBox.Show("Mã ngành không được để trống");
                cbbMaNganh.Select();
                return;
            }

            if (string.IsNullOrEmpty(mmh))
            {
                sql = "ThemMH";
            }
            else
            {
                sql = "updateMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@mmh",//tham so trong sql
                    value = mmh//gia tri moi can luu
                });            
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@tenmh",
                value = txtTenmonhoc.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@sotinchi",
                value = txtSotinchi.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@manganh",
                value = cbbMaNganh.Text
            });

            var rs = new Database().Execute(sql, lstPara);
            if(rs==1)
            {
                if(string.IsNullOrEmpty(mmh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin môn học thành công");
                }
                this.Dispose();
            }else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại, tên môn học không thể trùng với danh sách đã có");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
