using PHAN_MEM_QUAN_LY_KTX_CNPM.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    public partial class frm_ThongTinCaNhan : Form
    {
        SinhVien_BUS SinhvienBUS = new SinhVien_BUS();
        public string mssv = null;
        public frm_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frm_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadthongtinsinhvien(mssv);
            MessageBox.Show(mssv);
        }
        public void loadthongtinsinhvien(string mssv)
        {
            DataTable table = SinhvienBUS.thongtincanhan(mssv);
            text_mssv.Text = table.Rows[0].Field<string>(0);
            text_hoten.Text = table.Rows[0].Field<string>(1);
            text_sdt.Text = table.Rows[0].Field<string>(2);
            text_gioitinh.Text = table.Rows[0].Field<string>(3);
            text_namhoc.Text = table.Rows[0].Field<int>(4).ToString();
            text_tongiao.Text = table.Rows[0].Field<string>(5);
            text_quoctich.Text = table.Rows[0].Field<string>(6);
            text_cccd.Text = table.Rows[0].Field<string>(7);
            text_maphong.Text = table.Rows[0].Field<string>(8);
            text_soky.Text = table.Rows[0].Field<int>(9).ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int namhoc = Int32.Parse(text_namhoc.Text);
            int soky = Int32.Parse(text_soky.Text);
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thay đổi?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                SinhvienBUS.Suasinhvien(text_mssv.Text, text_hoten.Text, text_sdt.Text, text_gioitinh.Text, namhoc, text_tongiao.Text, text_quoctich.Text, text_cccd.Text, text_maphong.Text, soky);
                loadthongtinsinhvien(mssv);
            }
        }
    }
}
