using System;
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
    public partial class frm_ChitietHoaDon : Form
    {
        public string mahd;
        private frm_HoaDon fmHD;
        private ChitietHD_BUS ChitietHDBUS;
        public frm_ChitietHoaDon()
        {
            InitializeComponent();
            fmHD = new frm_HoaDon();
            mahd = fmHD.mahd;
            ChitietHDBUS = new ChitietHD_BUS();
        }

        private void frm_ChitietHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataAdmin();
        }
        public void LoadDataAdmin()
        {
            dgvChitietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChitietHD.DataSource = ChitietHDBUS.GetAllInformation(mahd);
        }
    }
}
