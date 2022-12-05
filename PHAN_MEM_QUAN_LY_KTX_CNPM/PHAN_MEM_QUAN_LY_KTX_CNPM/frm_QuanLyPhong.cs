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
    public partial class frm_QuanLyPhong : Form
    {
        frm_Phong fmPhong;
        frm_HoaDon fmHoaDon;
        public frm_ChiTietPhong fmChiTietPhong;

        public frm_QuanLyPhong()
        {
            InitializeComponent();
        }

        private void frm_QuanLyPhong_Load(object sender, EventArgs e)
        {
            panel_loadform.Visible = true;
            panel_loadform.Controls.Clear();
            fmPhong = new frm_Phong();
            fmPhong.TopLevel = false;
            panel_loadform.Controls.Add(fmPhong);
            fmPhong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmPhong.Dock = DockStyle.Fill;
            fmPhong.Show();
        }

        private void hoadon_menu_Click(object sender, EventArgs e)
        {
            fmPhong = new frm_Phong();
            if ( fmPhong.sukien == 1 )
            {
                panel_loadform.Visible = true;
                panel_loadform.Controls.Clear();
                fmHoaDon = new frm_HoaDon();
                fmHoaDon.TopLevel = false;
                panel_loadform.Controls.Add(fmHoaDon);
                fmHoaDon.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmHoaDon.Dock = DockStyle.Fill;
                fmHoaDon.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng cần xem. Mời chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void chitietphong_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sk.ToString());
            fmPhong = new frm_Phong();
            if (fmPhong.sukien == 1)
            {
                panel_loadform.Visible = true;
                panel_loadform.Controls.Clear();
                fmChiTietPhong = new frm_ChiTietPhong();
                fmChiTietPhong.TopLevel = false;
                panel_loadform.Controls.Add(fmChiTietPhong);
                fmChiTietPhong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmChiTietPhong.Dock = DockStyle.Fill;
                fmChiTietPhong.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng cần xem. Mời chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thietbi_menu_Click(object sender, EventArgs e)
        {
            fmPhong = new frm_Phong();
            if (fmPhong.sukien == 1)
            {
                /* panel_loadform.Visible = true;                        Đổi tên form -- chi tiết hóa đơn
                panel_loadform.Controls.Clear();
                fmChiTietPhong = new frm_ChiTietPhong();
                fmChiTietPhong.TopLevel = false;
                panel_loadform.Controls.Add(fmChiTietPhong);
                fmChiTietPhong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fmChiTietPhong.Dock = DockStyle.Fill;
                fmChiTietPhong.Show();*/
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng cần xem. Mời chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void quaylai_menu_Click(object sender, EventArgs e)
        {
            panel_loadform.Visible = true;
            panel_loadform.Controls.Clear();
            fmPhong = new frm_Phong();
            fmPhong.TopLevel = false;
            panel_loadform.Controls.Add(fmPhong);
            fmPhong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmPhong.Dock = DockStyle.Fill;
            fmPhong.Show();
        }
    }
}
