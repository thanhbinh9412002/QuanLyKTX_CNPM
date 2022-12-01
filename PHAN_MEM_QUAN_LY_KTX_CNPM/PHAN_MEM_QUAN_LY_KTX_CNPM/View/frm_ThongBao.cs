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
    public partial class frm_ThongBao : Form
    {
        private ThongBao_BUS tbBus;
        public frm_ThongBao()
        {
            InitializeComponent();
            tbBus = new ThongBao_BUS();
        }
        public void LoadData_NQL()
        {
            dgvThongBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongBao.DataSource = tbBus.GetAllInformation();
            LoadDateTime();
        }
        public void LoadDateTime()
        {
            dtpNgayDang.Value = DateTime.Now;
        }
        private void frm_ThongBao_Load(object sender, EventArgs e)
        {
            LoadData_NQL();
            gbTb.Enabled = false;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            gbTb.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tbBus.GuiThongBao(txtTieuDe.Text, txtNoiDung.Text, dtpNgayDang.Value);
            txtTieuDe.Clear();
            txtNoiDung.Clear();
            LoadData_NQL();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
            txtTieuDe.Clear();
        }
    }
}
