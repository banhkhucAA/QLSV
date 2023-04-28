using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    class Database
    {
        private string connectionstring = @"Data Source=DESKTOP-5985LPQ\ANDANHMOON;Initial Catalog=TestwithC#;Integrated Security=True";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter ada;
        public Database() //khoi tao ket noi
        {
            try
            {
                conn = new SqlConnection(connectionstring);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("connected fail" + Ex.Message);
            }
        }

        public DataTable SelectData(String sql,List<CustomParameter> lstPara) //truy van voi csdl
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;//set cmd type cho cmd
                foreach(var para in lstPara)//gans cacs tham soos cho cmd
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Loi load du lieu" + ex.Message);
                return null;
            }finally
            {
                conn.Close();
            }
        }
        public DataRow Select(string sql) //return toan bo du lieu cua 1 hang duy nhat
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int Execute(string sql,List<CustomParameter> lstPara)//nonquery
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);//nap cau lenh sql
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstPara)//gan cac tham so cho list
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();//lay ket qua thuc thi truy van
                return (int)rs;
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
        }

        public DataTable Lay_DuLieuBang(string Sql)
        {
            try
            {
                ada = new SqlDataAdapter(Sql, conn);
                dt = new DataTable();
                ada.Fill(dt);
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return null;
            }
        }

        public void ThucThi(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh" + ex.Message);
            }finally
            {
                conn.Close();
            }

        }
    }
}