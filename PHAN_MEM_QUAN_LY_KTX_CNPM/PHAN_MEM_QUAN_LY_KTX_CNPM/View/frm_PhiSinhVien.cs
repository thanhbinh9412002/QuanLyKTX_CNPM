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
        frm_Trangchu fmtrangchu;
        public string mssv;
        public string maphong;
        public frm_PhiSinhVien()
        {
            InitializeComponent();
            PhiSinhVienBUS = new PhiSinhVien_BUS();
            fmtrangchu = new frm_Trangchu();
            mssv = fmtrangchu.MaSinhVien;
            maphong = fmtrangchu.MaPhong;
        }

        private void frm_PhiSinhVien_Load(object sender, EventArgs e)
        {
            LoadDataAdmin();
        }
        public void LoadDataAdmin()
        {
            MessageBox.Show(mssv);
            MessageBox.Show(maphong);
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "CheckBox";
            DataTable dt = PhiSinhVienBUS.GetAllInformation(maphong);
            DataTable dt1 = PhiSinhVienBUS.GetAccountSV(mssv);

            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                string matk = dt1.Rows[i].ItemArray[0].ToString();
                string tinhtrang = dt1.Rows[i].ItemArray[1].ToString();
                if (tinhtrang == "True")
                {
                    txtTinhTrang.Text = "Hoạt động";
                }else
                {
                    txtTinhTrang.Text = "Khóa";
                }
                string tenchutk = dt1.Rows[i].ItemArray[4].ToString();
                DateTime ngaycap = DateTime.Parse(dt1.Rows[i].ItemArray[2].ToString());
                DateTime ngayhethan = DateTime.Parse(dt1.Rows[i].ItemArray[3].ToString());
                txtMaTK.Text = matk; 
                txtTenchuTK.Text = tenchutk;
                dateTimePicker1.Value = ngaycap;
                dateTimePicker2.Value = ngayhethan;
            }
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
            //double tongtien = 0;
            //for (int i = 0; i < dgvPhiSinhVien.RowCount - 1; i++)
            //{
            //    if(Convert.ToBoolean(dgvPhiSinhVien.Rows[i].Cells["Chk"].Value) == true)
            //    {
            //        double tmp = double.Parse(dgvPhiSinhVien.Rows[i].Cells[4].Value.ToString());
            //        tongtien = tongtien + tmp;
            //    }
            //}
            //MessageBox.Show(tongtien.ToString());
            //System.Diagnostics.Process.Start("https://ibank.agribank.com.vn/ibank/index.jsp");

            float tongtien = 0;
            for (int i = 0; i < dgvPhiSinhVien.RowCount - 1; i++)
            {
                dgvPhiSinhVien.Rows[i].Cells["Chk"].Value = true;
                float tmp = float.Parse(dgvPhiSinhVien.Rows[i].Cells[4].Value.ToString());
                tongtien = tongtien + tmp;
            }
            MessageBox.Show(tongtien.ToString());
            System.Diagnostics.Process.Start("https://ibank.agribank.com.vn/ibank/index.jsp");
        }
    }
}
