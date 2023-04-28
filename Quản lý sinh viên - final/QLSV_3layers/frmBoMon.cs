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
    public partial class frmBoMon : Form
    {
        private string tukhoa = "";
        public frmBoMon()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            bomon_load();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmcapnhat_thembm(null).ShowDialog(); //neu them moi, ma sinh vien = null
            bomon_load();
        }

        private void frmBoMon_Load(object sender, EventArgs e)
        {
            bomon_load();
        }

        private void bomon_load()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvBoMon.DataSource = null;
            dgvBoMon.DataSource = new Database().SelectData("Selectbomon", lstPara);
            dgvBoMon.Columns["mabomon"].HeaderText = "Mã bộ môn";
            dgvBoMon.Columns["tenbomon"].HeaderText = "Tên bộ môn";
            dgvBoMon.Columns["makhoa_vien"].HeaderText = "Mã khoa - viện";
        }

        private void dgvBoMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvBoMon.Columns["btnDelete"].Index)
                {
                    var mabm = dgvBoMon.Rows[e.RowIndex].Cells["mabomon"].Value.ToString();
                    var sql = "xoabomon";
                    var lstPara = new List<CustomParameter>
                    {
                        new CustomParameter()
                        {
                            key = "@mabomon",
                            value = mabm
                        }
                    };
                    var result = new Database().Execute(sql, lstPara);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa giáo viên thành công");
                        bomon_load();
                    }
                }
            }
        }

        private void dgvBoMon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mbm = dgvBoMon.Rows[e.RowIndex].Cells["mabomon"].Value.ToString();
                new frmcapnhat_thembm(mbm).ShowDialog();
                bomon_load();
            }
        }
    }
}
