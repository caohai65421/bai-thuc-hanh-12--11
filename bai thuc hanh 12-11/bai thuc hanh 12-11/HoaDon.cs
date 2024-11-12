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
    public partial class HoaDon : Form
    {
        private KetNoi ketNoi;
        public HoaDon()
        {
            InitializeComponent();
            ketNoi = new KetNoi(); // Khởi tạo đối tượng KetNoi
            LoadData(); // Tải dữ liệu hóa đơn
        }
        private void LoadData()
        {
            string query = "SELECT * FROM HoaDon";
            DataSet ds = ketNoi.LayDuLieu(query);
            if (ds != null && ds.Tables.Count > 0)
            {
                dgvHoaDon.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO HoaDon (NgayLap, MaKhachHang) " +
                   $"VALUES ('{dtpNgayLap.Value.ToString("yyyy-MM-dd")}', {txtMaKhachHang.Text})";

            if (ketNoi.ThucThi(query))
            {
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thể thêm hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE HoaDon SET NgayLap = '{dtpNgayLap.Value.ToString("yyyy-MM-dd")}', " +
                   $"MaKhachHang = {txtMaKhachHang.Text} WHERE MaHoaDon = {txtMaHoaDon.Text}";

            if (ketNoi.ThucThi(query))
            {
                MessageBox.Show("Sửa hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thể sửa hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM HoaDon WHERE MaHoaDon = {txtMaHoaDon.Text}";

            if (ketNoi.ThucThi(query))
            {
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thể xóa hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM HoaDon WHERE MaHoaDon LIKE '%{txtTimKiem.Text}%'";
            DataSet ds = ketNoi.LayDuLieu(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                dgvHoaDon.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells["MaHoaDon"].Value.ToString();
                dtpNgayLap.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value.ToString();
            }
        }

    }
}
