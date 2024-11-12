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
    public partial class ThongKe : Form
    {
        private KetNoi ketNoi;
        public ThongKe()
        {
            InitializeComponent();
            ketNoi = new KetNoi();
            LoadNgayThangNam(); 
        }
        private void LoadNgayThangNam()
        {
            // Tải các giá trị ngày
            for (int i = 1; i <= 31; i++)
            {
                cboNgay.Items.Add(i);
            }

            // Tải các giá trị tháng
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i);
            }

            // Tải các giá trị năm
            string query = "SELECT DISTINCT YEAR(NgayLap) AS Nam FROM HoaDon ORDER BY Nam";
            DataSet ds = ketNoi.LayDuLieu(query);
            if (ds != null && ds.Tables.Count > 0)
            {
                cboNam.DataSource = ds.Tables[0];
                cboNam.DisplayMember = "Nam";
                cboNam.ValueMember = "Nam";
            }
        }
        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
