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
        private string user;
        private string role;
        private ThongBao_BUS tbBus;
        public frm_ThongBao(string user = "", string role = "")
        {
            InitializeComponent();
            tbBus = new ThongBao_BUS();
            this.user = user;
            this.role = role;
        }
        public void LoadData_NQL()
        {
            dgvThongBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongBao.DataSource = tbBus.GetAllInformation();
            LoadDateTime();
        }
        public void LoadData_SV()
        {
            dgvThongBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongBao.DataSource = tbBus.GetAllInformation();
            gbTb.Hide();
            btnGui.Hide();
            btnHuy.Hide();
            btnLuu.Hide();
        }
        public void LoadDateTime()
        {
            dtpNgayDang.Value = DateTime.Now;
        }
        private void frm_ThongBao_Load(object sender, EventArgs e)
        {
            if (role == "Quản Lý")
            {
                LoadData_NQL();
                gbTb.Enabled = false;
            }
            else
            {
                LoadData_SV();
            }    
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
