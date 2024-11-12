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
    public partial class Sach : Form
    {
        private KetNoi ketNoi;
        public Sach()
        {
            InitializeComponent();
            ketNoi = new KetNoi(); // Khởi tạo đối tượng KetNoi
            LoadData(); // Tải dữ liệu sách
            LoadLoaiSach(); // Tải dữ liệu loại sách vào ComboBox
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Sach";
            DataSet ds = ketNoi.LayDuLieu(query);
            if (ds != null && ds.Tables.Count > 0)
            {
                dgvSach.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadLoaiSach()
        {
            string query = "SELECT MaLoaiSach, TenLoaiSach FROM LoaiSach";
            DataSet ds = ketNoi.LayDuLieu(query);
            if (ds != null && ds.Tables.Count > 0)
            {
                cboLoaiSach.DataSource = ds.Tables[0];
                cboLoaiSach.DisplayMember = "TenLoaiSach";
                cboLoaiSach.ValueMember = "MaLoaiSach";
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Sach (TenSach, TacGia, GiaBan, SoLuongTrongKho, MoTa, MaLoaiSach) " +
                   $"VALUES (N'{txtTenSach.Text}', N'{txtTacGia.Text}', {txtGiaBan.Text}, {txtSoLuong.Text}, N'{txtMoTa.Text}', {cboLoaiSach.SelectedValue})";

            if (ketNoi.ThucThi(query))
            {
                MessageBox.Show("Thêm sách thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi thêm
            }
            else
            {
                MessageBox.Show("Không thể thêm sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Sach SET TenSach = N'{txtTenSach.Text}', TacGia = N'{txtTacGia.Text}', GiaBan = {txtGiaBan.Text}, " +
                   $"SoLuongTrongKho = {txtSoLuong.Text}, MoTa = N'{txtMoTa.Text}', MaLoaiSach = {cboLoaiSach.SelectedValue} " +
                   $"WHERE MaSach = {txtMaSach.Text}";

            if (ketNoi.ThucThi(query))
            {
                MessageBox.Show("Sửa sách thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi sửa
            }
            else
            {
                MessageBox.Show("Không thể sửa sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM Sach WHERE MaSach = {txtMaSach.Text}";

            if (ketNoi.ThucThi(query))
            {
                MessageBox.Show("Xóa sách thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại dữ liệu sau khi xóa
            }
            else
            {
                MessageBox.Show("Không thể xóa sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Sach WHERE TenSach LIKE N'%{txtTimKiem.Text}%'";
            DataSet ds = ketNoi.LayDuLieu(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                dgvSach.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách nào.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuongTrongKho"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                cboLoaiSach.SelectedValue = row.Cells["MaLoaiSach"].Value;
            }
        }
    }
}
