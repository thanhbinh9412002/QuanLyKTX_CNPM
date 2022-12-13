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
    public partial class frm_SinhVien : Form
    {
        public SinhVien_BUS SinhvienBUS = new SinhVien_BUS();
        public frm_SinhVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvSinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvSinhvien.DataSource = SinhvienBUS.Danhsachsinhvien();
        }
        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Hàm Vadidate 
        public bool Hople()
        {
            if (Checktextbox() == true && Check_mssv() == true && Check_cccd() == true && Check_sdt() == true)
                return true;
            else
                return false;
        }
        public bool Check_mssv()
        {
            int n = Int32.Parse(dgvSinhvien.RowCount.ToString());
            bool hople = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (tb_mssv.Text == dgvSinhvien.Rows[i].Cells[0].Value.ToString())
                {
                    hople = false;
                    break;
                }
            }
            if (hople == false)
                return false;
            else
                return true;
        }
        public bool Check_sdt()
        {
            int n = Int32.Parse(dgvSinhvien.RowCount.ToString());
            bool hople = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (tb_sdt.Text == dgvSinhvien.Rows[i].Cells[2].Value.ToString())
                {
                    hople = false;
                    break;
                }
            }
            if (hople == false)
                return false;
            else
                return true;
        }
        public bool Check_cccd()
        {
            int n = Int32.Parse(dgvSinhvien.RowCount.ToString());
            bool hople = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (tb_cccd.Text == dgvSinhvien.Rows[i].Cells[7].Value.ToString())
                {
                    hople = false;
                    break;
                }
            }
            if (hople == false)
                return false;
            else
                return true;
        }
        public bool Checktextbox()
        {
            if (
            tb_mssv.Text == "" ||
            tb_hoten.Text == "" ||
            tb_sdt.Text == "" ||
            cb_gioitinh.Text == "" ||
            tb_namhoc.Text == "" ||
            tb_tongiao.Text == "" ||
            tb_quoctich.Text == "" ||
            tb_cccd.Text == "" ||
            tb_maphong.Text == "" ||
            tb_soky.Text == "")
            {
                return false;
            }
            else
                return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Hople() == true)
            {
                int namhoc = Int32.Parse(tb_namhoc.Text);
                int soky = Int32.Parse(tb_soky.Text);
                SinhvienBUS.Themsinhvien(tb_mssv.Text, tb_hoten.Text, tb_sdt.Text, cb_gioitinh.Text, namhoc, tb_tongiao.Text, tb_quoctich.Text, tb_cccd.Text, tb_maphong.Text, soky);
                MessageBox.Show("Thành Công");
                DeletedataTextbox();
                LoadData();
            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào không hợp lệ");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (Checktextbox() == true)
            {
                int namhoc = Int32.Parse(tb_namhoc.Text);
                int soky = Int32.Parse(tb_soky.Text);
                DialogResult dg = MessageBox.Show("Bạn có chắc muốn thay đổi?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    SinhvienBUS.Suasinhvien(tb_mssv.Text, tb_hoten.Text, tb_sdt.Text, cb_gioitinh.Text, namhoc, tb_tongiao.Text, tb_quoctich.Text, tb_cccd.Text, tb_maphong.Text, soky);
                    MessageBox.Show("Cập nhật thành công");
                    DeletedataTextbox();
                    LoadData();
                }
            }
            else
                MessageBox.Show("Hãy điền đầy đủ thông tin");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (Checktextbox() != true)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    SinhvienBUS.Xoasinhvien(tb_mssv.Text);
                    MessageBox.Show("Xóa thành công");
                    DeletedataTextbox();
                    LoadData();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DeletedataTextbox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSinhvien.CurrentRow.Index;
            tb_mssv.Text = dgvSinhvien.Rows[i].Cells[0].Value.ToString();
            tb_hoten.Text = dgvSinhvien.Rows[i].Cells[1].Value.ToString();
            tb_sdt.Text = dgvSinhvien.Rows[i].Cells[2].Value.ToString();
            cb_gioitinh.Text = dgvSinhvien.Rows[i].Cells[3].Value.ToString();
            tb_namhoc.Text = dgvSinhvien.Rows[i].Cells[4].Value.ToString();
            tb_tongiao.Text = dgvSinhvien.Rows[i].Cells[5].Value.ToString();
            tb_quoctich.Text = dgvSinhvien.Rows[i].Cells[6].Value.ToString();
            tb_cccd.Text = dgvSinhvien.Rows[i].Cells[7].Value.ToString();
            tb_maphong.Text = dgvSinhvien.Rows[i].Cells[8].Value.ToString();
            tb_soky.Text = dgvSinhvien.Rows[i].Cells[9].Value.ToString();
        }
        public void DeletedataTextbox()
        {
            tb_mssv.Text = "";
            tb_hoten.Text = "";
            tb_sdt.Text = "";
            cb_gioitinh.Text = "";
            tb_namhoc.Text = "";
            tb_tongiao.Text = "";
            tb_quoctich.Text = "";
            tb_cccd.Text = "";
            tb_maphong.Text = "";
            tb_soky.Text = "";
        }
    }
}
