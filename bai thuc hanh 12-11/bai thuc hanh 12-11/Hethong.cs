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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhapForm = new DangNhap();
            dangNhapForm.ShowDialog(); // Hiển thị form Đăng Nhập dưới dạng hộp thoại
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiSach loaiSachForm = new LoaiSach();
            loaiSachForm.Show(); // Hiển thị form Loại Sách
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach sachForm = new Sach();
            sachForm.Show(); // Hiển thị form Sách
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hoaDonForm = new HoaDon();
            hoaDonForm.Show(); // Hiển thị form Hóa Đơn
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ứng dụng quản lý nhà sách phiên bản 1.0\nTác giả: Đội phát triển", "Giới Thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hethong_Click(object sender, EventArgs e)
        {

        }
    }
}
