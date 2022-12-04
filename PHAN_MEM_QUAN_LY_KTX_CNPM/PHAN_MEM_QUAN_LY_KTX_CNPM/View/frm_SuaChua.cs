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
    public partial class frm_SuaChua : Form
    {
        public frm_SuaChua()
        {
            InitializeComponent();
        }

        private void btn_goi_Click(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            string trangthai = "Chưa xem";
            if (ycBUS.ThemSuaChua(cbb_tenthietbi_suachua.Text,int.Parse(txt_soluong_suachua.Texts), txt_chitiet_suachua.Texts, trangthai) > 0)
            {
                MessageBox.Show("Yêu cầu của bạn đã được gởi cho ban quản lý KTX!. Ban quản lý KTX sẽ phản hồi lại cho bạn sớm nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_SuaChua_Load(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            cbb_tenthietbi_suachua.DataSource = ycBUS.DanhSachTenThietBi();
            cbb_tenthietbi_suachua.DisplayMember = "TenThietBi";
            cbb_tenthietbi_suachua.ValueMember = "TenThietBi";
        }
    }
}
