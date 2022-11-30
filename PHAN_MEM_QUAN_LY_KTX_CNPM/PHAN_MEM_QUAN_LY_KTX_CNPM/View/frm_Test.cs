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
    public partial class frm_Test : Form
    {
        public frm_Test()
        {
            InitializeComponent();
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            frm_Phong fmPhong = new frm_Phong();
            fmPhong.ShowDialog();
        }

        private void btn_SinhVien_Click(object sender, EventArgs e)
        {
            frm_PhiSinhVien fmPhiSV = new frm_PhiSinhVien();
            fmPhiSV.ShowDialog();
        }
    }
}
