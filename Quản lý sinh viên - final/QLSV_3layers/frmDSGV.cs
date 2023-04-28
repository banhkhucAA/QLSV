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
    public partial class frmDSGV : Form
    {
        private string taikhoan;
        private string tukhoa = "";
        public frmDSGV(string taikhoan)
        {
            this.taikhoan = taikhoan;
            InitializeComponent();
        }
        private void DSGV_load()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            gdvDSGV.DataSource = null;
            gdvDSGV.DataSource = new Database().SelectData("SelectGiaoVien", lstPara);
            gdvDSGV.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            gdvDSGV.Columns["hoten"].HeaderText = "Họ tên";
            gdvDSGV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            gdvDSGV.Columns["gt"].HeaderText = "Giới tính";
            gdvDSGV.Columns["dienthoai"].HeaderText = "Điện thoại";
            gdvDSGV.Columns["diachi"].HeaderText = "Địa chỉ";
            gdvDSGV.Columns["email"].HeaderText = "Email";
            gdvDSGV.Columns["matkhau"].HeaderText = "Mật khẩu";
            gdvDSGV.Columns["chucvu"].HeaderText = "Chức vụ";
            gdvDSGV.Columns["mabomon"].HeaderText = "Mã bộ môn";
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            DSGV_load();
        }

        
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            /*
            new frmGiaoVien(null).ShowDialog();
            DSGV_load();    
            */
            new frmGiaoVien(null,taikhoan).ShowDialog(); //neu them moi, ma sinh vien = null
            DSGV_load();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            DSGV_load();
        }

        private void gdvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = gdvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGiaoVien(mgv,taikhoan).ShowDialog();
                DSGV_load();
            }
        }

        private void gdvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                if(e.ColumnIndex==gdvDSGV.Columns["btnDelete"].Index)
                {
                    var magv = gdvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                    var sql = "deleteGV";
                    var lstPara = new List<CustomParameter>
                    {
                        new CustomParameter()
                        {
                            key = "@mgv",
                            value = magv
                        }
                    };
                    var result = new Database().Execute(sql, lstPara);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa giáo viên thành công");
                        DSGV_load();
                    }
                }
            }
        }
    }
}
