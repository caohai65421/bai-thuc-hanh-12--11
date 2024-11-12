using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_thuc_hanh_12_11
{
    public partial class LoaiSach : Form
    {
        private KetNoi ketNoi;
        public LoaiSach()
        {
            InitializeComponent();
            ketNoi = new KetNoi(); // Khởi tạo đối tượng KetNoi
            LoadData(); // Tải dữ liệu khi form được mở
        }
        private void LoadData()
        {
            // Câu truy vấn để lấy danh sách loại sách
            string query = "SELECT MaLoaiSach, TenLoaiSach, MoTa FROM LoaiSach";

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataSet ds = ketNoi.LayDuLieu(query);

            // Kiểm tra và gán dữ liệu cho DataGridView nếu DataSet không rỗng
            if (ds != null && ds.Tables.Count > 0)
            {
                dgvLoaiSach.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
