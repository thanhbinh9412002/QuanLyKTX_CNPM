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
using static PHAN_MEM_QUAN_LY_KTX_CNPM.frm_QuanLyPhong;
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    public partial class frm_Phong : Form
    {
        private Phong_BUS PhongBUS;
        public frm_ChiTietPhong fmChiTietPhong;
        public frm_Trangchu fmTrangchu;
        public string maphong;
        public frm_QuanLyPhong fmquanly;

        public string MaPhong1; // lấy mã phòng ra để truyền sang form chi tiết phòng và form hóa đơn
        public int sukien = 0;// kiểm tra xem người dùng đã chọn hàng nào trong datagirdview chưa trước khi chuyển sang form khác --> form quản lý phòng sẽ nhận

        public frm_QuanLyPhong.SendMessage sender;
        public frm_QuanLyPhong.SendMessage send;

        public frm_Phong(SendMessage sender, SendMessage send)
        {
            InitializeComponent();
            PhongBUS = new Phong_BUS();
            this.sender = sender;
            this.send = send;
        }

        public void LoadDataAdmin()
        {
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.DataSource = PhongBUS.GetAllInformation();
            
        }
        public void LoadTextBox_CheckBox()
        {
            cbbTinhTrang.Text = "Đang sử dụng";
            int SVHienTai = 0;
            txtSVHienTai.Text = SVHienTai.ToString();
        }
/*
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
        }*/

        private void frm_Phong_Load(object sender, EventArgs e)
        {
            LoadDataAdmin();
            gbThongTinPhong.Enabled = false;
            LoadTextBox_CheckBox();
        }

       /* private void btnThoat_Click(object sender, EventArgs e)
        {
            panel_child.Visible = false;
            main_panel.Visible = true; main_panel.Controls.Clear();

            frm_Phong fmphong = new frm_Phong();
            fmphong.TopLevel = false;
            main_panel.Controls.Add(fmphong);
            fmphong.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fmphong.Dock = DockStyle.Fill;
            fmphong.Show();
        }*/
        public static bool them = true;
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            gbThongTinPhong.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            cbbTinhTrang.Text = "Đang sử dụng";
            cbbTinhTrang.Enabled = false;
            txtSVHienTai.Text = "0";

        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sukien == 1)
            {
                int r = dgvPhong.CurrentCell.RowIndex;
                string MaPhong = dgvPhong.Rows[r].Cells[0].Value.ToString();
                int svhientai = Convert.ToInt32(dgvPhong.Rows[r].Cells[2].Value.ToString());
                DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa không?", "Error", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    if (svhientai == 0)
                    {
                        PhongBUS.DeleteRoom(MaPhong);
                        MessageBox.Show("Xóa thành công");
                        LoadDataAdmin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng cần xóa. Mời chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            them = false;
            btnLuu.Enabled = true;
            gbThongTinPhong.Enabled = true;
            if (sukien == 1)
            {
                int r = dgvPhong.CurrentCell.RowIndex;
                txtMaPhong.Text = dgvPhong.Rows[r].Cells[0].Value.ToString();
                txtMaPhong.Enabled = false;
                txtGiaPhong.Text = dgvPhong.Rows[r].Cells[1].Value.ToString();
                txtGiaPhong.Enabled = false;
                txtSVHienTai.Text = dgvPhong.Rows[r].Cells[2].Value.ToString();
                txtSVHienTai.Enabled = false;
                cbbSVToiDa.Text = dgvPhong.Rows[r].Cells[3].Value.ToString();
                cbbTinhTrang.Text = dgvPhong.Rows[r].Cells[4].Value.ToString();
                cbbTinhTrang.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng cần sửa. Mời chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool checkThem(string maphong)
        {
            DataTable dt = PhongBUS.DanhSachMaPhong();
            List<String> lst = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["MaPhong"].ToString();
                lst.Add(name);
            }
            bool isExists = lst.Contains(maphong);
            return isExists;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                DialogResult h = MessageBox.Show("Bạn có chắc muốn thêm không?", "Error", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    PhongBUS.AddRoom(txtMaPhong.Text, int.Parse(txtGiaPhong.Text), int.Parse(txtSVHienTai.Text), int.Parse(cbbSVToiDa.Text), cbbTinhTrang.Text);
                }
            }
            else
            {
                DialogResult h = MessageBox.Show("Xác nhận thay đổi", "Error", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    PhongBUS.UpdateRoom(txtMaPhong.Text, int.Parse(txtGiaPhong.Text), int.Parse(txtSVHienTai.Text), int.Parse(cbbSVToiDa.Text), cbbTinhTrang.Text);
                }            
            }
            LoadDataAdmin();
            txtMaPhong.Clear();
            txtGiaPhong.Clear();
            txtSVHienTai.Clear();
            cbbTinhTrang.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataAdmin();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtGiaPhong.Clear();
            txtSVHienTai.Clear();
            cbbTinhTrang.Enabled = false;
            btnThem.Enabled = true;
            dgvPhong.Enabled = true;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (cbb_timkiem.Text == "Phòng còn chỗ")
            {
                dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhong.DataSource = PhongBUS.PhongConCho();
            }
            else
            {
                dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhong.DataSource = PhongBUS.PhongDay();
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                MaPhong1 = Convert.ToString(dgvPhong.CurrentRow.Cells["Mã phòng"].Value);
                sukien = 1;
                this.sender(sukien.ToString());
                this.send(MaPhong1);
            }
        }
        private void cbbSVToiDa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cbbSVToiDa.Text) == 2)
            {
                txtGiaPhong.Text = "750000";
            }
            if (int.Parse(cbbSVToiDa.Text) == 4)
            {
                txtGiaPhong.Text = "500000";
            }
            if (int.Parse(cbbSVToiDa.Text) == 6)
            {
                txtGiaPhong.Text = "350000";
            }
            if (int.Parse(cbbSVToiDa.Text) == 8)
            {
                txtGiaPhong.Text = "250000";
            }
        }
    } 
}
