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
    public partial class frm_Phong : Form
    {
        private Phong_BUS PhongBUS;
        public frm_ChiTietPhong fmChiTietPhong;
        public frm_Trangchu fmTrangchu;
        public string maphong;
        private frm_HoaDon fmHD;

        public frm_Phong()
        {
            InitializeComponent();
            PhongBUS = new Phong_BUS();
        }

        public void LoadDataAdmin()
        {
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.DataSource = PhongBUS.GetAllInformation();
        }
        public void LoadTextBox_CheckBox()
        {
            cbTinhTrang.Checked = true;
            int SVHienTai = 0;
            txtSVHienTai.Text = SVHienTai.ToString();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            int r = dgvPhong.CurrentCell.RowIndex;
            maphong = dgvPhong.Rows[r].Cells[0].Value.ToString();
            fmHD = new frm_HoaDon();
            fmHD.maphong = maphong;

            panel_child.Visible = false;
            main_panel.Visible = true;
            main_panel.Controls.Clear();
            fmHD.TopLevel = false;
            main_panel.Controls.Add(fmHD);
            fmHD.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmHD.Dock = DockStyle.Fill;
            fmHD.Show();
        }

        private void frm_Phong_Load(object sender, EventArgs e)
        {
            LoadDataAdmin();
            gbThongTinPhong.Enabled = false;
            LoadTextBox_CheckBox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panel_child.Visible = false;
            main_panel.Visible = true; main_panel.Controls.Clear();

            frm_Phong fmphong = new frm_Phong();
            fmphong.TopLevel = false;
            main_panel.Controls.Add(fmphong);
            fmphong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmphong.Dock = DockStyle.Fill;
            fmphong.Show();
        }
    }
}
