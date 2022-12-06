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
    public partial class frm_ThietBiTrongPhong : Form
    {
        private ThietbiTrongPhong_BUS ThietBi_PhongBUS;
        public frm_Phong frmPhong;
        public string maphong;
        public frm_ThietBiTrongPhong()
        {
            InitializeComponent();
            ThietBi_PhongBUS = new ThietbiTrongPhong_BUS();
        }

        public void LoadData()
        {
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.DataSource = ThietBi_PhongBUS.GetAllInformation(maphong);
        }

        private void frm_ThietBiTrongPhong_Load(object sender, EventArgs e)
        {
            gbThongTinThietBi.Enabled = false;
            LoadData();

            cbbTenTBITimKiem.DataSource = ThietBi_PhongBUS.TenTbi_Phong(maphong);
            cbbTenTBITimKiem.DisplayMember = "TenThietBi";
            cbbTenTBITimKiem.ValueMember = "TenThietBi";
        }
        public bool them = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            them = true;
            gbThongTinThietBi.Enabled = true;
            cbbTenThietBi.DataSource = ThietBi_PhongBUS.GetTenTB();
            cbbTenThietBi.DisplayMember = "TenThietBi";
            cbbTenThietBi.ValueMember = "TenThietBi";

            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnLoad.Enabled = true;
            btnSua.Enabled = false;

            txtSoLuongHong.Enabled = false;
            txtSoLuongTot.Enabled = false;
            txtSoLuongToiDa.Enabled = true;
            cbbTenThietBi.Enabled = true;
            txtMaThietBi.Enabled = false;
        }

        private void cbbTenThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matb = ThietBi_PhongBUS.MaTB_Ten(cbbTenThietBi.Text);
            txtMaThietBi.Text = matb;
        }

        public bool checkThem(string tentbi)
        {
            DataTable dt = ThietBi_PhongBUS.TenTbi_Phong(maphong);
            List<String> lst = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["TenThietBi"].ToString();
                lst.Add(name);
            }
            bool isExists = lst.Contains(tentbi);
            return isExists;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soluongtot = int.Parse(txtSoLuongToiDa.Text);
            if (them == true)
            {
                if (!checkThem(cbbTenThietBi.Text))
                {
                    ThietBi_PhongBUS.ThemTbiPhong(txtMaThietBi.Text, maphong, 0, soluongtot, soluongtot);
                }
                else
                {
                    MessageBox.Show("Thiết bị đã tồn tại trong phòng. Vui lòng thêm thiết bị khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                int slhong = int.Parse(txtSoLuongHong.Text);

                ThietBi_PhongBUS.SuaTbiPhong(txtMaThietBi.Text, maphong, slhong, soluongtot - slhong, soluongtot);
            }
            LoadData();

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLoad.Enabled = true;
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gbThongTinThietBi.Enabled = true;
            them = false;
            int r = dgvThietBi.CurrentCell.RowIndex;
            string tentbi = dgvThietBi.Rows[r].Cells[0].Value.ToString();
            int slhong = int.Parse(dgvThietBi.Rows[r].Cells[1].Value.ToString());
            int sltot = int.Parse(dgvThietBi.Rows[r].Cells[2].Value.ToString());
            int sltoida = int.Parse(dgvThietBi.Rows[r].Cells[3].Value.ToString());

            cbbTenThietBi.Text = tentbi;
            string matb = ThietBi_PhongBUS.MaTB_Ten(cbbTenThietBi.Text);
            txtSoLuongHong.Text = slhong.ToString();
            txtSoLuongTot.Text = sltot.ToString();
            txtSoLuongToiDa.Text = sltoida.ToString();
            txtMaThietBi.Text = matb;
            cbbTenThietBi.Enabled = false;
            txtMaThietBi.Enabled = false;
            txtSoLuongHong.Enabled = true;
            txtSoLuongToiDa.Enabled = false;
            txtSoLuongTot.Enabled = false;

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnLoad.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.DataSource = ThietBi_PhongBUS.Timkiem(maphong, cbbTenTBITimKiem.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            btnLoad.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
        }
    }
}
