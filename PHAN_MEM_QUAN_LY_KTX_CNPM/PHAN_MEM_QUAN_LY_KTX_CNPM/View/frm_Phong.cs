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
        private void frm_Phong_Load(object sender, EventArgs e)
        {
            LoadDataAdmin();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            int r = dgvPhong.CurrentCell.RowIndex;
            maphong = dgvPhong.Rows[r].Cells[0].Value.ToString();

            fmHD = new frm_HoaDon();
            fmHD.maphong = maphong;
            fmHD.Show();
        }
    }
}
