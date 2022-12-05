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
    public partial class frm_QuanLyPhong : Form
    {
        public delegate void SendMessage(String value);

        public frm_ChiTietPhong fmChiTietPhong;
        public frm_Phong fmPhong;
        public frm_Trangchu fmTrangchu;
        public string maphong;
        private frm_HoaDon fmHoaDon;


        public int sk;
        public string MaPhong1;
        public static bool them = true;

        public frm_QuanLyPhong()
        {
            InitializeComponent();
            fmPhong = new frm_Phong(SendSK, SendMP);
        }

        private void SendSK(String value)
        {
            sk = int.Parse(value);
        }

        private void SendMP(String value)
        {
            maphong = value;
        }

        private void frm_QuanLyPhong_Load(object sender, EventArgs e)
        {
            panel_loadform.Visible = true;
            panel_loadform.Controls.Clear();
            fmPhong = new frm_Phong(SendSK, SendMP);
            fmPhong.TopLevel = false;
            panel_loadform.Controls.Add(fmPhong);
            fmPhong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmPhong.Dock = DockStyle.Fill;
            fmPhong.Show();
        }

        private void hoadon_menu_Click(object sender, EventArgs e)
        {
            if ( sk == 1 )
            {
                chitietphong_menu.Enabled = false;
                thietbi_menu.Enabled = false;
                panel_loadform.Visible = true;
                panel_loadform.Controls.Clear();
                fmHoaDon = new frm_HoaDon();
                fmHoaDon.maphong = maphong;
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
            if ( sk == 1)
            {
                hoadon_menu.Enabled = false;
                thietbi_menu.Enabled = false;
                panel_loadform.Visible = true;
                panel_loadform.Controls.Clear();
                fmChiTietPhong = new frm_ChiTietPhong();
                fmChiTietPhong.maphong = maphong;
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
            
            if (sk == 1)
            {
                hoadon_menu.Enabled = false;
                chitietphong_menu.Enabled = false;
                /* panel_loadform.Visible = true;                        đổi tên form
                 panel_loadform.Controls.Clear();
                 fmChiTietPhong = new frm_ChiTietPhong();
                 fmChiTietPhong.maphong = maphong;
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
            hoadon_menu.Enabled = true;
            thietbi_menu.Enabled = true;
            chitietphong_menu.Enabled = true;
            panel_loadform.Visible = true;
            panel_loadform.Controls.Clear();
            fmPhong.TopLevel = false;
            panel_loadform.Controls.Add(fmPhong);
            fmPhong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmPhong.Dock = DockStyle.Fill;
            fmPhong.Show();
        }
    }
}
