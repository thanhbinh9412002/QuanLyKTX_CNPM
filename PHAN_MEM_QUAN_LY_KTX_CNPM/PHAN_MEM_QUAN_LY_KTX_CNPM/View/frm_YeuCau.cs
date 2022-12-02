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
    public partial class frm_YeuCau : Form
    {
        private string user;
        private string role;

        frm_GiaHan fmGiaHan;
        frm_TraPhong fmTraPhong;
        frm_SuaChua fmSuaChua;

        public frm_YeuCau(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role;
        }

        private void menu_suachua_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fmSuaChua = new frm_SuaChua();
            fmSuaChua.TopLevel = false;
            panel2.Controls.Add(fmSuaChua);
            fmSuaChua.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmSuaChua.Dock = DockStyle.Fill;
            fmSuaChua.Show();
        }

        private void menu_traphong_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fmTraPhong = new frm_TraPhong();
            fmTraPhong.TopLevel = false;
            panel2.Controls.Add(fmTraPhong);
            fmTraPhong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmTraPhong.Dock = DockStyle.Fill;
            fmTraPhong.Show();
        }

        private void menu_giahan_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fmGiaHan = new frm_GiaHan();
            fmGiaHan.TopLevel = false;
            panel2.Controls.Add(fmGiaHan);
            fmGiaHan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmGiaHan.Dock = DockStyle.Fill;
            fmGiaHan.Show();
        }

        private void frm_YeuCau_Load(object sender, EventArgs e)
        {
            
        }
    }
}
