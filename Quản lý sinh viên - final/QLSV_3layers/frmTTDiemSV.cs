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
    public partial class frmTTDiemSV : Form
    {
        private string mgv;
        private string masv;
        private string malh;
        private string diem10;
        private string diem40;
        private string diem50;
        public frmTTDiemSV(string mgv,string masv,string malh, string diem10, string diem40, string diem50)
        {
            this.mgv = mgv;
            this.masv = masv;
            this.malh = malh;
            this.diem10 = diem10;
            this.diem40 = diem40;
            this.diem50 = diem50;
            InitializeComponent();
        }

        private void frmTTDiemSV_Load(object sender, EventArgs e)
        {
            frmDiemSV_Load();
        }

        private void frmDiemSV_Load()
        {
            txtDiem10.Text = diem10.ToString();
            txtDiem40.Text = diem40.ToString();
            txtDiem50.Text = diem50.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string diem10 = txtDiem10.Text;
                string diem40 = txtDiem40.Text;
                string diem50 = txtDiem50.Text;
                float d10 = float.Parse(diem10);
                float d40 = float.Parse(diem40);
                float d50 = float.Parse(diem50);

                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@msv",
                    value = masv
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@mlh",
                    value = malh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = mgv, 
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@diem10",
                    value = d10.ToString()
                    /*
                float i1 = float.Parse(s1);
                float i2 = float.Parse(s2);
                float kq = i1 / i2;
                txtketqua.Text = kq.ToString();
                     */
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@diem40",
                    value = d40.ToString()
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@diem50",
                    value = d50.ToString()
                });

                var rs = new Database().Execute("updateDiem", lstPara);
                if (rs != 1)
                {
                    MessageBox.Show("Cập nhật điểm thành công");
                }
                else
                {
                    MessageBox.Show("Thực thi thất bại");
                }
                this.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập đủ loại điểm/nhập sai định dạng điểm-điểm phải là số "+ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
