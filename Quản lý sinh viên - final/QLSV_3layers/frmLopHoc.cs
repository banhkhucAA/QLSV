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
    public partial class frmLopHoc : Form
    {
        private string malophoc;
        private string tukhoa = "";
        private Database db;
        public frmLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };

            //cbbMonhoc.DataSource = db.SelectData("selectmonhoc",lstPara);
            cbbMonhoc.DataSource = db.Lay_DuLieuBang("select distinct*from tblMonhoc");
            cbbMonhoc.DisplayMember = "tenmonhoc";
            cbbMonhoc.ValueMember = "mamonhoc";
            cbbMonhoc.SelectedIndex = -1;

            for (int i = 1; i <= 8; i++)
            {
                cbbCa.Items.Add(i);
            }
            cbbCa.SelectedIndex = -1;

            for (int i = 2; i <= 7; i++)
            {
                cbbThu.Items.Add(i);
            }
            cbbThu.SelectedIndex = -1;

            /////
            

            if (String.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học phần";
                mtbdate.Visible = false;
                lbNgayThi.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật lớp học phần";
                var r = db.Select("exec selectLophoc'" + malophoc + "'");
                cbbMonhoc.SelectedValue = r["mamonhoc"].ToString();
                cbbCa.Text = r["ca"].ToString();
                cbbThu.Text = r["thu"].ToString();
                cbbToa.Text = r["toanha"].ToString();
                cbbPhong.Text = r["phong"].ToString();
                mtbdate.Text = r["lichthi"].ToString();
            }
            cbbPhong.Enabled = false;
            btnHuyXacNhan.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ca = cbbCa.Text;
            string thu = cbbThu.Text;
            string toa = cbbToa.Text;
            string phong = cbbPhong.Text;
            
            if (cbbMonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học trong danh sách");
                cbbMonhoc.Select();
                return;
            }            
            if (cbbCa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ca học trong danh sách");
                cbbCa.Select();
                return;
            }
            if (cbbThu.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ngày học trong danh sách");
                cbbThu.Select();
                return;
            }
            if (cbbToa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tòa học trong danh sách");
                cbbToa.Select();
                return;
            }
            if (cbbPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phòng học trong danh sách");
                cbbPhong.Select();
                return;
            }


            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (String.IsNullOrEmpty(malophoc))
            {
                sql = "insertLopHoc";
            }
            else
            {
                sql = "updateLopHoc";
                DateTime ngaythi;
                try
                {
                    ngaythi = DateTime.ParseExact(mtbdate.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ngày thi không hợp lệ");
                    mtbdate.Select();// tro chuot ve mtbNgaySinh
                    return;
                }
                lstPara.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@lichthi",
                    value = ngaythi.ToString("yyyy-mm-dd")
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = cbbMonhoc.SelectedValue.ToString()
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Ca",
                value = ca
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Thu",
                value = thu
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@toanha",
                value = toa
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@phong",
                value = phong
            });

            var rs = db.Execute(sql, lstPara);
            if (rs == 1)
            {
                if (String.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm mới lớp học phần thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật học phần thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại,hãy kiểm tra lại các thông tin sau:\n\n 1. Bạn đang không thực hiện bất kỳ thay đổi nào\n\n 2. Phòng học bạn chọn đang được dùng vào thời gian này");
                this.Dispose();
            }
        
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbbToa.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn và xác nhận tòa nhà trong danh sách");
                cbbToa.Select();
                return;
            }
            else
            {
                cbbPhong.Enabled = true;
                cbbToa.Enabled = false;
            }
            switch (cbbToa.Text)
            {
                case "B":
                    {
                        cbbPhong.Items.Clear();
                        for (int i = 100; i <= 103; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        for (int i = 200; i <= 203; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        for (int i = 300; i <= 303; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        break;
                    }
                case "C":
                    {
                        cbbPhong.Items.Clear();
                        for (int i = 100; i <= 103; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        break;
                    }
                case "D":
                    {
                        cbbPhong.Items.Clear();
                        for (int i = 100; i <= 103; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        break;
                    }
                case "A2":
                    {
                        cbbPhong.Items.Clear();
                        for (int i = 100; i <= 103; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        for (int i = 200; i <= 203; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        for (int i = 300; i <= 303; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        for (int i = 400; i <= 403; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        for (int i = 500; i <= 503; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        for (int i = 600; i <= 603; i++)
                        {
                            cbbPhong.Items.Add(i);
                        }
                        break;
                    }
            }
            btnXacNhan.Enabled = false;
            btnHuyXacNhan.Enabled = true;
        }

        private void btnHuyXacNhan_Click(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = true;
            btnHuyXacNhan.Enabled = false;
            cbbToa.Enabled = true;
            cbbPhong.Enabled = false;
        }
    }
}
