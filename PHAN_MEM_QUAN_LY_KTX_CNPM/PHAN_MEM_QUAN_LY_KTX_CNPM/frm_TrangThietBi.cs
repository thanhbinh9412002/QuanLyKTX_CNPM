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
    public partial class frm_TrangThietBi : Form
    {
        private ThietBi_BUS ThietBiBUS;
        private ThietbiTrongPhong_BUS Tbi_PhongBUS;
        public frm_TrangThietBi()
        {
            InitializeComponent();
            ThietBiBUS = new ThietBi_BUS();
            Tbi_PhongBUS = new ThietbiTrongPhong_BUS();
        }
        public void LoadData()
        {
            dgv_trangthietbi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_trangthietbi.DataSource = ThietBiBUS.GetAllInformation();

            cbbTenTBITimKiem.DataSource = Tbi_PhongBUS.GetTenTB();
            cbbTenTBITimKiem.DisplayMember = "TenThietBi";
            cbbTenTBITimKiem.ValueMember = "TenThietBi";
        }

        private void frm_TrangThietBi_Load(object sender, EventArgs e)
        {
            gbThongTinTB.Enabled = false;
            LoadData();

            btn_luu.Enabled = false;
            btnHuy.Enabled = false;
        }
        public static String RandomString(int length)
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return (str_build.ToString());
        }
        bool them = false;
        public bool CheckTenTbi(string tentbi)
        {
            DataTable dt = Tbi_PhongBUS.GetTenTB();
            List<String> lst = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["TenThietBi"].ToString();
                lst.Add(name);
            }
            bool isExists = lst.Contains(tentbi);
            return isExists;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string tentbi = txt_tenthietbi.Text;
            if (them == true)
            {
                if (!CheckTenTbi(tentbi))
                {
                    ThietBiBUS.ThemTBi(txt_mathietbi.Text, tentbi, int.Parse(txt_soluong.Text));
                }
                else
                {
                    MessageBox.Show("Tên thiết bị đã tồn tại. Vui lòng chọn tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                ThietBiBUS.SuaTBi(txt_mathietbi.Text, txt_tenthietbi.Text, int.Parse(txt_soluong.Text));
            }
            LoadData();

            btn_luu.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            gbThongTinTB.Enabled = true;
            them = false;
            int r = dgv_trangthietbi.CurrentCell.RowIndex;
            txt_mathietbi.Text = dgv_trangthietbi.Rows[r].Cells[0].Value.ToString();
            txt_tenthietbi.Text = dgv_trangthietbi.Rows[r].Cells[1].Value.ToString();
            txt_soluong.Text = dgv_trangthietbi.Rows[r].Cells[2].Value.ToString();

            txt_mathietbi.Enabled = false;
            txt_tenthietbi.Enabled = false;

            btnHuy.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            them = true;
            gbThongTinTB.Enabled = true;
            txt_mathietbi.Text = RandomString(3);
            txt_mathietbi.Enabled = false;
            txt_tenthietbi.Enabled = true;

            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            btnHuy.Enabled = true;
            btnLoad.Enabled = true;
            btn_sua.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            btnLoad.Enabled = true;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgv_trangthietbi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_trangthietbi.DataSource = ThietBiBUS.Timkiem(cbbTenTBITimKiem.Text);
        }
    }
}
