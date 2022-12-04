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
        public frm_TraPhong()
        {
            InitializeComponent();
        }

        private void btn_goi_Click(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            string trangthai = "Chưa xem";
            if (ycBUS.ThemTraPhong(txt_maphong.Texts ,txt_masv.Texts, dateTimePicker_ngaytra.Value, trangthai) > 0)
            {
                MessageBox.Show("Yêu cầu của bạn đã được gởi cho ban quản lý KTX!. Ban quản lý KTX sẽ phản hồi lại cho bạn sớm nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void frm_TraPhong_Load(object sender, EventArgs e)
        {
            dateTimePicker_ngaytra.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
    }
}
