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
    public partial class frm_Yeucau_Admin : Form
    {
        private string user;
        private string role;

        public int sukien = 0;
        public int id;
        public int giahan = 0;
        public int traphong = 0;
        public int suachua = 0;
        public DateTime ngaybatdau;
        public DateTime ngayketthuc;
        public int tmp = 0;


        public frm_Yeucau_Admin(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role;
        }

        private void giahano_menu_Click(object sender, EventArgs e)
        {
            if(tmp == 0)
            {
                groupBox2.Visible = true;
                tmp = 1;
            }    
            else
            {
                groupBox2.Visible = false;
                tmp = 0;
            } 
        }

        private void frm_Yeucau_Admin_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            //dateTimePicker_batdau.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //dateTimePicker_ketthuc.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //loaddata_giahan();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            ngaybatdau = dateTimePicker_batdau.Value.Date;
            ngayketthuc = dateTimePicker_ketthuc.Value.Date;
            int i = ycBUS.CapNhatThoiGianDangKy(ngaybatdau, ngayketthuc);
            if( i == 1 )
            {
                MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void suachua_menu_Click(object sender, EventArgs e)
        {
            suachua = 1;
            giahan = 0;
            traphong = 0;
            loaddata_suachua();
        }

        private void giahan_menu_Click(object sender, EventArgs e)
        {
            giahan = 1;
            traphong = 0;
            suachua = 0;
            loaddata_giahan();
        }

        private void trphong_menu_Click(object sender, EventArgs e)
        {
            traphong = 1;
            giahan = 0;
            suachua = 0;
            loaddata_traphong();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                id = int.Parse(Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value));
                sukien = 1;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            if(sukien == 1)
            {
                if(giahan == 1)
                {
                    if (ycBUS.XoaYeuCauGiaHan(id) == 1)
                    {
                        if (MessageBox.Show("Xóa yêu cầu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            loaddata_giahan();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                else if(traphong == 1)
                {
                    if (ycBUS.XoaYeuCauTraPhong(id) == 1)
                    {
                        if (MessageBox.Show("Xóa yêu cầu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            loaddata_traphong();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }   
                else if(suachua == 1)
                {
                    if (ycBUS.XoaYeuCauSuaChua(id) == 1)
                    {
                        if (MessageBox.Show("Xóa yêu cầu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            loaddata_suachua();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }   
            else
            {
                MessageBox.Show("Bạn chưa chọn yêu cầu cần xóa. Mời chọn yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            string trangthai = "Đã xem";
            if (sukien == 1)
            {
                if(suachua == 1)
                {
                    if(MessageBox.Show("Yêu cầu: Sửa chữa\n\tMã phòng:\t" + Convert.ToString(dataGridView1.CurrentRow.Cells["Mã phòng"].Value) +
                        "\n\tTên thiết bị:\t" + Convert.ToString(dataGridView1.CurrentRow.Cells["Tên thiết bị"].Value) + 
                        "\n\tSố lượng:\t"+ Convert.ToString(dataGridView1.CurrentRow.Cells["Số lượng"].Value) + 
                        "\n\tChi tiết:\t"+ Convert.ToString(dataGridView1.CurrentRow.Cells["Chi tiết"].Value),
                        "Chi tiết yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ycBUS.CapNhatTrangThaiSuaChua(id, trangthai);
                        loaddata_suachua();
                    }    
                }
                else if(giahan == 1)
                {
                    if(MessageBox.Show("Yêu cầu: Gia hạn\n\tMã sinh viên:\t" + Convert.ToString(dataGridView1.CurrentRow.Cells["Mã sinh viên"].Value) +
                       "\n\tTên sinh viên:\t"+ Convert.ToString(dataGridView1.CurrentRow.Cells["Họ và tên"].Value) +
                        "\n\tSố kỳ:\t" + Convert.ToString(dataGridView1.CurrentRow.Cells["Số kỳ"].Value)) == DialogResult.OK)
                    {
                        ycBUS.CapNhatTrangThaiTraPhong(id, trangthai);
                        loaddata_giahan();
                    }    
                }
                else if(traphong == 1)
                {
                    if (MessageBox.Show("Yêu cầu: Trả phòng\n\tMã phòng:\t" + Convert.ToString(dataGridView1.CurrentRow.Cells["Mã phòng"].Value) +
                        "\n\tMã sinh viên:\t" + Convert.ToString(dataGridView1.CurrentRow.Cells["Mã sinh viên"].Value) +
                        "\n\tTên sinh viên:\t" + Convert.ToString(dataGridView1.CurrentRow.Cells["Họ và tên"].Value) +
                        "\n\tNgày trả:\t" + Convert.ToString(dataGridView1.CurrentRow.Cells["Ngày trả"].Value),
                        "Chi tiết yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ycBUS.CapNhatTrangThaiTraPhong(id, trangthai);
                        loaddata_traphong();
                    }
                }    
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn yêu cầu cần xem chi tiết. Mời chọn yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void loaddata_suachua()
        {
            var ycBUS = new YeuCau_BUS();
            DataTable dt = ycBUS.DanhSachYeuCauSuaChua();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.DataSource = dt;
        }
        private void loaddata_giahan()
        {
            var ycBUS = new YeuCau_BUS();
            DataTable dt = ycBUS.DanhSachYeuCauGiaHan();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.DataSource = dt;
        }
        private void loaddata_traphong()
        {
            var ycBUS = new YeuCau_BUS();
            DataTable dt = ycBUS.DanhSachYeuCauTraPhong();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.DataSource = dt;
        }
    }
}
