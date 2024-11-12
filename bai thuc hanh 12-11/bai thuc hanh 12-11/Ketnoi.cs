using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
namespace bai_thuc_hanh_12_11
{
   class KetNoi
    {
        // Chuỗi kết nối đến cơ sở dữ liệu
        private string conStr = "Server=ADMIN;Database=NhaSach;User Id=sa;Password=123;Integrated Security=true; TrustServerCertificate=true;";
        private SqlConnection conn;

        // Constructor để khởi tạo đối tượng SqlConnection
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }

        // Phương thức để lấy dữ liệu từ cơ sở dữ liệu
        public DataSet LayDuLieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra khi lấy dữ liệu: " + ex.Message);
                return null;
            }
        }

        // Phương thức để thực thi các câu lệnh SQL (INSERT, UPDATE, DELETE)
        public bool ThucThi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0; // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra khi thực thi: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
