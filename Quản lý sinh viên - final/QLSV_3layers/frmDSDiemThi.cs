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
    public partial class frmDSDiemThi : Form
    {
        public frmDSDiemThi()
        {
            InitializeComponent();
        }

        public static implicit operator frmDSDiemThi(frmDSMH v)
        {
            throw new NotImplementedException();
        }

        private void frmDSDiemThi_Load(object sender, EventArgs e)
        {

        }
    }
}
