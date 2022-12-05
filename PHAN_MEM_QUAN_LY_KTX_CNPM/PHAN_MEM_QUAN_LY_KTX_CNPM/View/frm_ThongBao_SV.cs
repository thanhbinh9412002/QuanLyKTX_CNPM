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
    public partial class frm_ThongBao_SV : Form
    {
        private ThongBao_BUS tbBus;
        public frm_ThongBao_SV()
        {
            InitializeComponent();
            tbBus = new ThongBao_BUS();
        }
        public void LoadData_SV()
        {
            dgvThongBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongBao.DataSource = tbBus.GetAllInformation();
        }
        private void frm_ThongBao_SV_Load(object sender, EventArgs e)
        {
                LoadData_SV();
        }
    }
}
