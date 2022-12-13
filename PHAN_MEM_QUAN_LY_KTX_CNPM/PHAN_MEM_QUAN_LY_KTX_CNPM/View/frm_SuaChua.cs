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
        public string maphong;
        public frm_SuaChua()
        {
            InitializeComponent();
        }

        private void btn_goi_Click(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            string trangthai = "Chưa xem";
            if (ycBUS.ThemSuaChua(txt_maphong_suachua.Text,cbb_tenthietbi_suachua.Text,int.Parse(txt_soluong_suachua.Text), txt_chitiet_suachua.Text, trangthai) > 0)
            {
                if(MessageBox.Show("Yêu cầu của bạn đã được gởi cho ban quản lý KTX!. Ban quản lý KTX sẽ phản hồi lại cho bạn sớm nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txt_soluong_suachua.ResetText();
                    txt_chitiet_suachua.ResetText();
                    cbb_tenthietbi_suachua.Focus();
                }    
            }
            else
            {
               if( MessageBox.Show("Đã có lỗi xảy ra! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    cbb_tenthietbi_suachua.Focus();
                }    
            }
        }

        private void frm_SuaChua_Load(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            cbb_tenthietbi_suachua.DataSource = ycBUS.DanhSachTenThietBi();
            cbb_tenthietbi_suachua.DisplayMember = "TenThietBi";
            cbb_tenthietbi_suachua.ValueMember = "TenThietBi";
            txt_maphong_suachua.Text = maphong;
            txt_maphong_suachua.Enabled = false;
            cbb_tenthietbi_suachua.Focus();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_soluong_suachua.ResetText();
            txt_chitiet_suachua.ResetText();
            cbb_tenthietbi_suachua.Focus();
        }
    }
}
