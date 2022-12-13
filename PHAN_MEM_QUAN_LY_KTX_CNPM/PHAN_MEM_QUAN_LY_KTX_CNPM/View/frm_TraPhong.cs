using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHAN_MEM_QUAN_LY_KTX_CNPM.BUS;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    public partial class frm_TraPhong : Form
    {
        public frm_Trangchu fmTrangChu;
        public string maphong;
        public string masv;
        public frm_TraPhong()
        {
            InitializeComponent();
        }

        private void btn_goi_Click(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            string trangthai = "Chưa xem";
            TimeSpan Time = dateTimePicker_ngaytra.Value.Date - DateTime.Now.Date;
            int tongngay = Time.Days;
            if (tongngay < 30)
            {
                MessageBox.Show("Bạn phải thông báo với ban quản lý KTX  tối thiểu trước một tháng nếu muốn trả phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ycBUS.ThemTraPhong(txt_maphong.Text, txt_masv.Text, dateTimePicker_ngaytra.Value, trangthai) > 0)
                {
                    MessageBox.Show("Yêu cầu của bạn đã được gởi cho ban quản lý KTX!. Ban quản lý KTX sẽ phản hồi lại cho bạn sớm nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void frm_TraPhong_Load(object sender, EventArgs e)
        {
            fmTrangChu = new frm_Trangchu();
            dateTimePicker_ngaytra.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month , DateTime.Now.Day);
            txt_maphong.Text = maphong;
            txt_masv.Text = masv;
            txt_maphong.Enabled = false;
            txt_masv.Enabled = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            dateTimePicker_ngaytra.Focus();
        }
    }
}
