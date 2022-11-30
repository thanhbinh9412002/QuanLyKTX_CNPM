using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PHAN_MEM_QUAN_LY_KTX_CNPM.BUS;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    public partial class frm_PhiSinhVien : Form
    {
        private PhiSinhVien_BUS PhiSinhVienBUS;
        public frm_PhiSinhVien()
        {
            InitializeComponent();
            PhiSinhVienBUS = new PhiSinhVien_BUS();
        }

        private void frm_PhiSinhVien_Load(object sender, EventArgs e)
        {
            LoadDataAdmin();
        }
        public void LoadDataAdmin()
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "CheckBox";
            DataTable dt = PhiSinhVienBUS.GetAllInformation("A102");
            
            if (dt.Rows.Count == 0)
            {
                lbPhi.Text = "Khong co thong tin no phi";
                dgvPhiSinhVien.Visible = false;
                btnThanhToan.Visible = false;
                btnThanhToanAll.Visible = false;
            }else
            {
                lbPhi.Text = "thong tin no phi";
                dgvPhiSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhiSinhVien.DataSource = dt;
            }
            dgvPhiSinhVien.Columns.Add(dgvCmb);
        }

        private void btnThanhToanAll_Click(object sender, EventArgs e)
        {
            float tongtien = 0;
            for (int i=0;i < dgvPhiSinhVien.RowCount -1; i++)
            {
                dgvPhiSinhVien.Rows[i].Cells["Chk"].Value = true;
                float tmp = float.Parse(dgvPhiSinhVien.Rows[i].Cells[4].Value.ToString());
                tongtien = tongtien + tmp;
            }
            MessageBox.Show(tongtien.ToString());
            System.Diagnostics.Process.Start("https://ibank.agribank.com.vn/ibank/index.jsp");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            float tongtien = 0;
            for (int i = 0; i < dgvPhiSinhVien.RowCount - 1; i++)
            {
                if(Convert.ToBoolean(dgvPhiSinhVien.Rows[i].Cells["Chk"].Value) == true)
                {
                    float tmp = float.Parse(dgvPhiSinhVien.Rows[i].Cells[4].Value.ToString());
                    tongtien = tongtien + tmp;
                }
            }
            MessageBox.Show(tongtien.ToString());
            System.Diagnostics.Process.Start("https://ibank.agribank.com.vn/ibank/index.jsp");
        }
    }
}
