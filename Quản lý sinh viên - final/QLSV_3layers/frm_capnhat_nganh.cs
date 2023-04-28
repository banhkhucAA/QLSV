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
    public partial class frm_capnhat_nganh : Form
    {
        private string manganh;
        private string malopchuyennganh;
        public frm_capnhat_nganh(string malopchuyennganh,string manganh)
        {
            this.manganh = manganh;
            this.malopchuyennganh = malopchuyennganh;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                if (String.IsNullOrEmpty(txtLopChuyenNganh.Text))
                {
                    MessageBox.Show("Bạn phải nhập lớp chuyên ngành");
                    txtLopChuyenNganh.Select();
                    return;
                }
                if (String.IsNullOrEmpty(txtstcRaTruong.Text))
                {
                    MessageBox.Show("Bạn phải nhập tổng số tín chỉ");
                    txtstcRaTruong.Select();
                    return;
                }

                string lcn = txtLopChuyenNganh.Text;
                string stcrt = txtstcRaTruong.Text;
                float stcrt_1 = float.Parse(stcrt);
                string manganh_1 = cbbMaNganh.Text; 
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@malopchuyennganh",
                    value = malopchuyennganh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@lopchuyennganh",
                    value = lcn
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@stcratruong",
                    value = stcrt_1.ToString()
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@manganh",
                    value = manganh_1
                });

                var rs = new Database().Execute("updateLopChuyenNganh", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Cập nhật lớp chuyên ngành thành công");
                }
                else
                {
                    MessageBox.Show("Thực thi thất bại");
                }
                this.Dispose();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_capnhat_nganh_Load(object sender, EventArgs e)
        {
            Lay_manganh();
            var r = new Database().Select("selectNH '" + malopchuyennganh + "'");
            //MessageBox.Show(r[0].ToString());
            //set cac gia tri vao component cua form
            txtLopChuyenNganh.Text = r["caclopchuyennganh"].ToString();
            txtstcRaTruong.Text = r["sotinchiratruong"].ToString();
            cbbMaNganh.Text = r["manganh"].ToString();
        }
    }
}
