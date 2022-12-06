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
    public partial class frm_HoaDon : Form
    {
        private frm_QuanLyPhong fmQuanLyPhong;
        public string maphong;
        private HoaDon_BUS HDBUS;
        private ChitietHD_BUS ChitietHBBUS;
        public frm_Trangchu fmtrangchu;
        public string mahd;
        public frm_HoaDon()
        {
            InitializeComponent();
            fmQuanLyPhong = new frm_QuanLyPhong();
           
            HDBUS = new HoaDon_BUS();
            ChitietHBBUS = new ChitietHD_BUS();
        }
        public void LoadDataAdmin()
        {
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.DataSource = HDBUS.GetAllInformation(maphong);
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
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            LoadDataAdmin();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }
        public float tong = 0;

        public float tiendien(int sodien, float giadien)
        {
            return sodien * giadien;
        }
        public float tiennuoc(int sonuoc, float gianuoc)
        {
            return sonuoc * gianuoc;
        }
        public float tongkq = 0;
        private void txtGiaDien_TextChanged(object sender, EventArgs e)
        {
            tongkq = 0;
            int sodien = 0;
            if (!string.IsNullOrEmpty(txtSoDien.Text))
            {
                sodien = int.Parse(txtSoDien.Text);
            }
            float giadien = 0;
            string s = txtGiaDien.Text.ToString();
            if (string.IsNullOrEmpty(s))
            {
                giadien = 0;
            }
            else {
                giadien = float.Parse(txtGiaDien.Text);
            }
            tongkq = tiendien(sodien, giadien);
            float tongtruoc = tongkq1;
            float tongsau = tongtruoc + tiendien(sodien, giadien);
            txtTongTien.Text = tongsau.ToString();
        }
        public float tongkq1 = 0;
        private void txtGiaNuoc_TextChanged(object sender, EventArgs e)
        {
            tongkq1 = 0;
            int sonuoc = 0;
            if (!string.IsNullOrEmpty(txtSoNuoc.Text))
            {
                sonuoc = int.Parse(txtSoDien.Text);
            }
            float gianuoc = 0;
            string s = txtGiaNuoc.Text.ToString();
            if (string.IsNullOrEmpty(s))
            {
                gianuoc = 0;
            }
            else
            {
                gianuoc = float.Parse(txtGiaNuoc.Text);
            }
            tongkq1 = tiennuoc(sonuoc, gianuoc);
            float tongtruoc = tongkq;
            float tongsau = tongtruoc + tiennuoc(sonuoc, gianuoc);
            txtTongTien.Text = tongsau.ToString();
        }
        public float tongkq2 = 0;
        public float tongkq3 = 0;
        private void txtSoDien_TextChanged(object sender, EventArgs e)
        {
            tongkq2 = 0;
            tongkq3 = 0;
            if (String.IsNullOrEmpty(txtGiaDien.Text) || String.IsNullOrEmpty(txtSoDien.Text))
            {
                tongkq2 = 0;
            }
            else
            {
                tongkq2 = tiendien(int.Parse(txtSoDien.Text), float.Parse(txtGiaDien.Text));
            }
            if (String.IsNullOrEmpty(txtSoNuoc.Text) && String.IsNullOrEmpty(txtGiaNuoc.Text))
                tongkq3 = 0;
            else if (!String.IsNullOrEmpty(txtSoNuoc.Text) && !String.IsNullOrEmpty(txtGiaNuoc.Text))
                tongkq3 = tiennuoc(int.Parse(txtSoNuoc.Text), float.Parse(txtGiaNuoc.Text));
            float tongsau = tongkq2 + tongkq3;
            txtTongTien.Text = tongsau.ToString();
        }
        private void txtSoNuoc_TextChanged(object sender, EventArgs e)
        {
            tongkq2 = 0;
            tongkq3 = 0;
            if (String.IsNullOrEmpty(txtGiaNuoc.Text) || String.IsNullOrEmpty(txtSoNuoc.Text))
            {
                tongkq3 = 0;
            }
            else
            {
                tongkq3 = tiennuoc(int.Parse(txtSoNuoc.Text), float.Parse(txtGiaNuoc.Text));
            }
            if (String.IsNullOrEmpty(txtSoDien.Text) && String.IsNullOrEmpty(txtGiaDien.Text))
                tongkq2 = 0;
            else if(!String.IsNullOrEmpty(txtSoDien.Text) && !String.IsNullOrEmpty(txtGiaDien.Text))
                tongkq2 = tiendien(int.Parse(txtSoDien.Text), float.Parse(txtGiaDien.Text));
            float tongsau = tongkq2 + tongkq3;
            txtTongTien.Text = tongsau.ToString();
        }
        bool them;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int tt = 0;
            if (them)
            {
                float tongtien = float.Parse(txtTongTien.Text);
                HDBUS.AddHD(txtMaHD.Text, maphong, dateTimePicker1.Value, 0, tongtien);
                ChitietHBBUS.AddDetailInvoice(txtMaHD.Text, int.Parse(txtSoDien.Text), int.Parse(txtSoNuoc.Text), float.Parse(txtGiaDien.Text), float.Parse(txtGiaNuoc.Text));
                txtTongTien.Text = tong.ToString();
            }
            else
            {
                string s1 = cbTrangThai.Text.ToString();
                if (s1 == "Đã Thanh toán")
                {
                    tt = 1;
                }
                else
                {
                    tt = 0;
                }
                HDBUS.UpdateInvoice(txtMaHD.Text, maphong, dateTimePicker1.Value, tt, float.Parse(txtTongTien.Text));
                ChitietHBBUS.UpdateDetailInvoice(txtMaHD.Text, int.Parse(txtSoDien.Text), int.Parse(txtSoNuoc.Text), float.Parse(txtGiaDien.Text), float.Parse(txtGiaNuoc.Text));
            }
            LoadDataAdmin();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            int check = HDBUS.CheckTaoHD(maphong);
            if(check == 0)
            {
                MessageBox.Show("Không thể tạo mới hóa đơn. Vì hóa đơn trước đó chưa được thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                them = true;
                cbTrangThai.Text = "Chưa thanh toán";
                txtMaPhong.Text = maphong;
                string madh = RandomString(7);
                txtMaHD.Text = madh;
                txtMaHD.Enabled = false;
                cbTrangThai.Enabled = false;
                txtTongTien.Text = "0";
                tong = float.Parse(txtTongTien.Text);
                txtSoDien.Clear();
                txtSoNuoc.Clear();
                txtGiaDien.Clear();
                txtGiaNuoc.Clear();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            mahd = dgvHoaDon.Rows[r].Cells[0].Value.ToString();

            //fmChitietHD = new frm_ChitietHoaDon();
            //fmChitietHD.mahd = mahd;
            //fmChitietHD.Show();

            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.DataSource = ChitietHBBUS.GetAllInformation(mahd);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            int r = dgvHoaDon.CurrentCell.RowIndex;
            string trangthai = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            if (trangthai == "False" || String.IsNullOrEmpty(trangthai))
            {
                
                cbTrangThai.Text = "Chưa thanh toán";
                txtMaHD.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                txtMaPhong.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dgvHoaDon.Rows[r].Cells[2].Value.ToString());
                DataTable dt = ChitietHBBUS.GetAllInformation(txtMaHD.Text);
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    txtSoDien.Text = dt.Rows[i].ItemArray[1].ToString();
                    txtSoNuoc.Text = dt.Rows[i].ItemArray[2].ToString();
                    txtGiaDien.Text = dt.Rows[i].ItemArray[3].ToString();
                    txtGiaNuoc.Text = dt.Rows[i].ItemArray[4].ToString();
                }
                txtTongTien.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
                
            }
            else
            {
                cbTrangThai.Text = "Đã thanh toán";
                MessageBox.Show("Hóa đơn này đã được thanh toán. Vui lòng không được sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHD.Clear();
                txtMaPhong.Clear();
                txtSoDien.Clear();
                txtSoNuoc.Clear();
                txtGiaDien.Clear();
                txtGiaNuoc.Clear();
                txtTongTien.Clear();
                gbHoaDon.Enabled = false;
            } 
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            LoadDataAdmin();
        }
    }
}
