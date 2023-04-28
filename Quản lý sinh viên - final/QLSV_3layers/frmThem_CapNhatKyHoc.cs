using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmThem_CapNhatKyHoc : Form
    {
        private string makyhoc;
        public frmThem_CapNhatKyHoc(string makyhoc)
        {
            this.makyhoc = makyhoc;
            InitializeComponent();
        }

        Database kn = new Database();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThem_CapNhatKyHoc_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(makyhoc))
            {

            }
            else
            {
                var r = kn.Select("exec selectkyhoc'" + makyhoc + "'");
                mtbNBD.Text = r["thoigianbatdau"].ToString();
                mtbNKT.Text = r["thoigianketthuc"].ToString();
                mtbNDK.Text = r["thoigianbatdaudkytin"].ToString();
                mtbNKTDK.Text = r["thoigianketthucdkytin"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            string sql;
            DateTime ngaybatdau;
            DateTime ngayketthuc;
            DateTime ngaymodky;
            DateTime ngaydongdky;
            try
            {
                ngaybatdau = DateTime.ParseExact(mtbNBD.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ");
                mtbNBD.Select();// tro chuot ve mtbNgaySinh
                return;
            }

            try
            {
                ngayketthuc = DateTime.ParseExact(mtbNKT.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày kết thúc không hợp lệ");
                mtbNKT.Select();// tro chuot ve mtbNgaySinh
                return;
            }

            try
            {
                ngaymodky = DateTime.ParseExact(mtbNDK.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ");
                mtbNDK.Select();// tro chuot ve mtbNgaySinh
                return;
            }

            try
            {
                ngaydongdky = DateTime.ParseExact(mtbNKTDK.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ");
                mtbNKTDK.Select();// tro chuot ve mtbNgaySinh
                return;
            }

            if (String.IsNullOrEmpty(makyhoc))
            {
                sql = "insertkyhoc";
            }
            else
            {
                sql = "updatekyhoc";
                lstPara.Add(new CustomParameter()
                {
                    key = "@makyhoc",
                    value = makyhoc
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@tgbd",
                value = ngaybatdau.ToString("yyyy-mm-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tgkt",
                value = ngayketthuc.ToString("yyyy-mm-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tgbddky",
                value = ngaymodky.ToString("yyyy-mm-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tgktdkytin",
                value = ngaydongdky.ToString("yyyy-mm-dd")
            });

            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(makyhoc))// neu them moi
                {
                    MessageBox.Show("Thêm mới kỳ học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin kỳ học thành công");
                }
                this.Dispose(); //dong form sau khi thuc thi xong
            }
            else
            {
                MessageBox.Show("Thực thi thất bại, ngày bắt đầu kỳ học không thể lớn hơn ngày kết thúc, ngày mở đăng ký tín chỉ không thể lớn hơn ngày kết thúc đăng ký và ngày mở đăng kí tín phải diễn ra sau khi kì học bắt đầu và trước khi kì học kết thúc");
            }
        }
    }
}
