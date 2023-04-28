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
    public partial class frmKetQuaHocTap : Form
    {
        public frmKetQuaHocTap(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private string masv;
        private string tukhoa = " ";
        private void LayNganh()
        {

        }
        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();
        }
        private void LoadKQHT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvTraCuuDiem.DataSource = new Database().SelectData("tracuudiem", lstPara);
            dgvTraCuuDiem.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvTraCuuDiem.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvTraCuuDiem.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvTraCuuDiem.Columns["diem10"].HeaderText = "Điểm 10%";
            dgvTraCuuDiem.Columns["diem40"].HeaderText = "Điểm 40%";
            dgvTraCuuDiem.Columns["diem50"].HeaderText = "Điểm 50%";
            dgvTraCuuDiem.Columns["tongket"].HeaderText = "Điểm tổng kết";

            var r = new Database().Select("exec DiemTbhe10 '"+masv+"'");
            txtDTB.Text = r["diemtbhe10"].ToString();

            var rs = new Database().Select("exec Tongtinchi '" + masv + "'");
            txtTinChi.Text = rs["tongsotinchi"].ToString();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            tukhoa = txtTraCuu.Text;
            LoadKQHT();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgvTraCuuDiem.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dgvTraCuuDiem.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvTraCuuDiem.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTraCuuDiem.Columns.Count; j++)
                {
                    if (dgvTraCuuDiem.Rows[i].Cells[j].Value != null)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvTraCuuDiem.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void btnDky_Click(object sender, EventArgs e)
        {
            float tongtinchi = int.Parse(txtTinChi.Text);
            MessageBox.Show(tongtinchi.ToString());
        }

        private void btnCrystalReport_Click(object sender, EventArgs e)
        {
            frmBaoCaoDiem bc = new frmBaoCaoDiem(masv);
            bc.ShowDialog();
        }
    }
}
