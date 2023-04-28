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
    public partial class frmBaoCaoDiem : Form
    {
        private string masv;
        public frmBaoCaoDiem(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        Database kn = new Database();

        private void frmBaoCaoDiem_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql = string.Format("xuatfilediem '{0}'",masv);
            dta = kn.Lay_DuLieuBang(sql);
            BaoCaoDiem baocao = new BaoCaoDiem();
            baocao.SetDataSource(dta);
            crvBaoCaoDiem.ReportSource = baocao;
        }
    }
}
