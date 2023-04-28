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
    public partial class frm_new_nganhhoc : Form
    {
        public frm_new_nganhhoc()
        {
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

        private void frm_new_nganhhoc_Load(object sender, EventArgs e)
        {
            Lay_manganh();
            cbbMaNganh.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                if (String.IsNullOrEmpty(cbbMaNganh.Text))
                {
                    MessageBox.Show("Bạn phải chọn mã ngành");
                    cbbMaNganh.Select();
                    return;
                }
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

                string malopcn = txtmlcn.Text;   
                string lcn = txtLopChuyenNganh.Text;
                string stcrt = txtstcRaTruong.Text;
                string manganh = cbbMaNganh.Text;
                float stcrt_1 = float.Parse(stcrt);
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@malopchuyennganh",
                    value = malopcn
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
                    value = manganh
                });

            var rs = new Database().Execute("themLopChuyenNganh", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới lớp chuyên ngành thành công");
                } else
                {
                    MessageBox.Show("Thực thi thất bại, mã lớp chuyên ngành này đã có trong danh sách");
                }
                this.Dispose();
            
        }
    }
}
