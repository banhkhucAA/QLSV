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
    public partial class frmBaoCaoPhanLop : Form
    {
        private string magv;
        public frmBaoCaoPhanLop(string magv)
        {
            this.magv = magv;
            InitializeComponent();
        }

        Database kn = new Database();

        private void Lay_Magiaovien()
        {
            string sql = "duyet_giaovienbomon '" + magv + "'";
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang(sql);
            cbbMaGiaoVien.DataSource = dta;
            cbbMaGiaoVien.DisplayMember = "magiaovien";
            cbbMaGiaoVien.ValueMember = "magiaovien";
        }

        private void frmBaoCaoPhanLop_Load(object sender, EventArgs e)
        {
            Lay_Magiaovien();

        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            string sql = "Select*from giaovien where magiaovien = '" + cbbMaGiaoVien.Text + "'";
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang(sql);
            BaoCaoPhanLop baocao = new BaoCaoPhanLop();
            baocao.SetDataSource(dta);
            crvBaoCaoLop.ReportSource = baocao;
        }
    }
}
